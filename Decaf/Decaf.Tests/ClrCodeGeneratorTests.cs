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
            clrCodeGenerator.StartModule("Foo");
            clrCodeGenerator.EndModule();
            clrCodeGenerator.Save();
        }
    }
}
