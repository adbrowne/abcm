using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Decaf.Tests
{
    [TestFixture]
    public class ClrCodeGeneratorTests
    {
        [Test]
        public void EmptyAssemblyTest()
        {
            var clrCodeGenerator = new ClrCodeGenerator("Output.exe");
            var currentType = clrCodeGenerator.StartModule("Foo");
            currentType.CreateType();
            clrCodeGenerator.Save();
        }

        public int two = 2;
        [Test]
        public void SimpleExpressionTest()
        {
            Console.WriteLine(9*two);
            var clrCodeGenerator = new ClrCodeGenerator("Output.exe");
            var currentType = clrCodeGenerator.StartModule("Foo");
            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprNumber(9);
            clrCodeGenerator.EndExpression();
            currentType.CreateType();
            clrCodeGenerator.Save();
        }

        [Test]
        public void MultiplicationExpressionTest()
        {
            var clrCodeGenerator = new ClrCodeGenerator("Output.exe");
            var currentType = clrCodeGenerator.StartModule("Foo");
            clrCodeGenerator.BeginExpression();
            clrCodeGenerator.ExprNumber(9);
            clrCodeGenerator.ExprNumber(2);
            clrCodeGenerator.Operation("Multiplication");
            clrCodeGenerator.EndExpression();
            currentType.CreateType();
            clrCodeGenerator.Save();
        }
    }
}
