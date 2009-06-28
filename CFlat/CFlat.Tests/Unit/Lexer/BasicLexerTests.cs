using Antlr.Runtime;
using CFlat.Tests.Helper;
using NUnit.Framework;

namespace CFlat.Tests.Unit.Lexer
{
    [TestFixture]
    public class BasicLexerTests
    {
        [Test]
        public void StringLiteralTest()
        {
            const string sampleInput = @"""Andrew Browne: 42""";
            AssertThat(sampleInput).ResultsIn(sampleInput, CFlatLexer.STRING_LITERAL, 1);
        }

        [Test]
        public void CharLiteralLetterTest()
        {
            const string sampleInput = @"'a'";
            AssertThat(sampleInput).ResultsIn("'a'", CFlatLexer.CHAR_LITERAL, 1);
        }

        [Test]
        public void CharLiteralUppercaseTest()
        {
            const string sampleInput = @"'B'";
            AssertThat(sampleInput).ResultsIn("'B'", CFlatLexer.CHAR_LITERAL, 1);
        }

        [Test]
        public void CharLiteralNumberTest()
        {
            const string sampleInput = @"'3'";
            AssertThat(sampleInput).ResultsIn("'3'", CFlatLexer.CHAR_LITERAL, 1);
        }

        [Test]
        public void CharLiteralMultipleCharacterFailureTest()
        {
            const string sampleInput = @"'aa'";
            AssertThat(sampleInput).HasNoTokens();
        }

        [Test]
        public void DigitTest()
        {
            const string sampleInput = @"9";
            AssertThat(sampleInput).ResultsIn("9", CFlatLexer.INT, 1);
        }

        [Test]
        public void AdditionOperatorTest()
        {
            const string sampleInput = @"+";
            AssertThat(sampleInput).ResultsIn("+", CFlatLexer.ARITH_OP, 1);
        }

        [Test]
        public void AdditionTest()
        {
            const string sampleInput = @"9+8";
            AssertThat(sampleInput).ResultsIn("9", CFlatLexer.INT).Then("+", CFlatLexer.ARITH_OP).Then("8",CFlatLexer.INT);
        }

        [Test]
        public void IdentifierTest()
        {
            const string sampleInput = @"varName";
            AssertThat(sampleInput).ResultsIn("varName", CFlatLexer.ID, 1);
        }

        [Test]
        public void DefineVariableTest()
        {
            const string sampleInput = @"int a=9;";
            AssertThat(sampleInput).ResultsIn("int", CFlatLexer.ID).Then("a", CFlatLexer.ID).Then("=", CFlatLexer.EQUALS).Then("9", CFlatLexer.INT).Then(";", CFlatLexer.EOS);
        }

        private static LexResult AssertThat(string input)
        {
            var antlrStringStream = new ANTLRStringStream(input);
            var lexter = new CFlatLexer(antlrStringStream);
            var tokens = new CommonTokenStream(lexter);

            return new LexResult(tokens);
        }
    }
}