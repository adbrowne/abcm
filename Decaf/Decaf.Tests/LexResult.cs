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

        public void ResultsIn(string result, int token_type, int total_tokens)
        {
            var firstToken = tokens.LT(1);
            Assert.AreEqual(result, firstToken.Text, "Unexpected token text");
            Assert.AreEqual(token_type, firstToken.Type, "Unexpected token type");

            Assert.AreEqual(total_tokens, tokens.Count, "Unexpected token count");
        }

        public void HasNoTokens()
        {
            Assert.AreEqual(0, tokens.Count, "Unexpected token count");
        }
    }
}