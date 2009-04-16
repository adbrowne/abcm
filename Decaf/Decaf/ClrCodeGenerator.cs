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
        private ILGenerator ilGenerator;

        public ClrCodeGenerator(string outputFileName)
        {
            this.outputFileName = outputFileName;
            string name = Path.GetFileNameWithoutExtension(outputFileName);
            var assemblyName = new AssemblyName(name);
            assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName,
                                                                        AssemblyBuilderAccess.Save);

            mainModuleBuilder = assemblyBuilder.DefineDynamicModule(outputFileName);    
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
            var methodBuilder = currentType.DefineMethod("Main", MethodAttributes.Static, typeof(void), System.Type.EmptyTypes);
            ilGenerator = methodBuilder.GetILGenerator();
            
            
        }

        public void ExprNumber(int i)
        {
            ilGenerator.Emit(OpCodes.Ldc_I4_S, i);
        }

        public void Operation(string operationName)
        {
         if(operationName == "Multiplication")
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
            ilGenerator.Emit(OpCodes.Call, typeof(System.Console).GetMethod("WriteLine", new System.Type[] { typeof(int) }));
            ilGenerator.Emit(OpCodes.Ret);
        }
    }
}
