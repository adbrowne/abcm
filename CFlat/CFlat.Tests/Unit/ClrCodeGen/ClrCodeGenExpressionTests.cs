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

            clrCodeGenerator.RegisterMethod("GetValue");
            clrCodeGenerator.RegisterMethod("Test");

            clrCodeGenerator.BeginMethod("GetValue");
            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprNumber(9);
            clrCodeGenerator.EndExpression();
            clrCodeGenerator.ReturnExpression(Types.Int);
            
            clrCodeGenerator.BeginMethod("Test");
            return clrCodeGenerator;
        }

        private object GetExpressionResult(ClrCodeGenerator clrCodeGenerator, Types types)
        {
            clrCodeGenerator.ReturnExpression(types);
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
            var output = GetExpressionResult(clrCodeGenerator, Types.Int);
            Assert.AreEqual(9, output);
        }

        [Test]
        public void SimpleVariableTest()
        {
            var clrCodeGenerator = GetGeneratorForExpression();
            
            clrCodeGenerator.DefineVariable("a", Types.Int);
            
            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprNumber(10);
            clrCodeGenerator.EndExpression();
            clrCodeGenerator.AssignExpression("a");
            
            clrCodeGenerator.ExprId("a");
            
            var output = GetExpressionResult(clrCodeGenerator, Types.Int);
            Assert.AreEqual(10, output);
        }

        [Test]
        public void MethodCallTest()
        {
            var clrCodeGenerator = GetGeneratorForExpression();

            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.MethodCall("GetValue");
            clrCodeGenerator.EndExpression();
            
            var output = GetExpressionResult(clrCodeGenerator, Types.Int);
            Assert.AreEqual(9, output);
        }

        [Test]
        public void BooleanExpressionTest()
        {
            var clrCodeGenerator = GetGeneratorForExpression();
            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprBool(true);
            clrCodeGenerator.EndExpression();
            var output = GetExpressionResult(clrCodeGenerator, Types.Bool);
            Assert.AreEqual(true, output);
        }

        [Test]
        public void MultiplicationExpressionTest()
        {
            var clrCodeGenerator = GetGeneratorForExpression();
            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprNumber(9);
            clrCodeGenerator.ExprNumber(2);
            clrCodeGenerator.Operation(Operator.Multiply);
            clrCodeGenerator.EndExpression();
            var output = GetExpressionResult(clrCodeGenerator, Types.Int);
            Assert.AreEqual(18, output);
        }

        [Test]
        public void AdditionExpressionTest()
        {
            var clrCodeGenerator = GetGeneratorForExpression();
            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprNumber(9);
            clrCodeGenerator.ExprNumber(2);
            clrCodeGenerator.Operation(Operator.Add);
            clrCodeGenerator.EndExpression();
            var output = GetExpressionResult(clrCodeGenerator, Types.Int);
            Assert.AreEqual(11, output);
        }

        [Test]
        public void SubtractionExpressionTest()
        {
            var clrCodeGenerator = GetGeneratorForExpression();
            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprNumber(9);
            clrCodeGenerator.ExprNumber(2);
            clrCodeGenerator.Operation(Operator.Subtract);
            clrCodeGenerator.EndExpression();
            var output = GetExpressionResult(clrCodeGenerator, Types.Int);
            Assert.AreEqual(7, output);
        }

        [Test]
        public void LessThanExpressionTest()
        {
            var clrCodeGenerator = GetGeneratorForExpression();
            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprNumber(9);
            clrCodeGenerator.ExprNumber(2);
            clrCodeGenerator.Operation(Operator.LessThan);
            clrCodeGenerator.EndExpression();
            var output = GetExpressionResult(clrCodeGenerator, Types.Bool);
            Assert.AreEqual(false, output);
        }

        [Test]
        public void GreaterThanExpressionTest()
        {
            var clrCodeGenerator = GetGeneratorForExpression();
            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprNumber(9);
            clrCodeGenerator.ExprNumber(2);
            clrCodeGenerator.Operation(Operator.GreaterThan);
            clrCodeGenerator.EndExpression();
            var output = GetExpressionResult(clrCodeGenerator, Types.Bool);
            Assert.AreEqual(true, output);
        }

        [Test]
        public void StringExpressionTest()
        {
            var clrCodeGenerator = GetGeneratorForExpression();
            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprString("Nothing");
            clrCodeGenerator.EndExpression();
            var output = GetExpressionResult(clrCodeGenerator, Types.String);
            Assert.AreEqual("Nothing", output);
        }

        [Test]
        public void MultipleMultiplicationExpressionTest()
        {
            var clrCodeGenerator = GetGeneratorForExpression();
            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprNumber(9);
            clrCodeGenerator.ExprNumber(2);
            clrCodeGenerator.Operation(Operator.Multiply);
            clrCodeGenerator.ExprNumber(2);
            clrCodeGenerator.Operation(Operator.Multiply);
            clrCodeGenerator.EndExpression();
            var output = GetExpressionResult(clrCodeGenerator, Types.Int);
            Assert.AreEqual(36, output);
        }
    }
}