using CFlat;
using NUnit.Framework;

namespace CFlat.Tests.Unit.ClrCodeGen
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