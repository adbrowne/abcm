using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;
using System.Collections;

namespace PostFixTranslater.Test.Unit
{
    [TestFixture]
    public class LexerTests
    {
        [Test]
        public void SingleDigitTest()
        {
            var simpleLexer = new SimpleLexer();
            var tokens = simpleLexer.Tokenize("0");

            Assert.That(tokens.Count(), Is.EqualTo(1));
            Assert.That(tokens.First(), Is.EqualTo(new Token(TokenType.Digit, 0)));
        }

        [Test]
        public void AllDigitsTest()
        {
            var simpleLexer = new SimpleLexer();
            var tokens = new List<Token>(simpleLexer.Tokenize("0123456789"));
            Assert.That(tokens.Count(), Is.EqualTo(10));
            
            ICollection resultTokens = new List<Token>(
                new []{
                    new Token(TokenType.Digit, 0), 
                    new Token(TokenType.Digit, 1), 
                    new Token(TokenType.Digit, 2), 
                    new Token(TokenType.Digit, 3), 
                    new Token(TokenType.Digit, 4), 
                    new Token(TokenType.Digit, 5), 
                    new Token(TokenType.Digit, 6), 
                    new Token(TokenType.Digit, 7), 
                    new Token(TokenType.Digit, 8), 
                    new Token(TokenType.Digit, 9), 
                });

            AssertListIsSame(resultTokens, tokens);
        }

        [Test]
        public void SymbolsTest()
        {
            var simpleLexer = new SimpleLexer();
            var tokens = new List<Token>(simpleLexer.Tokenize("+-"));
            Assert.That(tokens.Count(), Is.EqualTo(2));

            ICollection resultTokens = new List<Token>(
                new[]{
                    new Token(TokenType.Plus),
                    new Token(TokenType.Minus)
                });

            AssertListIsSame(resultTokens, tokens);
        }

        [Test]
        public void SimpleEquationTest()
        {
            var simpleLexer = new SimpleLexer();
            var tokens = new List<Token>(simpleLexer.Tokenize("9-5+2"));
            Assert.That(tokens.Count(), Is.EqualTo(5));

            ICollection resultTokens = new List<Token>(
                new[]{
                    new Token(TokenType.Digit, 9),
                    new Token(TokenType.Minus),
                    new Token(TokenType.Digit, 5),
                    new Token(TokenType.Plus),
                    new Token(TokenType.Digit, 2),
                });

            AssertListIsSame(resultTokens, tokens);
            
        }

        private static void AssertListIsSame(ICollection actual, List<Token> expected)
        {
            int x = 0;
            foreach(var item in actual)
            {
                Assert.AreEqual(expected[x], item, String.Format("Difference at item {0}. Expected {1}, actual {2}",x, expected[x], item));
                x++;
            }
        }
    }
}
