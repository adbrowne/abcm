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
        protected ITreeNode GetAst(string input)
        {
            var sampleInput = SurroundWithProgram(input);

            var proxyGenerator = new ProxyGenerator();
            var output = new StringBuilder();
            var generator = proxyGenerator.CreateInterfaceProxyWithoutTarget<ICodeGenerator>(new ConsoleInterceptor(output));

            var parser = CreateParser(sampleInput, generator);
            return parser.prog();
        }

        private CFlatTree CreateParser(string input, ICodeGenerator codeGenerator)
        {
            var antlrStringStream = new ANTLRStringStream(input);
            var lexter = new CFlatLexer(antlrStringStream);
            var tokens = new CommonTokenStream(lexter);
            var parser = new CFlatParser(tokens);

            var tree = parser.prog().Tree;

            var nodes = new CommonTreeNodeStream(tree);
            var walker = new CFlatTree(nodes, codeGenerator, new ErrorSet());
            
            return walker;
        }

        private static string SurroundWithProgram(string s)
        {
            return s;
        }
    }
}
