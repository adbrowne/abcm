using System;
using System.Reflection;
using CFlat.Tests.Helper;
using NUnit.Framework;

namespace CFlat.Tests.Integration
{
    [TestFixture]
    public class ClassAndMethodTests
    {
        [Test]
        public void SimpleClassTest()
        {
            var input = @"public class Test {}";
            
            var outputAssembly = GetResult(input);

            Assert.That(outputAssembly.ContainsType("Test"));
        }

        [Test]
        public void SimpleClassAndMethodTest()
        {
            var input = @"public class Test { public TestMethodName(){} }";
            
            var outputAssembly = GetResult(input);

            Assert.That(outputAssembly.ContainsTypeWithMethod("Test", "TestMethodName"));
        }

        private static Assembly GetResult(string input)
        {
            var parser = Parser.CreateParser(input);
            var @class = parser.prog();

            var assemblyName = ("Output_" + Guid.NewGuid().ToString("N") + ".exe");
            var compilerContext = new CompilerContext(new ClrCodeGenerator(assemblyName));

            @class.Compile(new ErrorSet(), compilerContext);

            compilerContext.Save();
            return Assembly.Load(compilerContext.CodeGenerator.Name);
        }
    }
}