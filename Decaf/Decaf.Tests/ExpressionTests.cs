﻿using System;
using System.Text;
using Antlr.Runtime;
using Castle.DynamicProxy;
using NUnit.Framework;
using Rhino.Mocks;

namespace Decaf.Tests
{
    [TestFixture]
    public class ExpressionTests
    {
        [Test]
        public void SingleDigitExpressionTest()
        {
            var repository = new MockRepository();
            
            var sampleInput = SurroundWithProgram("9");
            var generator = repository.DynamicMock<IGenerator>();

            generator.Expect(x => x.BeginExpression());
            generator.Expect(x => x.ExprNumber(9));
            
            var parser = CreateParser(sampleInput, generator);
            parser.prog();

            generator.VerifyAllExpectations();
        }

        [Test]
        public void SimpleAdditionExpressionTest()
        {
            var input = "9+8";
            var output = GetOutput(input);

            var expected =
                @"BeginExpression()
ExprNumber(i=9)
ExprNumber(i=8)
Operation(operationName=Addition)
EndExpression()
";
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void SimpleSubtractionExpressionTest()
        {
            var input = "9-8";
            var output = GetOutput(input);

            var expected =
                @"BeginExpression()
ExprNumber(i=9)
ExprNumber(i=8)
Operation(operationName=Subtraction)
EndExpression()
";
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TwoAdditionsExpressionTest()
        {
            var input = "9+8+10";
            var output = GetOutput(input);  

            var expected =
                @"BeginExpression()
ExprNumber(i=9)
ExprNumber(i=8)
ExprNumber(i=10)
Operation(operationName=Addition)
Operation(operationName=Addition)
EndExpression()
";
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void SimpleMultiplicationExpressionTest()
        {
            var input = "9*8";
            var output = GetOutput(input);

            var expected =
                @"BeginExpression()
ExprNumber(i=9)
ExprNumber(i=8)
Operation(operationName=Multiplication)
EndExpression()
";
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void SimpleDivisionExpressionTest()
        {
            var input = "9/8";
            var output = GetOutput(input);

            var expected =
                @"BeginExpression()
ExprNumber(i=9)
ExprNumber(i=8)
Operation(operationName=Division)
EndExpression()
";
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void SimplerRemainderExpressionTest()
        {
            var input = "9 % 8";
            var output = GetOutput(input);

            var expected =
                @"BeginExpression()
ExprNumber(i=9)
ExprNumber(i=8)
Operation(operationName=Remainder)
EndExpression()
";
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void MultiplicationPrecedenceExpressionTest()
        {
            var input = "9*8+3";
            var output = GetOutput(input);

            var expected =
                @"BeginExpression()
ExprNumber(i=9)
ExprNumber(i=8)
Operation(operationName=Multiplication)
ExprNumber(i=3)
Operation(operationName=Addition)
EndExpression()
";
            Assert.AreEqual(expected, output);
        }


        [Test]
        public void MultipleMultiplicationsExpressionTest()
        {
            var input = "9*8*3";
            var output = GetOutput(input);

            var expected =
                @"BeginExpression()
ExprNumber(i=9)
ExprNumber(i=8)
ExprNumber(i=3)
Operation(operationName=Multiplication)
Operation(operationName=Multiplication)
EndExpression()
";
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void UnaryMinusExpressionTest()
        {
            var input = "-9";
            var output = GetOutput(input);

            var expected =
                @"BeginExpression()
ExprNumber(i=-9)
EndExpression()
";
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void UnaryMinusInExpressionTest()
        {
            var input = "3+-2";
            var output = GetOutput(input);

            var expected =
                @"BeginExpression()
ExprNumber(i=3)
ExprNumber(i=-2)
Operation(operationName=Addition)
EndExpression()
";
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void BracketsExpressionTest()
        {
            var input = "(9+8)*3";
            var output = GetOutput(input);

            var expected =
                @"BeginExpression()
ExprNumber(i=9)
ExprNumber(i=8)
Operation(operationName=Addition)
ExprNumber(i=3)
Operation(operationName=Multiplication)
EndExpression()
";
            Assert.AreEqual(expected, output);
        }

        private string GetOutput(string input)
        {
            var sampleInput = SurroundWithProgram(input);

            var proxyGenerator = new ProxyGenerator();
            var output = new StringBuilder();
            var generator = proxyGenerator.CreateInterfaceProxyWithoutTarget<IGenerator>(new ConsoleInterceptor(output));

            var parser = CreateParser(sampleInput, generator);
            parser.prog();
            return output.ToString();
        }

        private DecafParser CreateParser(string input, IGenerator generator)
        {
            var antlrStringStream = new ANTLRStringStream(input);
            var lexter = new DecafLexer(antlrStringStream);
            var tokens = new CommonTokenStream(lexter);
            var parser = new DecafParser(tokens, generator);
            return parser;
        }

        private static string SurroundWithProgram(string s)
        {
            return s;
        }
    }
}