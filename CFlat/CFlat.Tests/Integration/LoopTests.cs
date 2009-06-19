using System;
using System.Reflection;
using NUnit.Framework;

namespace CFlat.Tests.Integration
{
    [TestFixture]
    public class LoopTests : BaseIntegrationTest
    {
        [Test]
        public void SimpleWhileLoopTest()
        {

            var input = @"
public class Test { 
    public int TestMethod(){ 
        int a = 0;
        while(a < 5){
            a = a + 1;
        }
        return a; 
    }
}";

            var outputAssembly = GetResult(input);

            Type type = outputAssembly.GetType("Test");
            MethodInfo main = type.GetMethod("TestMethod");

            var @return = (int)main.Invoke(null, null);

            Assert.AreEqual(5, @return);
        }
    }
}