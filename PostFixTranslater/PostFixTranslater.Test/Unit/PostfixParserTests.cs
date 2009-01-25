using NUnit.Framework;

namespace PostFixTranslater.Test.Unit
{
    [TestFixture]
    public class PostfixParserTests
    {
        [Test]
        public void SimpleEquationTest()
        {
            var parser = new PostfixParser();
            
            string result = parser.Parse(new[]{
                    new Token(TokenType.Digit, 9),
                    new Token(TokenType.Minus),
                    new Token(TokenType.Digit, 5),
                    new Token(TokenType.Plus),
                    new Token(TokenType.Digit, 2),
                });

            Assert.AreEqual("95-2+", result);
        }
    }
}
