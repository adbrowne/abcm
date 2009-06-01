using NUnit.Framework;
using Decaf.Tree;

namespace Decaf.Tests.Unit.Tree
{
    [TestFixture]
    public class TreeStructureTests
    {
        private ITreeBuilder tb;

        [SetUp]
        public void SetUp()
        {
            tb = new TreeBuilder();
        }

        [Test]
        public void ClassTest()
        {
            var node = tb.Class("TestClass");

            Assert.IsInstanceOfType(typeof(Class), node);
            Assert.AreEqual("TestClass", node.Name);
        }

        [Test]
        public void MethodTest()
        {
            var node = tb.Method("TestMethod");

            Assert.IsInstanceOfType(typeof(Method), node);
            Assert.AreEqual("TestMethod", node.Name);
        }

        [Test]
        public void ClassWithMethods()
        {
            var @class = tb.Class("TestClass");

            var method = tb.Method("TestMethod");

            @class.AddMethod(method);

            Assert.IsInstanceOfType(typeof(Class), @class);
            Assert.AreEqual("TestClass", @class.Name);

            Assert.AreSame(@class["TestMethod"], method);
        }
    }
}