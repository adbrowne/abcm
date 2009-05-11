using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

namespace Decaf
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

        private ExpressionType currentExpressionType;

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

        public TypeBuilder StartModule(string id)
        {
            currentType = mainModuleBuilder.DefineType(id);
            return currentType;
        }

        public void Save()
        {
            mainModuleBuilder.CreateGlobalFunctions();
            assemblyBuilder.Save(outputFileName);
        }

        public void BeginExpression()
        {
            currentMethod = currentType.DefineMethod("Test", MethodAttributes.Static | MethodAttributes.Public, typeof(object), System.Type.EmptyTypes);
            ilGenerator = currentMethod.GetILGenerator();
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
            if(currentExpressionType == ExpressionType.Value)
                ilGenerator.Emit(OpCodes.Box, typeof(int));

            ilGenerator.Emit(OpCodes.Ret);
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
            throw new System.NotImplementedException();
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

        public MethodInfo GetCurrentMethod()
        {
            mainModuleBuilder.CreateGlobalFunctions();
            return currentMethod;
        }
    }
}
