using NUnit.Framework;
using Decaf.Tree;

namespace Decaf.Tests.Unit.Tree
{
    [TestFixture]
    public class TreeExpressionTests
    {
        private ITreeBuilder tb;

        [SetUp]
        public void SetUp()
        {
            tb = new TreeBuilder();
        }

        [Test]
        public void IntegerExpression()
        {
            var expr = tb.IntegerExpression("9");

            Assert.IsInstanceOfType(typeof(IntegerExpression), expr);
            Assert.AreEqual(9, expr.Value);
        }

        [Test]
        public void AdditionExpression()
        {
            var expr9 = tb.IntegerExpression("9");
            var expr10 = tb.IntegerExpression("10");

            var expr = tb.AdditionExpression(expr9, expr10);

            Assert.IsInstanceOfType(typeof(AdditionExpression), expr);
            Assert.AreEqual(expr.Expr1, expr9);
            Assert.AreEqual(expr.Expr2, expr10);
        }
    }
}