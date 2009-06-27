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

        [Test]
        public void NestedWhileLoopTest()
        {

            var input = @"
public class Test { 
    public int TestMethod(){ 
        int a = 0;
        int c = 0;
        int b = 0;
        while(a < 5){
            a = a + 1;
            b = 0;
            while(b < 5){
                b = b + 1;
                c = c + 1;
            }
        }
        return c; 
    }
}";

            var outputAssembly = GetResult(input);

            Type type = outputAssembly.GetType("Test");
            MethodInfo main = type.GetMethod("TestMethod");

            var @return = (int)main.Invoke(null, null);

            Assert.AreEqual(25, @return);
        }
    }
}