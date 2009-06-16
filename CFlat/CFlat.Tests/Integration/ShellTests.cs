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
            const string outputFile = "SimpleTest.dll";
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
            const string outputFile = "SimpleTest.dll";
            
            Process.Start("cflat.exe", @"Integration\\SimpleTest.cflat -o SimpleTest.dll");
            
            var fullPath = Path.GetFullPath(outputFile);
            var assembly = Assembly.LoadFile(fullPath);

            Type type = assembly.GetType("SimpleTest");
            MethodInfo main = type.GetMethod("Main");

            var @return = (int)main.Invoke(null, null);

            Assert.AreEqual(3, @return);

        }
    }
}