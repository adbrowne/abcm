using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

namespace Oberon_0
{
    class ILGen
    {
        private readonly string outputFileName;
        private ModuleBuilder mainModuleBuilder;
        AssemblyBuilder assemblyBuilder;
            
        public ILGen(string outputFileName)
        {
            this.outputFileName = outputFileName;
            string name = Path.GetFileNameWithoutExtension(outputFileName);
            var assemblyName = new AssemblyName(name);
            assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName,
                                                                        AssemblyBuilderAccess.Save);

            mainModuleBuilder = assemblyBuilder.DefineDynamicModule(outputFileName);
        }

        public void Save()
        {
            mainModuleBuilder.CreateGlobalFunctions();
            assemblyBuilder.Save(outputFileName);
        }

        public TypeBuilder StartModule(string id)
        {
            return mainModuleBuilder.DefineType(id);
        }
    }

    }
