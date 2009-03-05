using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace RomanNumeralTranslator.Test
{
    [TestFixture]
    public class IntegerLexerTests
    {
        [Test]
        public void SingleDigitTest()
        {
            var integerLexer = new IntegerLexer();
            var tokens = integerLexer.Tokenize("2");

            Assert.That(tokens.Count(), Is.EqualTo(1));
            Assert.That(tokens.First(), Is.EqualTo(new Token(TokenType.Ones, 2)));
        }

        [Test]
        public void TwoDigitTest()
        {
            var integerLexer = new IntegerLexer();
            var tokens = new List<Token>(integerLexer.Tokenize("23"));

            ICollection resultTokens = new List<Token>(
                new[]{
                    new Token(TokenType.Tens, 2),
                    new Token(TokenType.Ones, 3)
                });

            AssertListIsSame(resultTokens, tokens);
        }

        [Test]
        public void FourDigitTest()
        {
            var integerLexer = new IntegerLexer();
            var tokens = new List<Token>(integerLexer.Tokenize("2342"));

            ICollection resultTokens = new List<Token>(
                new[]{
                    new Token(TokenType.Thousands, 2),
                    new Token(TokenType.Hundreds, 3),
                    new Token(TokenType.Tens, 4),
                    new Token(TokenType.Ones, 2)
                });

            AssertListIsSame(resultTokens, tokens);
        }

        private static void AssertListIsSame(ICollection actual, List<Token> expected)
        {
            int x = 0;
            foreach (var item in actual)
            {
                Assert.AreEqual(expected[x], item, String.Format("Difference at item {0}. Expected {1}, actual {2}", x, expected[x], item));
                x++;
            }
        }
    }
}
