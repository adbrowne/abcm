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
        [ExpectedException("CFlat.ParserException")]
        public void EnsureFailureOnInvaidParse()
        {
            GetResult("blah");
        }

        [Test]
        [ExpectedException("CFlat.ParserException")]
        public void EnsureFailureOnInvaidTree()
        {
            GetResult("public class Test{");
        }

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

            var @return = (int)main.Invoke(null, null);

            Assert.AreEqual(9, @return);
        }

        [Test]
        public void MethodCallWithArgumentsTest()
        {
            var input = @"
public class Test { 
    public int Times2(int x) 
    { 
        return x * 2; 
    }

    public int Main()
    { 
        return Times2(9);
    } 
}";

            var outputAssembly = GetResult(input);

            Type type = outputAssembly.GetType("Test");
            MethodInfo main = type.GetMethod("Main");

            var @return = (int)main.Invoke(null, null);

            Assert.AreEqual(18, @return);
        }


        [Test]
        public void MethodCallWithBooleanArgumentsTest()
        {
            var input = @"
public class Test { 
    public bool BooleanFunction(bool x) 
    { 
        return x; 
    }

    public bool Main()
    { 
        return BooleanFunction(true);
    } 
}";

            var outputAssembly = GetResult(input);

            Type type = outputAssembly.GetType("Test");
            MethodInfo main = type.GetMethod("Main");

            var @return = (bool)main.Invoke(null, null);

            Assert.AreEqual(true, @return);
        }

        [Test]
        public void MethodCallTest()
        {
            var input = @"
public class Test { 
    public int GetValue() 
    { 
        return 3; 
    }

    public int Main()
    { 
        return GetValue();
    } 
}";

            var outputAssembly = GetResult(input);

            Type type = outputAssembly.GetType("Test");
            MethodInfo main = type.GetMethod("Main");

            var @return = (int)main.Invoke(null, null);

            Assert.AreEqual(3, @return);
        }

        [Test]
        public void MultiLineProgramTest()
        {
            var input = @"
public class Test 
{ 
    public int TestMethodName(){ 
        return 9;
    } 
}";

            GetResult(input);
        }

        [Test]
        public void DefineAndUseVariableTest()
        {
            var input = @"public class Test { public int TestMethodName(){ int a = 8; return 9 + a;} }";

            var outputAssembly = GetResult(input);

            Type type = outputAssembly.GetType("Test");
            MethodInfo main = type.GetMethod("TestMethodName");

            var @return = (int)main.Invoke(null, null);

            Assert.AreEqual(17, @return);    
        }

        [Test]
        public void AssignVariableTest()
        {
            var input = @"public class Test { public int TestMethodName(){ int a = 8; a = 9;  return a;} }";

            var outputAssembly = GetResult(input);

            Type type = outputAssembly.GetType("Test");
            MethodInfo main = type.GetMethod("TestMethodName");

            var @return = (int)main.Invoke(null, null);

            Assert.AreEqual(9, @return);    
        }
    }
}