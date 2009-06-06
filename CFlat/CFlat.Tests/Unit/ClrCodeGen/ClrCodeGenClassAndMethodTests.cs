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

            clrCodeGenerator.BeginMethod("Test");
            clrCodeGenerator.DefineVariable("a", "int");
            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprNumber(9);
            clrCodeGenerator.EndExpression();
            clrCodeGenerator.Return("a");
            clrCodeGenerator.EndModule();

            var outputAssembly = GetResult(clrCodeGenerator);

            Assert.That(outputAssembly.ContainsTypeWithMethod("Test", "Test"));
        }
    }
}