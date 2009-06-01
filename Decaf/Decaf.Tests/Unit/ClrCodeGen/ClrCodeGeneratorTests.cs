using NUnit.Framework;

namespace Decaf.Tests.Unit.ClrCodeGen
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