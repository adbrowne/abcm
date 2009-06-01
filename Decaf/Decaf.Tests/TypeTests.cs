using System;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using Castle.DynamicProxy;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;
using Rhino.Mocks;

namespace Decaf.Tests
{
    [TestFixture]
    public class TypeTests
    {
        [Test]
        public void ExpectingBooleanExpression()
        {
            var input = "public class Test { public TestMethod(){ bool a = 9; }}";
            var output = GetErrors(input);

            Assert.AreEqual(CompileErrorType.TypeMismatch, output[0].Type);
        }

        private ErrorSet GetErrors(string input)
        {
            var generator = GetGenerator();

            var errorSet = new ErrorSet();
            var parser = CreateParser(input, generator, errorSet);
            var @class = parser.prog();
            @class.Compile(errorSet);
            return errorSet;
        }

        ClrCodeGenerator GetGenerator()
        {
            string name = "Output_" + Guid.NewGuid().ToString("N") + ".exe";
            var clrCodeGenerator = new ClrCodeGenerator(name);
            return clrCodeGenerator;
        }

        private DecafTree CreateParser(string input, ICodeGenerator codeGenerator, ErrorSet errorSet)
        {
            var antlrStringStream = new ANTLRStringStream(input);
            var lexter = new DecafLexer(antlrStringStream);
            var tokens = new CommonTokenStream(lexter);
            var parser = new DecafParser(tokens);

            var tree = parser.prog().Tree;

            var nodes = new CommonTreeNodeStream(tree);
            var walker = new DecafTree(nodes, codeGenerator, errorSet);
            
            return walker;
        }

        private static string SurroundWithProgram(string s)
        {
            return s;
        }
    }
}
