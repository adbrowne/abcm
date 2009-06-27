using System;
using System.Reflection;
using CFlat.Tests.Helper;
using NUnit.Framework;

namespace CFlat.Tests.Unit.ClrCodeGen
{
    [TestFixture]
    public class ClrCodeGenClassAndMethodTests
    {
        ClrCodeGenerator GetGeneratorForClass()
        {
            string name = "Output_" + Guid.NewGuid().ToString("N") + ".exe";
            var clrCodeGenerator = new ClrCodeGenerator(name);
            return clrCodeGenerator;
        }

        private Assembly GetResult(ClrCodeGenerator clrCodeGenerator)
        {
            clrCodeGenerator.Save();
            return Assembly.Load(clrCodeGenerator.Name);
        }

        [Test]
        public void SimpleClassTest()
        {
            var clrCodeGenerator = GetGeneratorForClass();

            clrCodeGenerator.StartModule("Test");
            clrCodeGenerator.EndModule();

            var outputAssembly = GetResult(clrCodeGenerator);
            
            Assert.That(outputAssembly.ContainsType("Test"));
        }

        [Test]
        public void SimpleClassAndMethodTest()
        {
            var clrCodeGenerator = GetGeneratorForClass();

            clrCodeGenerator.StartModule("Test");

            clrCodeGenerator.RegisterMethod("Test", Types.Int);
            
            clrCodeGenerator.BeginMethod("Test");
            clrCodeGenerator.DefineVariable("a", Types.Int);
            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprNumber(9);
            clrCodeGenerator.EndExpression();
            clrCodeGenerator.Return("a");
            clrCodeGenerator.EndModule();

            var outputAssembly = GetResult(clrCodeGenerator);

            Assert.That(outputAssembly.ContainsTypeWithMethod("Test", "Test"));
        }

        [Test]
        public void MethodWithArgumentsTest()
        {
            var clrCodeGenerator = GetGeneratorForClass();

            clrCodeGenerator.StartModule("Test");

            clrCodeGenerator.RegisterMethod("Test", Types.Int, new Parameter(Types.Int, "x"));

            clrCodeGenerator.BeginMethod("Test");
            clrCodeGenerator.Return("x");
            clrCodeGenerator.EndModule();

            var outputAssembly = GetResult(clrCodeGenerator);

            Type foo = outputAssembly.GetType("Test");
            MethodInfo main = foo.GetMethod("Test");

            int result = (int)main.Invoke(null, new object[]{5});
            Assert.AreEqual(5, result);
        
            Assert.That(outputAssembly.ContainsTypeWithMethod("Test", "Test"));
        }

        [Test]
        public void MultipleMethodTest()
        {
            var clrCodeGenerator = GetGeneratorForClass();

            clrCodeGenerator.StartModule("Test");

            clrCodeGenerator.RegisterMethod("FirstMethod", Types.Int);
            clrCodeGenerator.BeginMethod("FirstMethod");
            clrCodeGenerator.DefineVariable("a", Types.Int);
            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprNumber(9);
            clrCodeGenerator.EndExpression();
            clrCodeGenerator.Return("a");

            clrCodeGenerator.RegisterMethod("SecondMethod", Types.Int);
            clrCodeGenerator.BeginMethod("SecondMethod");
            clrCodeGenerator.DefineVariable("a", Types.Int);
            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprNumber(9);
            clrCodeGenerator.EndExpression();
            clrCodeGenerator.Return("a");
           
            clrCodeGenerator.EndModule();

            var outputAssembly = GetResult(clrCodeGenerator);

            Assert.That(outputAssembly.ContainsTypeWithMethod("Test", "FirstMethod"));
            Assert.That(outputAssembly.ContainsTypeWithMethod("Test", "SecondMethod"));
        }
    }
}