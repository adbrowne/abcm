using System;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
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
            var input = "9";
            var output = GetOutput(input);

            var expected =
                @"BeginExpression()
ExprNumber(i=9)
EndExpression()
";
            Assert.AreEqual(expected, output);
        
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
Operation(operationName=Addition)
ExprNumber(i=10)
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
Operation(operationName=Multiplication)
ExprNumber(i=3)
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

        [Test]
        public void StringExpressionTest()
        {
            var input = @"""test""";
            var output = GetOutput(input);

            var expected =
                @"BeginExpression()
ExprString(value=""test"")
EndExpression()
";
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void CalloutMethodWithExpressionTest()
        {
            var input = @"test(3+4)";
            var output = GetOutput(input);

            var expected =
                @"BeginExpression()
BeginMethodArguments()
BeginExpression()
ExprNumber(i=3)
ExprNumber(i=4)
Operation(operationName=Addition)
EndExpression()
MethodCall(name=""test"")
EndExpression()
";
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void CalloutMethodExpressionTest()
        {
            var input = @"test()";
            var output = GetOutput(input);

            var expected =
                @"BeginExpression()
BeginMethodArguments()
MethodCall(name=""test"")
EndExpression()
";
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void CalloutMethodWithArguments()
        {
            var input = @"test(""nothing"")";
            var output = GetOutput(input);

            var expected =
                @"BeginExpression()
BeginMethodArguments()
ExprString(value=""nothing"")
MethodCall(name=""test"")
EndExpression()
";
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void CharExpressionTest()
        {
            var input = @"'t'";
            var output = GetOutput(input);

            var expected =
                @"BeginExpression()
ExprChar(value=t)
EndExpression()
";
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void IdExpressionTest()
        {
            var input = @"Id";
            var output = GetOutput(input);

            var expected =
                @"BeginExpression()
ExprId(name=Id)
EndExpression()
";
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void BooleanFalseExpressionTest()
        {
            var input = "false";
            var output = GetOutput(input);

            var expected =
                @"BeginExpression()
ExprBool(i=False)
EndExpression()
";
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void BooleanTrueExpressionTest()
        {
            var input = "true";
            var output = GetOutput(input);

            var expected =
                @"BeginExpression()
ExprBool(i=True)
EndExpression()
";
            Assert.AreEqual(expected, output);
        }

        private string GetOutput(string input)
        {
            var sampleInput = SurroundWithProgram(input);

            var proxyGenerator = new ProxyGenerator();
            var output = new StringBuilder();
            var generator = proxyGenerator.CreateInterfaceProxyWithoutTarget<ICodeGenerator>(new ConsoleInterceptor(output));

            var parser = CreateParser(sampleInput, generator);
            parser.prog();
            return output.ToString()
                .Replace("StartModule(id=Test)\r\n", "")
                .Replace("EndModule()\r\n","")
                .Replace("BeginMethod(name=Test)\r\n","")
                .Replace("EndMethod()\r\n","");
        }

        private DecafTree CreateParser(string input, ICodeGenerator codeGenerator)
        {
            var antlrStringStream = new ANTLRStringStream(input);
            var lexter = new DecafLexer(antlrStringStream);
            var tokens = new CommonTokenStream(lexter);
            var parser = new DecafParser(tokens);

            var tree = parser.prog().Tree;

            var nodes = new CommonTreeNodeStream(tree);
            var walker = new DecafTree(nodes, codeGenerator, new ErrorSet());
            
            return walker;
        }

        private static string SurroundWithProgram(string s)
        {
            return "public class Test { public Test(){" + s + ";}}";
        }
    }
}
