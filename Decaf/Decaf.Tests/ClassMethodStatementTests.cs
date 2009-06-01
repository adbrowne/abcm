using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using Castle.DynamicProxy;
using Decaf.Tree;
using NUnit.Framework;

namespace Decaf.Tests
{
    [TestFixture]
    public class ClassMethodStatementTests
    {

        private ITreeNode GetExpressionTree(string input)
        {
            var sampleInput = SurroundWithProgram(input);

            var proxyGenerator = new ProxyGenerator();
            var output = new StringBuilder();
            var generator = proxyGenerator.CreateInterfaceProxyWithoutTarget<ICodeGenerator>(new ConsoleInterceptor(output));

            var parser = CreateParser(sampleInput, generator);
            return parser.prog();
        }

        [Test]
        public void DefineIntegerWithValue()
        {
            var input = "public class Test { public TestMethod(){ int a=9; }}";
            var @class = GetExpressionTree(input);

            var statement = ((Class) @class)["TestMethod"].Statements[0];

            Assert.IsInstanceOfType(typeof(DeclarationStatement), statement);
            var declarationStatement = (DeclarationStatement) statement;

            Assert.AreEqual("a", declarationStatement.VariableName);
            Assert.AreEqual(Types.Int, declarationStatement.Type);
            var expression = declarationStatement.Expression;

            Assert.IsInstanceOfType(typeof(IntegerExpression), expression);
            var integerExpression = (IntegerExpression) expression;

            Assert.AreEqual(9, integerExpression.Value);
        }

        [Test]
        public void MultipleStatementTest()
        {
            var input = @"public class Test { public TestMethodName(){int a=9;int b=10; }}";
            var output = GetOutput(input);

            var expected =
                @"StartModule(id=Test)
BeginMethod(name=TestMethodName)
DefineVariable(name=a,type=int)
BeginExpression()
ExprNumber(i=9)
EndExpression()
AssignExpression(name=a)
DefineVariable(name=b,type=int)
BeginExpression()
ExprNumber(i=10)
EndExpression()
AssignExpression(name=b)
EndMethod()
EndModule()
";
            Assert.That(output.Contains(expected));
        }

        [Test]
        public void DefineIntegerWithExpression()
        {
            var input = "public class Test { public TestMethodName(){int a=9*2+4;} }";
            var output = GetOutput(input);

            var expected =
                @"StartModule(id=Test)
BeginMethod(name=TestMethodName)
DefineVariable(name=a,type=int)
BeginExpression()
ExprNumber(i=9)
ExprNumber(i=2)
Operation(operationName=Multiplication)
ExprNumber(i=4)
Operation(operationName=Addition)
EndExpression()
AssignExpression(name=a)
EndMethod()
EndModule()
";
            Assert.That(output.Contains(expected));
        }

        [Test]
        public void DefineClass()
        {
            var input = @"public class Test {}";
            var output = GetOutput(input);

            var expected =
                @"StartModule(id=Test)
EndModule()
";
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void DefineMethod()
        {
            var input = @"public class Test { public TestMethodName(){} }";
            var output = GetOutput(input);

            var expected =
                @"StartModule(id=Test)
BeginMethod(name=TestMethodName)
EndMethod()
EndModule()
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
            return output.ToString();
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
            return s;
        }
    }
}
