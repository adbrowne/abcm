using System;
using System.Reflection;
using CFlat;
using CFlat.CodeGen.Clr;
using CFlat.Tests.Helper;
using NUnit.Framework;

namespace CFlat.Tests.Unit.ClrCodeGen
{
    [TestFixture]
    public class ClrCodeGenLoopTests
    {
        ClrCodeGenerator GetGenerator()
        {
            string name = "Output_" + Guid.NewGuid().ToString("N") + ".exe";
            var clrCodeGenerator = new ClrCodeGenerator(name);
            return clrCodeGenerator;
        }

        private Assembly GetResult(ClrCodeGenerator clrCodeGenerator)
        {
            return clrCodeGenerator.Save(false);
        }

        [Test]
        public void WhileTrueTest()
        {
            var clrCodeGenerator = GetGenerator();

            clrCodeGenerator.StartModule("Test");

            clrCodeGenerator.RegisterMethod("Test", Types.Int);
            clrCodeGenerator.BeginMethod("Test");

            clrCodeGenerator.DefineVariable("a", Types.Int);
            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprNumber(0);
            clrCodeGenerator.EndExpression();
            clrCodeGenerator.AssignExpression("a");

            clrCodeGenerator.BeginWhileExpression();

            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprId("a");
            clrCodeGenerator.ExprNumber(5);
            clrCodeGenerator.Operation(Operator.LessThan);
            clrCodeGenerator.EndExpression();

            clrCodeGenerator.BeginWhileBody();

            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprId("a");
            clrCodeGenerator.ExprNumber(1);
            clrCodeGenerator.Operation(Operator.Add);
            clrCodeGenerator.EndExpression();
            clrCodeGenerator.AssignExpression("a");

            clrCodeGenerator.EndWhile();

            clrCodeGenerator.Return("a");
            clrCodeGenerator.EndMethod();
            clrCodeGenerator.EndModule();
        
            var outputAssembly = GetResult(clrCodeGenerator);

            Type foo = outputAssembly.GetType("Test");
            MethodInfo main = foo.GetMethod("Test");

            int result = (int) main.Invoke(null, null);
            Assert.AreEqual(5, result);
        
            Assert.That(outputAssembly.ContainsTypeWithMethod("Test", "Test"));
        }


    }
}