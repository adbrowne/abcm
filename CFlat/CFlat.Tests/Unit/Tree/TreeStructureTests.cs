using System;
using NUnit.Framework;
using CFlat.Tree;

namespace CFlat.Tests.Unit.Tree
{
    [TestFixture]
    public class TreeStructureTests
    {
        private TreeBuilder tb;

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
            var node = tb.Method("TestMethod", "int");

            Assert.IsInstanceOfType(typeof(Method), node);
            Assert.AreEqual("TestMethod", node.Name);
        }

        [Test]
        public void ClassWithMethods()
        {
            var @class = tb.Class("TestClass");

            var method = tb.Method("TestMethod", "int");

            @class.AddMethod(method);

            Assert.IsInstanceOfType(typeof(Class), @class);
            Assert.AreEqual("TestClass", @class.Name);

            Assert.AreSame(@class["TestMethod"], method);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ExceptionOnInvalidRelationalOperator()
        {
            tb.RelationalExpression("dd", new IntegerExpression("9"), new IntegerExpression("10"));
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ExceptionOnInvalidTypeName()
        {
            tb.GetTypeFromName("Test");
        }
    }
}