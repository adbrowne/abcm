﻿using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using NUnit.Framework;

namespace CFlat.Tests
{
    [TestFixture]
    public class TypeTests
    {
        [Test]
        public void ExpectingBooleanExpression()
        {
            var input = "public class Test { public TestMethod(){ bool a = 9; }}";
            var output = GetErrors(input);

            Assert.AreEqual(CompileErrorType.TypeMismatch, output[0].Type);
        }

        private ErrorSet GetErrors(string input)
        {
            var errorSet = new ErrorSet();
            var parser = CreateParser(input, errorSet);
            var @class = parser.prog();
            @class.Compile(errorSet);
            return errorSet;
        }

        private CFlatTree CreateParser(string input, ErrorSet errorSet)
        {
            var antlrStringStream = new ANTLRStringStream(input);
            var lexter = new CFlatLexer(antlrStringStream);
            var tokens = new CommonTokenStream(lexter);
            var parser = new CFlatParser(tokens);

            var tree = parser.prog().Tree;

            var nodes = new CommonTreeNodeStream(tree);
            var walker = new CFlatTree(nodes, errorSet);
            
            return walker;
        }
    }
}