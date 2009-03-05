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
END
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
