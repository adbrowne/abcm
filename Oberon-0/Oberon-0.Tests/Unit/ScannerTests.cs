using NUnit.Framework;
using System.IO;

namespace Oberon_0.Tests.Unit
{
    [TestFixture]
    public class ScannerTests
    {
        [Test]
        public void TestCommentValidComment()
        {
            var scanner = GetScanner("(*asdfadsf*)");
            scanner.Comment();
        }

        [Test]
        public void TestNumerIsRead()
        {
            var scanner = GetScanner("1234 d");
            scanner.Number();
            Assert.AreEqual(1234, scanner.val);
        }

        [Test]
        public void TestIdentIsRead()
        {
            var scanner = GetScanner("VarName 1");
            scanner.Ident();
            Assert.AreEqual("VarName", scanner.id);
            Assert.AreEqual(Token.Ident, scanner.sym);
        }

        [Test]
        public void TestKeyWordIsRecognized()
        {
            var scanner = GetScanner("ARRAY 1");
            scanner.Ident();
            Assert.AreEqual("ARRAY", scanner.id);
            Assert.AreEqual(Token.Array, scanner.sym);
        }

        private Oberon_0.Scanner GetScanner(string input)
        {
            Stream stream = new MemoryStream();
            var sw = new StreamWriter(stream);
            sw.Write(input);
            sw.Flush();

            stream.Seek(0, SeekOrigin.Begin);
            return new Oberon_0.Scanner(stream, new KeyTable());
        }
    }
}