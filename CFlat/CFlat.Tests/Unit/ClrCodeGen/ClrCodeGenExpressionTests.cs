using System;
using System.Reflection;
using CFlat;
using NUnit.Framework;

namespace CFlat.Tests.Unit.ClrCodeGen
{
    [TestFixture]
    public class ClrCodeGenExpressionTests
    {
        ClrCodeGenerator GetGeneratorForExpression()
        {
            string name = "Output_" + Guid.NewGuid().ToString("N") + ".exe";
            var clrCodeGenerator = new ClrCodeGenerator(name);
            clrCodeGenerator.StartModule("Foo");
            clrCodeGenerator.BeginMethod("Test");
            return clrCodeGenerator;
        }

        private object GetExpressionResult(ClrCodeGenerator clrCodeGenerator)
        {
            clrCodeGenerator.ReturnExpression();
            clrCodeGenerator.EndModule();
            clrCodeGenerator.Save();
            Assembly a = Assembly.Load(clrCodeGenerator.Name);

            Type foo = a.GetType("Foo");
            MethodInfo main = foo.GetMethod("Test");

            return main.Invoke(null, null);
        }

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

        [Test]
        public void AdditionExpressionTest()
        {
            var clrCodeGenerator = GetGeneratorForExpression();
            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprNumber(9);
            clrCodeGenerator.ExprNumber(2);
            clrCodeGenerator.Operation("Addition");
            clrCodeGenerator.EndExpression();
            var output = GetExpressionResult(clrCodeGenerator);
            Assert.AreEqual(11, output);
        }

        [Test]
        public void SubtractionExpressionTest()
        {
            var clrCodeGenerator = GetGeneratorForExpression();
            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprNumber(9);
            clrCodeGenerator.ExprNumber(2);
            clrCodeGenerator.Operation("Subtraction");
            clrCodeGenerator.EndExpression();
            var output = GetExpressionResult(clrCodeGenerator);
            Assert.AreEqual(7, output);
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