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
        private ExpressionType currentExpressionType;
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
            currentMethod = currentType.DefineMethod(name, MethodAttributes.Static | MethodAttributes.Public, typeof(object), System.Type.EmptyTypes);
            ilGenerator = currentMethod.GetILGenerator();
        }

        public void BeginExpression()
        {
        }

        public void ExprNumber(int i)
        {
            ilGenerator.Emit(OpCodes.Ldc_I4_S, i);
        }

        public void Operation(string operationName)
        {
            if (operationName == "Multiplication")
            {
                ilGenerator.Emit(OpCodes.Mul);
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
            currentExpressionType = ExpressionType.Object;
            ilGenerator.Emit(OpCodes.Ldstr, value);
        }

        public void ExprId(string name)
        {
            throw new System.NotImplementedException();
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

        public void DefineVariable(string name, string type)
        {
            var localBuilder = ilGenerator.DeclareLocal(typeof(int));
            methodVariables.Add(name, localBuilder);
        }

        public MethodInfo GetCurrentMethod()
        {
            mainModuleBuilder.CreateGlobalFunctions();
            return currentMethod;
        }

        public void ReturnExpression()
        {
            if (currentExpressionType == ExpressionType.Value)
                ilGenerator.Emit(OpCodes.Box, typeof(int));

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
