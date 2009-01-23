using NUnit.Framework;

namespace PostFixTranslater.Test.Integration
{
    [TestFixture]
    public class DragonBookExampleTests
    {
        [Test]
        public void FirstExampleTest()
        {
            const string input = "9-5+2";
            const string expectedOutput = "95-2+";

            var tranlator = new PostfixTranslator();

            string output = tranlator.Tranlate(input);

            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void LongerTest()
        {
            const string input = "9-5+2+7-9";
            const string expectedOutput = "95-2+7+9-";

            var tranlator = new PostfixTranslator();

            string output = tranlator.Tranlate(input);

            Assert.AreEqual(expectedOutput, output);
        }
    }
}
