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
    public class IfThenElseTests
    {
        [Test]
        public void DefineIntegerWithValue()
        {
            var input = "public class Test { public TestMethod(){ int a=9; }}";
            var output = GetOutput(input);

            var expected =
                @"DefineVariable(name=a,type=int)
BeginExpression()
ExprNumber(i=9)
EndExpression()
AssignExpression(name=a)
";

            Assert.That(output.Contains(expected));
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
