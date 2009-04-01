using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime;
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
            
            generator.Expect(x => x.OutputDigit(9));
            
            var parser = CreateParser(sampleInput, generator);
            parser.prog();

            generator.VerifyAllExpectations();
        }

        [Test]
        public void SimpleAdditionExpressionTest()
        {
            var repository = new MockRepository();

            var sampleInput = SurroundWithProgram("9+8");
            var generator = repository.DynamicMock<IGenerator>();

            generator.Expect(x => x.OutputDigit(9));
            generator.Expect(x => x.Operator("+"));
            generator.Expect(x => x.OutputDigit(8));
            var parser = CreateParser(sampleInput, generator);
            parser.prog();

            generator.VerifyAllExpectations();
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
