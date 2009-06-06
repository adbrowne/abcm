using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using Castle.DynamicProxy;
using CFlat.Tree;

namespace CFlat.Tests.Unit.AST
{
    public class AstTestBase
    {
        protected static ITreeNode GetAst(string input)
        {
            var sampleInput = SurroundWithProgram(input);

            var parser = Helper.Parser.CreateParser(sampleInput);
            return parser.prog();
        }

        private static string SurroundWithProgram(string s)
        {
            return s;
        }
    }
}
