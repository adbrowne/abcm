using CFlat.Tree;
using CFlat;
using NUnit.Framework;

namespace CFlat.Tests.Unit.Tree
{
    [TestFixture]
    public class ExpressionTypeTests
    {
        private ITreeBuilder tb;

        [SetUp]
        public void SetUp()
        {
            tb = new TreeBuilder();
        }

        [Test]
        public void IntegerTypeTest()
        {
            var expr = tb.IntegerExpression("9");
            Assert.AreEqual(Types.Int, expr.Type);
        }

        [Test]
        public void DeclarationTypeIntTest()
        {
            var stmt = (DeclarationStatement)tb.DeclarationStatement("int", null, null);
            Assert.AreEqual(Types.Int, stmt.Type);
        }

        [Test]
        public void DeclarationTypeStringTest()
        {
            var stmt = (DeclarationStatement) tb.DeclarationStatement("string", null, null);
            Assert.AreEqual(Types.String, stmt.Type);
        }

        [Test]
        public void DeclarationTypeCharTest()
        {
            var stmt = (DeclarationStatement) tb.DeclarationStatement("char", null, null);
            Assert.AreEqual(Types.Char, stmt.Type);
        }

        [Test]
        public void DeclarationTypeBoolTest()
        {
            var stmt = (DeclarationStatement) tb.DeclarationStatement("bool", null, null);
            Assert.AreEqual(Types.Bool, stmt.Type);
        }
    }
}