using NUnit.Framework;

namespace PostFixTranslater.Test.Unit
{
    [TestFixture]
    public class PredictiveRecursiveDescentParserTests
    {
        [Test]
        public void SimpleEquationTest()
        {
            var parser = new PredictiveRecursiveDescentParser();
            
            string result = parser.Parse(new[]{
                    Token.Nine, 
                    Token.Minus,
                    Token.Five,
                    Token.Plus,
                    Token.Two
                });

            Assert.AreEqual("95-2+", result);
        }
    }
}
