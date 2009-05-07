using System;
using System.Reflection;
using System.Reflection.Emit;
using NUnit.Framework;

namespace Decaf.Tests
{
    [TestFixture]
    public class ClrCodeGeneratorTests
    {
        ClrCodeGenerator GetGeneratorForExpression()
        {
            string name = "Output_" + Guid.NewGuid().ToString("N") + ".exe";
            var clrCodeGenerator = new ClrCodeGenerator(name);
            currentType = clrCodeGenerator.StartModule("Foo");
            return clrCodeGenerator;
        }

        private object GetExpressionResult(ClrCodeGenerator clrCodeGenerator)
        {
            currentType.CreateType();
            clrCodeGenerator.Save();
            Assembly a = Assembly.Load(clrCodeGenerator.Name);

            Type foo = a.GetType("Foo");
            MethodInfo main = foo.GetMethod("Test");

            return main.Invoke(null, null);
        }

        [Test]
        public void EmptyAssemblyTest()
        {
            var clrCodeGenerator = new ClrCodeGenerator("Output.exe");
            var type = clrCodeGenerator.StartModule("Foo");
            type.CreateType();
            clrCodeGenerator.Save();
        }

        private TypeBuilder currentType;

        [Test]
        public void SimpleExpressionTest()
        {
            var clrCodeGenerator = GetGeneratorForExpression();
            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprNumber(9);
            clrCodeGenerator.EndExpression();
            var output = GetExpressionResult(clrCodeGenerator);
            Assert.AreEqual(9, output);
        }

        [Test]
        public void MultiplicationExpressionTest()
        {
            var clrCodeGenerator = GetGeneratorForExpression();
            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprNumber(9);
            clrCodeGenerator.ExprNumber(2);
            clrCodeGenerator.Operation("Multiplication");
            clrCodeGenerator.EndExpression();
            var output = GetExpressionResult(clrCodeGenerator);
            Assert.AreEqual(18, output);
        }

        public static object Test()
        {
            return "Nothing";
        }
        [Test]
        public void StringExpressionTest()
        {
            var clrCodeGenerator = GetGeneratorForExpression();
            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprString("Nothing");
            clrCodeGenerator.EndExpression();
            var output = GetExpressionResult(clrCodeGenerator);
            Assert.AreEqual("Nothing", output);
        }

        [Test]
        public void MultipleMultiplicationExpressionTest()
        {
            var clrCodeGenerator = GetGeneratorForExpression();
            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprNumber(9);
            clrCodeGenerator.ExprNumber(2);
            clrCodeGenerator.Operation("Multiplication");
            clrCodeGenerator.ExprNumber(2);
            clrCodeGenerator.Operation("Multiplication");
            clrCodeGenerator.EndExpression();
            var output = GetExpressionResult(clrCodeGenerator);
            Assert.AreEqual(36, output);
        }
    }
}
