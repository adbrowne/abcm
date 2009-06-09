using System;
using System.Reflection;
using CFlat.Tests.Helper;
using NUnit.Framework;

namespace CFlat.Tests.Integration
{
    [TestFixture]
    public class ClassAndMethodTests : BaseIntegrationTest
    {
        [Test]
        public void SimpleClassTest()
        {
            var input = @"public class Test {}";
            
            var outputAssembly = GetResult(input);

            Assert.That(outputAssembly.ContainsType("Test"));
        }

        [Test]
        public void SimpleClassAndMethodTest()
        {
            var input = @"public class Test { public int TestMethodName(){} }";
            
            var outputAssembly = GetResult(input);

            Assert.That(outputAssembly.ContainsTypeWithMethod("Test", "TestMethodName"));
        }

        [Test]
        public void SimpleMethodReturnTest()
        {
            var input = @"public class Test { public int TestMethodName(){ return 9;} }";

            var outputAssembly = GetResult(input);

            Type type = outputAssembly.GetType("Test");
            MethodInfo main = type.GetMethod("TestMethodName");

            var @return = (int) main.Invoke(null, null);
        
            Assert.AreEqual(9, @return);
        }
    }
}