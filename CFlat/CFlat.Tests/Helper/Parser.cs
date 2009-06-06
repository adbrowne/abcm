using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace CFlat.Tests.Helper
{
    public class Parser
    {
        public static CFlatTree CreateParser(string input)
        {
            var antlrStringStream = new ANTLRStringStream(input);
            var lexter = new CFlatLexer(antlrStringStream);
            var tokens = new CommonTokenStream(lexter);
            var parser = new CFlatParser(tokens);

            var tree = parser.prog().Tree;

            var nodes = new CommonTreeNodeStream(tree);
            var walker = new CFlatTree(nodes, new ErrorSet());

            return walker;
        }

    }
}