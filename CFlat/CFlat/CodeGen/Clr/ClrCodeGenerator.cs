using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace CFlat.CodeGen.Clr
{
    public class ClrCodeGenerator : ICodeGenerator
    {
        private readonly string outputFileName;
        private ModuleBuilder mainModuleBuilder;
        AssemblyBuilder assemblyBuilder;
        private TypeBuilder currentType;
        private MethodData currentMethod;
        private ILGenerator ilGenerator;
        private string assemblyName;
        private Stack<Label> ifLabels = new Stack<Label>();
        private Dictionary<string, MethodData> classMethods = new Dictionary<string, MethodData>();
        private Stack<Label> beforeWhileLabels = new Stack<Label>();
        private Stack<Label> afterWhileLabels = new Stack<Label>();

        public ClrCodeGenerator(string outputFileName)
            : this(outputFileName, false)
        {
        }

        public ClrCodeGenerator(string outputFileName, bool inMemory)
        {
            this.outputFileName = outputFileName;
            string name = Path.GetFileNameWithoutExtension(outputFileName);
            this.assemblyName = name;
            var assemblyName = new AssemblyName(name);

            AssemblyBuilderAccess accessType = AssemblyBuilderAccess.Save;

            if (inMemory) accessType = AssemblyBuilderAccess.Run;

            assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName,
                                                                            accessType);

            mainModuleBuilder = assemblyBuilder.DefineDynamicModule(outputFileName, true);
        }

        public string Name
        {
            get { return assemblyName; }
        }

        public void StartModule(string id)
        {
            currentType = mainModuleBuilder.DefineType(id);
        }

        public void EndModule()
        {
            currentType.CreateType();
        }

        public void Save()
        {
            mainModuleBuilder.CreateGlobalFunctions();
            assemblyBuilder.Save(outputFileName);
        }

        public void RegisterMethod(string name, Types returnType, params Parameter[] parameters)
        {
            Type[] types = (from p in parameters
                            select p.Type.ClrType).ToArray();

            var method = currentType.DefineMethod(name, MethodAttributes.Static | MethodAttributes.Public, typeof(object), types);

            MethodData methodData = new MethodData(method, returnType, new Dictionary<string, IVariable>());

            int x = 0;
            foreach (var parameter in parameters)
            {
                methodData.Varables.Add(parameter.Name, new ParameterVariable(x, methodData, parameter.Type.ClrType));
                x++;
            }

            classMethods.Add(name, methodData);
        }

        public void BeginMethod(string name)
        {
            currentMethod = classMethods[name];
            ilGenerator = currentMethod.Builder.GetILGenerator();
        }

        public void BeginExpression()
        {
        }

        public void ExprNumber(int i)
        {
            ilGenerator.Emit(OpCodes.Ldc_I4_S, i);
        }

        public void Operation(Operator operation)
        {
            switch (operation)
            {
                case Operator.Multiply:
                    ilGenerator.Emit(OpCodes.Mul);
                    break;
                case Operator.Add:
                    ilGenerator.Emit(OpCodes.Add);
                    break;
                case Operator.Subtract:
                    ilGenerator.Emit(OpCodes.Sub);
                    break;
                case Operator.Divide:
                    ilGenerator.Emit(OpCodes.Div);
                    break;
                case Operator.Mod:
                    ilGenerator.Emit(OpCodes.Rem);
                    break;
                case Operator.LessThan:
                    {
                        ilGenerator.Emit(OpCodes.Clt);
                        var localBuilder = ilGenerator.DeclareLocal(typeof(bool));
                        ilGenerator.Emit(OpCodes.Stloc, localBuilder);
                        ilGenerator.Emit(OpCodes.Ldloc, localBuilder);
                    }
                    break;
                case Operator.GreaterThan:
                    {
                        ilGenerator.Emit(OpCodes.Cgt);
                        var localBuilder = ilGenerator.DeclareLocal(typeof(bool));
                        ilGenerator.Emit(OpCodes.Stloc, localBuilder);
                        ilGenerator.Emit(OpCodes.Ldloc, localBuilder);
                    }
                    break;
            }
        }

        public void EndExpression()
        {
        }

        public void ExprString(string value)
        {
            ilGenerator.Emit(OpCodes.Ldstr, value);
        }

        public void ExprId(string name)
        {
            var variable = currentMethod.Varables[name];
            variable.PushToStack();
        }

        public void ExprBool(bool i)
        {
            if (i)
                ilGenerator.Emit(OpCodes.Ldc_I4_1);
            else
                ilGenerator.Emit(OpCodes.Ldc_I4_0);
        }

        public void MethodCall(string name)
        {
            var method = classMethods[name];
            ilGenerator.Emit(OpCodes.Call, method.Builder);
            
            if(currentMethod.ReturnType != Types.Void)
                ilGenerator.Emit(OpCodes.Unbox_Any, currentMethod.ReturnType.ClrType);
        }

        public void AssignExpression(string name)
        {
            currentMethod.Varables[name].StoreFromStack();
        }

        public void DefineVariable(string name, Types type)
        {
            currentMethod.Varables.Add(name, new LocalVariable(name, currentMethod, type.ClrType));
        }

        public void ReturnExpression(Types type)
        {
            ilGenerator.Emit(OpCodes.Box, type.ClrType);
            
            ilGenerator.Emit(OpCodes.Ret);
        }

        public void EndMethod()
        {
            ilGenerator.Emit(OpCodes.Ret);
        }

        public void Return(string name)
        {
            var variable = currentMethod.Varables[name];
            variable.PushToStack();

            var varType = variable.ClrType;
            ilGenerator.Emit(OpCodes.Box, varType);

            ilGenerator.Emit(OpCodes.Ret);
        }

        public void BeginIf()
        {
            var afterIf = ilGenerator.DefineLabel();
            ilGenerator.Emit(OpCodes.Brfalse, afterIf);
            ifLabels.Push(afterIf);
        }

        public void EndIf()
        {
            var afterIf = ifLabels.Pop();
            ilGenerator.MarkLabel(afterIf);
        }

        public void BeginWhileBody()
        {
            var afterWhile = ilGenerator.DefineLabel();
            ilGenerator.Emit(OpCodes.Brfalse, afterWhile);
            afterWhileLabels.Push(afterWhile);
        }

        public void EndWhile()
        {
            var beforeWhileLabel = beforeWhileLabels.Pop();
            ilGenerator.Emit(OpCodes.Br, beforeWhileLabel);

            var afterWhileLabel = afterWhileLabels.Pop();
            ilGenerator.MarkLabel(afterWhileLabel);
        }

        public void BeginWhileExpression()
        {
            var beforeWhile = ilGenerator.DefineLabel();
            ilGenerator.MarkLabel(beforeWhile);
            beforeWhileLabels.Push(beforeWhile);
        }
    }

    public class ParameterVariable : IVariable
    {
        private readonly int Number;
        private readonly MethodData MethodData;

        public ParameterVariable(int number, MethodData methodData, Type type)
        {
            Number = number;
            Type = type;
            MethodData = methodData;
        }

        public void PushToStack()
        {
            MethodData.Builder.GetILGenerator().Emit(OpCodes.Ldarg, Number);
        }

        public void StoreFromStack()
        {
            MethodData.Builder.GetILGenerator().Emit(OpCodes.Starg, Number);
        }

        public Type ClrType
        {
            get { return Type; }
        }

        private Type Type;
    }
}