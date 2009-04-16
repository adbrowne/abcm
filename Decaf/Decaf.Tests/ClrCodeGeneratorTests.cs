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
    }
}
