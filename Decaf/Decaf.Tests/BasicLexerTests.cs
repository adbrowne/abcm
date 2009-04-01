using Antlr.Runtime;
using NUnit.Framework;

namespace Decaf.Tests
{
    [TestFixture]
    public class BasicLexerTests
    {
        [Test]
        public void StringLiteralTest()
        {
            const string sampleInput = @"""Andrew Browne: 42""";
            AssertThat(sampleInput).ResultsIn(sampleInput, DecafLexer.STRING_LITERAL, 1);
        }

        [Test]
        public void CharLiteralLetterTest()
        {
            const string sampleInput = @"'a'";
            AssertThat(sampleInput).ResultsIn("'a'", DecafLexer.CHAR_LITERAL, 1);
        }

        [Test]
        public void CharLiteralUppercaseTest()
        {
            const string sampleInput = @"'B'";
            AssertThat(sampleInput).ResultsIn("'B'", DecafLexer.CHAR_LITERAL, 1);
        }

        [Test]
        public void CharLiteralNumberTest()
        {
            const string sampleInput = @"'3'";
            AssertThat(sampleInput).ResultsIn("'3'", DecafLexer.CHAR_LITERAL, 1);
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
            AssertThat(sampleInput).ResultsIn("9", DecafLexer.DIGIT, 1);
        }

        [Test]
        public void MultipleDigitTest()
        {
            const string sampleInput = @"98";
            AssertThat(sampleInput).ResultsIn("9", DecafLexer.DIGIT, 2);
        }

        private static LexResult AssertThat(string input)
        {
            var antlrStringStream = new ANTLRStringStream(input);
            var lexter = new DecafLexer(antlrStringStream);
            var tokens = new CommonTokenStream(lexter);

            return new LexResult(tokens);
        }
    }
}
