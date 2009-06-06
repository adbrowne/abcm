using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using NUnit.Framework;

namespace CFlat.Tests
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

        private CFlatTree CreateParser(string input, ICodeGenerator codeGenerator, ErrorSet errorSet)
        {
            var antlrStringStream = new ANTLRStringStream(input);
            var lexter = new CFlatLexer(antlrStringStream);
            var tokens = new CommonTokenStream(lexter);
            var parser = new CFlatParser(tokens);

            var tree = parser.prog().Tree;

            var nodes = new CommonTreeNodeStream(tree);
            var walker = new CFlatTree(nodes, codeGenerator, errorSet);
            
            return walker;
        }
    }
}
