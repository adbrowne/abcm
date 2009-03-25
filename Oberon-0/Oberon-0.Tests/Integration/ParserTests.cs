using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Oberon_0.Tests.Integration
{
    [TestFixture]
    public class ParserTests
    {
        [Test]
        public void TestModule()
        {
            var parser = new Parser();
            Stream input = GetStream(@"MODULE TEST;
END TEST.
");
            parser.Compile(input);
        }

        [Test]
        public void TestProcedure()
        {
            var parser = new Parser();
            Stream input = GetStream(@"MODULE TEST;
PROCEDURE TestProc;
BEGIN
END TestProc;
END TEST.
");
            parser.Compile(input);
        }

        [Test]
        public void TestModuleDeclaration()
        {
            var parser = new Parser();
            Stream input = GetStream(
@"MODULE TEST;
VAR W: Writer;
PROCEDURE TestProc;
BEGIN
END TestProc;
END TEST.
");
            parser.Compile(input);
        }

        [Test]
        public void TestMethodCall()
        {
            var parser = new Parser();
            Stream input = GetStream(
@"MODULE TEST;
PROCEDURE TestProc;
BEGIN
    Write();
    Write();
END TestProc;
END TEST.
");
            parser.Compile(input);
        }
        [Test]
        public void TestProcedureWithParens()
        {
            var parser = new Parser();
            Stream input = GetStream(@"MODULE TEST;
PROCEDURE TestProc();
BEGIN
END TestProc;
END TEST.
");
            parser.Compile(input);
        }

        private Stream GetStream(string input)
        {
            Stream stream = new MemoryStream();
            var sw = new StreamWriter(stream);
            sw.Write(input);
            sw.Flush();

            stream.Seek(0, SeekOrigin.Begin);

            return stream;
        }

    }
}
