using System;
using System.Reflection;
using CFlat.CodeGen.Clr;
using CFlat.Tests.Helper;
using NUnit.Framework;

namespace CFlat.Tests.Integration
{
    [TestFixture]
    public class IntegerExpressionTests
    {
        [Test]
        public void IntegerExpressionTest()
        {
            
            var expression = "9";
            var @return = GetResult(expression);

            Assert.AreEqual(9, @return);
        }

        [Test]
        public void AdditionExpressionTest()
        {

            var expression = "9 + 9";
            var @return = GetResult(expression);

            Assert.AreEqual(18, @return);
        }

        [Test]
        public void MultiplicationExpressionTest()
        {

            var expression = "9 * 3";
            var @return = GetResult(expression);

            Assert.AreEqual(27, @return);
        }

        [Test]
        public void SubtractionExpressionTest()
        {

            var expression = "9 - 3";
            var @return = GetResult(expression);

            Assert.AreEqual(6, @return);
        }

        [Test]
        public void DivisionExpressionTest()
        {

            var expression = "9 / 3";
            var @return = GetResult(expression);

            Assert.AreEqual(3, @return);
        }

        [Test]
        public void RemainderExpressionTest()
        {

            var expression = "10 % 3";
            var @return = GetResult(expression);

            Assert.AreEqual(1, @return);
        }
        private static int GetResult(string expression)
        {
            var input = @"public class Test { public int TestMethodName(){ return " + expression + ";} }";

            var parser = Parser.CreateParser(input);
            var @class = parser.prog();

            var assemblyName = ("Output_" + Guid.NewGuid().ToString("N") + ".exe");
            var compilerContext = new CompilerContext(new ClrCodeGenerator(assemblyName), new ErrorSet());

            @class.Compile(compilerContext);

            var outputAssembly = compilerContext.Save(false);

            Type type = outputAssembly.GetType("Test");
            MethodInfo main = type.GetMethod("TestMethodName");

            return (int)main.Invoke(null, null);
        }
    }
}