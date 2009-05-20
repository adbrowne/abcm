using System;
using System.Reflection;
using System.Reflection.Emit;
using NUnit.Framework;

namespace Decaf.Tests
{
    [TestFixture]
    public class ClrCodeGenStatementTests
    {
        private TypeBuilder currentType;

        ClrCodeGenerator GetGeneratorForStatement()
        {
            string name = "Output_" + Guid.NewGuid().ToString("N") + ".exe";
            var clrCodeGenerator = new ClrCodeGenerator(name);
            currentType = clrCodeGenerator.StartModule("Foo");
            return clrCodeGenerator;
        }

        private object GetStatementResult(ClrCodeGenerator clrCodeGenerator)
        {
            currentType.CreateType();
            clrCodeGenerator.Save();
            Assembly a = Assembly.Load(clrCodeGenerator.Name);

            Type foo = a.GetType("Foo");
            MethodInfo main = foo.GetMethod("Test");

            return main.Invoke(null, null);
        }

        public int Test()
        {
            int a = 9;
            return a;
        }

        [Test]
        public void SimpleStatementTest()
        {
            var clrCodeGenerator = GetGeneratorForStatement();
            clrCodeGenerator.BeginMethod("Test");
            clrCodeGenerator.DefineVariable("a","int");
            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprNumber(9);
            clrCodeGenerator.EndExpression();
            clrCodeGenerator.AssignExpression("a");
            clrCodeGenerator.Return("a");
            var output = GetStatementResult(clrCodeGenerator);
            Assert.AreEqual(9, output);
        }
   }
}