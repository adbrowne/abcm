using System;
using System.Reflection;
using CFlat.Tests.Helper;

namespace CFlat.Tests.Integration
{
    public class BaseIntegrationTest
    {
        protected static Assembly GetResult(string input)
        {
            var parser = Parser.CreateParser(input);
            var @class = parser.prog();

            var assemblyName = ("Output_" + Guid.NewGuid().ToString("N") + ".exe");
            var compilerContext = new CompilerContext(new ClrCodeGenerator(assemblyName), new ErrorSet());

            @class.Compile(compilerContext);

            compilerContext.Save();
            return Assembly.Load(compilerContext.CodeGenerator.Name);
        }
    }
}