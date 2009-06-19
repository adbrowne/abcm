using System;
using System.Reflection;
using NUnit.Framework;

namespace CFlat.Tests.Integration
{
    [TestFixture]
    public class IfThenElseTests : BaseIntegrationTest
    {
        [Test]
        public void SimpleTrueIfStatement()
        {
            var input = @"public class Test { public int TestMethod(){ if(true){return 3;} return 4; }}";

            var outputAssembly = GetResult(input);

            Type type = outputAssembly.GetType("Test");
            MethodInfo main = type.GetMethod("TestMethod");

            var @return = (int) main.Invoke(null, null);

            Assert.AreEqual(3, @return);
        }

        [Test]
        public void SimpleFalseIfStatement()
        {
            var input = @"public class Test { public int TestMethod(){ if(false){return 3;} return 4; }}";

            var outputAssembly = GetResult(input);

            Type type = outputAssembly.GetType("Test");
            MethodInfo main = type.GetMethod("TestMethod");

            var @return = (int)main.Invoke(null, null);

            Assert.AreEqual(4, @return);
        }

        [Test]
        public void BinaryOperationIfStatementTest()
        {
            var input = @"public class Test { public int TestMethod(){ if(3 < 4){return 3;} return 4; }}";

            var outputAssembly = GetResult(input);

            Type type = outputAssembly.GetType("Test");
            MethodInfo main = type.GetMethod("TestMethod");

            var @return = (int)main.Invoke(null, null);

            Assert.AreEqual(3, @return);
        }
    }
}
