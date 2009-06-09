using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

namespace CFlat
{
    public class ClrCodeGenerator : ICodeGenerator
    {
        private readonly string outputFileName;
        private ModuleBuilder mainModuleBuilder;
        AssemblyBuilder assemblyBuilder;
        private TypeBuilder currentType;
        private MethodBuilder currentMethod;
        private ILGenerator ilGenerator;
        private string assemblyName;
        private Dictionary<string, LocalBuilder> methodVariables = new Dictionary<string, LocalBuilder>();
        private Stack<Label> ifLabels = new Stack<Label>();

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

        public void BeginMethod(string name)
        {
            currentMethod = currentType.DefineMethod(name, MethodAttributes.Static | MethodAttributes.Public, typeof(object), Type.EmptyTypes);
            ilGenerator = currentMethod.GetILGenerator();
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
                case Operator.LessThan:
                    {
                        ilGenerator.Emit(OpCodes.Clt);
                        var localBuilder = ilGenerator.DeclareLocal(typeof (bool));
                        ilGenerator.Emit(OpCodes.Stloc, localBuilder);
                        ilGenerator.Emit(OpCodes.Ldloc, localBuilder);
                    }
                    break;
                case Operator.GreaterThan:
                    {
                        ilGenerator.Emit(OpCodes.Cgt);
                        var localBuilder = ilGenerator.DeclareLocal(typeof (bool));
                        ilGenerator.Emit(OpCodes.Stloc, localBuilder);
                        ilGenerator.Emit(OpCodes.Ldloc, localBuilder);
                    }
                    break;
                default:
                    throw new InvalidOperationException("Invalid operation: " + operation);
            }
        }

        public void Comment(string comment)
        {
            throw new System.NotImplementedException();
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
            var variable = methodVariables[name];
            ilGenerator.Emit(OpCodes.Ldloc, variable.LocalIndex);
        }

        public void ExprBool(bool i)
        {
            if (i)
                ilGenerator.Emit(OpCodes.Ldc_I4_1);
            else
                ilGenerator.Emit(OpCodes.Ldc_I4_0);
        }

        public void ExprChar(char value)
        {
            throw new NotImplementedException();
        }

        public void MethodCall(string name)
        {
            throw new NotImplementedException();
        }

        public void BeginMethodArguments()
        {
            throw new NotImplementedException();
        }

        public void AssignExpression(string name)
        {
            ilGenerator.Emit(OpCodes.Stloc, methodVariables[name].LocalIndex);
        }

        public void DefineVariable(string name, Types type)
        {
            var localBuilder = ilGenerator.DeclareLocal(typeof(int));
            methodVariables.Add(name, localBuilder);
        }

        public MethodInfo GetCurrentMethod()
        {
            mainModuleBuilder.CreateGlobalFunctions();
            return currentMethod;
        }

        public void ReturnExpression(Types type)
        {
            switch (type)
            {
                case Types.Bool:
                    ilGenerator.Emit(OpCodes.Box, typeof(bool));
                    break;
                case Types.Int:
                    ilGenerator.Emit(OpCodes.Box, typeof(int));
                    break;
            }
                
            ilGenerator.Emit(OpCodes.Ret);
        }

        public void EndMethod()
        {
            ilGenerator.Emit(OpCodes.Ret);
        }

        public void Return(string name)
        {
            var variable = methodVariables[name];
            ilGenerator.Emit(OpCodes.Ldloc, variable.LocalIndex);

            ilGenerator.Emit(OpCodes.Box, typeof(int));

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
    }
}
