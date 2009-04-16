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
            return mainModuleBuilder.DefineType(id);
        }

        public void Save()
        {
            mainModuleBuilder.CreateGlobalFunctions();
            assemblyBuilder.Save(outputFileName);
        }

        public void BeginExpression()
        {
            throw new System.NotImplementedException();
        }

        public void ExprNumber(int i)
        {
            throw new System.NotImplementedException();
        }

        public void Operation(string operationName)
        {
            throw new System.NotImplementedException();
        }

        public void Comment(string comment)
        {
            throw new System.NotImplementedException();
        }

        public void EndExpression()
        {
            throw new System.NotImplementedException();
        }
    }
}
