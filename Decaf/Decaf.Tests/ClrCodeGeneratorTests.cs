using System;
using System.Reflection;
using System.Reflection.Emit;
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
            var type = clrCodeGenerator.StartModule("Foo");
            type.CreateType();
            clrCodeGenerator.Save();
        }
    }
}
