using System.Linq;
using NUnit.Framework;

namespace RomanNumeralTranslator.Test.Unit
{
    [TestFixture]
    public class RomanNumeralParserTests
    {
        [Test]
        public void OneTranslateTest()
        {
            TestTranslation(new[] { new Token(TokenType.Ones, 1) }, "I");
            TestTranslation(new[] { new Token(TokenType.Ones, 2) }, "II");
            TestTranslation(new[] { new Token(TokenType.Ones, 3) }, "III");
            TestTranslation(new[] { new Token(TokenType.Ones, 4) }, "IV");
            TestTranslation(new[] { new Token(TokenType.Ones, 5) }, "V");
            TestTranslation(new[] { new Token(TokenType.Ones, 6) }, "VI");
            TestTranslation(new[] { new Token(TokenType.Ones, 7) }, "VII");
            TestTranslation(new[] { new Token(TokenType.Ones, 8) }, "VIII");
            TestTranslation(new[] { new Token(TokenType.Ones, 9) }, "IX");
        }

        private static void TestTranslation(Token[] tokens, string expected)
        {
            var parser = new RomanNumeralParser();

            string result = parser.Parse(tokens);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TensAndOnesTranslateTest()
        {
            TestTranslation(new[]{new Token(TokenType.Tens, 1),new Token(TokenType.Ones, 1)}, "XI");
        }

        [Test]
        public void TensTranslateTest()
        {
            TestTranslation(new[] { new Token(TokenType.Tens, 1)}, "X");
            TestTranslation(new[] { new Token(TokenType.Tens, 2) }, "XX");
            TestTranslation(new[] { new Token(TokenType.Tens, 3) }, "XXX");
            TestTranslation(new[] { new Token(TokenType.Tens, 4) }, "XL");
            TestTranslation(new[] { new Token(TokenType.Tens, 5) }, "L");
            TestTranslation(new[] { new Token(TokenType.Tens, 6) }, "LX");
            TestTranslation(new[] { new Token(TokenType.Tens, 7) }, "LXX");
            TestTranslation(new[] { new Token(TokenType.Tens, 8) }, "LXXX");
            TestTranslation(new[] { new Token(TokenType.Tens, 9) }, "XC");
        }

        [Test]
        public void HundredsTranslateTest()
        {
            TestTranslation(new[] { new Token(TokenType.Hundreds, 1) }, "C");
            TestTranslation(new[] { new Token(TokenType.Hundreds, 2) }, "CC");
            TestTranslation(new[] { new Token(TokenType.Hundreds, 3) }, "CCC");
            TestTranslation(new[] { new Token(TokenType.Hundreds, 4) }, "CD");
            TestTranslation(new[] { new Token(TokenType.Hundreds, 5) }, "D");
            TestTranslation(new[] { new Token(TokenType.Hundreds, 6) }, "DC");
            TestTranslation(new[] { new Token(TokenType.Hundreds, 7) }, "DCC");
            TestTranslation(new[] { new Token(TokenType.Hundreds, 8) }, "DCCC");
            TestTranslation(new[] { new Token(TokenType.Hundreds, 9) }, "CM");
        }

        [Test]
        public void TestWithZerosTest()
        {
            TestTranslation(new[] { new Token(TokenType.Thousands, 0), new Token(TokenType.Hundreds, 0), new Token(TokenType.Tens, 0), new Token(TokenType.Ones, 0) }, "");
        }

        [Test]
        public void HundredsAndTensAndOnesTranslateTest()
        {
            TestTranslation(new[]{
                new Token(TokenType.Hundreds, 1),
                new Token(TokenType.Tens, 1),
                new Token(TokenType.Ones, 1)
                }, "CXI");
        }

        [Test]
        public void AllDigitsTestTranslateTest()
        {
            TestTranslation(new[]{
                new Token(TokenType.Thousands, 1),
                new Token(TokenType.Hundreds, 1),
                new Token(TokenType.Tens, 1),
                new Token(TokenType.Ones, 1)
                }, "MCXI");
        }

        [Test]
        public void Translate1970Test()
        {
            TestTranslation(new[]{
                new Token(TokenType.Thousands, 1),
                new Token(TokenType.Hundreds, 9),
                new Token(TokenType.Tens, 7),
                new Token(TokenType.Ones, 0)
                }, "MCMLXX");
        }

        [Test]
        public void ThousandsTranslateTest()
        {
            TestTranslation(new[] { new Token(TokenType.Thousands, 1) }, "M");
            TestTranslation(new[] { new Token(TokenType.Thousands, 2) }, "MM");
            TestTranslation(new[] { new Token(TokenType.Thousands, 3) }, "MMM");
        }
    }
}
