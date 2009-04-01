using Antlr.Runtime;
using NUnit.Framework;

namespace Decaf.Tests
{
    internal class LexResult
    {
        private readonly CommonTokenStream tokens;

        public LexResult(CommonTokenStream tokens)
        {
            this.tokens = tokens;
        }

        public LexResult ResultsIn(string result, int token_type)
        {
            return ResultsIn(result, token_type, null);
        }

        public LexResult ResultsIn(string result, int token_type, int? total_tokens)
        {
            var firstToken = tokens.LT(1);
            tokens.Consume();
            Assert.AreEqual(result, firstToken.Text, "Unexpected token text");
            Assert.AreEqual(token_type, firstToken.Type, "Unexpected token type");

            if (total_tokens != null)
                Assert.AreEqual(total_tokens, tokens.Count, "Unexpected token count");

            return this;
        }

        public void HasNoTokens()
        {
            Assert.AreEqual(0, tokens.Count, "Unexpected token count");
        }

        public LexResult Then(string result, int token_type)
        {
            var nextToken = tokens.LT(1);
            tokens.Consume();
            Assert.AreEqual(result, nextToken.Text, "Unexpected token text");
            Assert.AreEqual(token_type, nextToken.Type, "Unexpected token type");

            return this;
        }
    }
}