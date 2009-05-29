using System;
using System.Reflection;
using System.Reflection.Emit;
using NUnit.Framework;

namespace Decaf.Tests
{
    [TestFixture]
    public class ClrCodeGenIfThenElseTests
    {
        ClrCodeGenerator GetGenerator()
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
        public void IfStatementTrueTest()
        {
            ClrCodeGenerator clrCodeGenerator = SetupIfTest();

            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprBool(true);
            clrCodeGenerator.EndExpression();


            clrCodeGenerator.BeginIf();

            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprNumber(3);
            clrCodeGenerator.EndExpression();
            clrCodeGenerator.AssignExpression("a");

            clrCodeGenerator.EndIf();

            EndIfTestGeneration(clrCodeGenerator);

            var outputAssembly = GetResult(clrCodeGenerator);

            Type foo = outputAssembly.GetType("Test");
            MethodInfo main = foo.GetMethod("Test");

            int result = (int) main.Invoke(null, null);
            Assert.AreEqual(3, result);
        
            Assert.That(outputAssembly.ContainsTypeWithMethod("Test", "Test"));
        }

        [Test]
        public void IfStatementFalseTest()
        {
            ClrCodeGenerator clrCodeGenerator = SetupIfTest();

            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprBool(false);
            clrCodeGenerator.EndExpression();


            clrCodeGenerator.BeginIf();

            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprNumber(3);
            clrCodeGenerator.EndExpression();
            clrCodeGenerator.AssignExpression("a");

            clrCodeGenerator.EndIf();

            EndIfTestGeneration(clrCodeGenerator);

            var outputAssembly = GetResult(clrCodeGenerator);

            Type foo = outputAssembly.GetType("Test");
            MethodInfo main = foo.GetMethod("Test");

            int result = (int)main.Invoke(null, null);
            Assert.AreEqual(9, result);

            Assert.That(outputAssembly.ContainsTypeWithMethod("Test", "Test"));
        }

        [Test]
        public void NestedIfStatementTest()
        {
            ClrCodeGenerator clrCodeGenerator = SetupIfTest();

            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprBool(true);
            clrCodeGenerator.EndExpression();


            clrCodeGenerator.BeginIf();

            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprBool(true);
            clrCodeGenerator.EndExpression();

            clrCodeGenerator.BeginIf();

            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprNumber(4);
            clrCodeGenerator.EndExpression();
            clrCodeGenerator.AssignExpression("a");

            clrCodeGenerator.EndIf();

            clrCodeGenerator.EndIf();
            EndIfTestGeneration(clrCodeGenerator);

            var outputAssembly = GetResult(clrCodeGenerator);

            Type foo = outputAssembly.GetType("Test");
            MethodInfo main = foo.GetMethod("Test");

            int result = (int)main.Invoke(null, null);
            Assert.AreEqual(4, result);

            Assert.That(outputAssembly.ContainsTypeWithMethod("Test", "Test"));
        }

        private void EndIfTestGeneration(ClrCodeGenerator clrCodeGenerator)
        {
            clrCodeGenerator.Return("a");
            clrCodeGenerator.EndMethod();
            clrCodeGenerator.EndModule();
        }

        private ClrCodeGenerator SetupIfTest()
        {
            var clrCodeGenerator = GetGenerator();

            clrCodeGenerator.StartModule("Test");

            clrCodeGenerator.BeginMethod("Test");

            clrCodeGenerator.DefineVariable("a", "int");
            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprNumber(9);
            clrCodeGenerator.EndExpression();
            clrCodeGenerator.AssignExpression("a");
            return clrCodeGenerator;
        }
    }
}