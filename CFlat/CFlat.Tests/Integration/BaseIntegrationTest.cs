using System;
using System.Reflection;
using CFlat.CodeGen.Clr;
using CFlat.Tests.Helper;
using NUnit.Framework;

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

            return compilerContext.Save(false);
        }
    }
}