using System;
using System.Reflection;
using CFlat.Tests.Helper;
using NUnit.Framework;

namespace CFlat.Tests.Integration
{
    [TestFixture]
    public class RelationalExpressionTests
    {
        [Test]
        public void LessThanExpressionTest()
        {
            var expression = "9 < 3";
            var @return = GetResult(expression);

            Assert.AreEqual(false, @return);
        }

        [Test]
        public void GreaterThanExpressionTest()
        {
            var expression = "9 > 3";
            var @return = GetResult(expression);

            Assert.AreEqual(true, @return);
        }

        private static bool GetResult(string expression)
        {
            var input = @"public class Test { public bool TestMethodName(){ return " + expression + ";} }";

            var parser = Parser.CreateParser(input);
            var @class = parser.prog();

            var assemblyName = ("Output_" + Guid.NewGuid().ToString("N") + ".exe");
            var compilerContext = new CompilerContext(new ClrCodeGenerator(assemblyName), new ErrorSet());

            @class.Compile(compilerContext);

            compilerContext.Save();
            var outputAssembly =  Assembly.Load(compilerContext.CodeGenerator.Name);

            Type type = outputAssembly.GetType("Test");
            MethodInfo main = type.GetMethod("TestMethodName");

            return (bool)main.Invoke(null, null);
        }
    }
}