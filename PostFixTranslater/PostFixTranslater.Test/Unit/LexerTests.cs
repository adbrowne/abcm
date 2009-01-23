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
            Assert.That(tokens.First(), Is.EqualTo(Token.Zero));
        }

        [Test]
        public void AllDigitsTest()
        {
            var simpleLexer = new SimpleLexer();
            var tokens = new List<Token>(simpleLexer.Tokenize("0123456789"));
            Assert.That(tokens.Count(), Is.EqualTo(10));
            
            ICollection resultTokens = new List<Token>(
                new []{
                    Token.Zero, 
                    Token.One, 
                    Token.Two, 
                    Token.Three, 
                    Token.Four, 
                    Token.Five, 
                    Token.Six, 
                    Token.Seven, 
                    Token.Eight, 
                    Token.Nine
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
                    Token.Plus, 
                    Token.Minus
                });

            AssertListIsSame(resultTokens, tokens);
        }

        [Test]
        public void SimpleEquationTest()
        {
            var simpleLexer = new SimpleLexer();
            var tokens = new List<Token>(simpleLexer.Tokenize("9-6+2"));
            Assert.That(tokens.Count(), Is.EqualTo(5));

            ICollection resultTokens = new List<Token>(
                new[]{
                    Token.Nine, 
                    Token.Minus,
                    Token.Six,
                    Token.Plus,
                    Token.Two
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
