using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using NUnit.Framework;

namespace CFlat.Tests.Integration
{
    [TestFixture]
    public class ShellTests
    {
        [Test]
        public void CompileSimpleTest()
        {
            string outputFile = "SimpleTest" + Guid.NewGuid().ToString("N")+ ".dll";
            
            Program.Main(new[]{"Integration\\SimpleTest.cflat", "-o", outputFile});

            var fullPath = Path.GetFullPath(outputFile);
            var assembly = Assembly.LoadFile(fullPath);

            Type type = assembly.GetType("SimpleTest");
            MethodInfo main = type.GetMethod("Main");

            var @return = (int)main.Invoke(null, null);

            Assert.AreEqual(3, @return);
        
        }

        [Test]
        public void CommandLineCompileSimpleTest()
        {
            string outputFile = "SimpleTest" + Guid.NewGuid().ToString("N") + ".dll";
            
            var process = Process.Start("cflat.exe", @"Integration\\SimpleTest.cflat -o " + outputFile);
            process.WaitForExit();
            var fullPath = Path.GetFullPath(outputFile);
            var assembly = Assembly.LoadFile(fullPath);

            Type type = assembly.GetType("SimpleTest");
            MethodInfo main = type.GetMethod("Main");

            var @return = (int)main.Invoke(null, null);

            Assert.AreEqual(3, @return);

        }
    }
}