using Antlr.Runtime;
using Antlr.Runtime.Tree;
using CFlat.CodeGen.Clr;

namespace CFlat
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var inputFile = args[0];
            var outputFile = args[2];

            var antlrStringStream = new ANTLRFileStream(inputFile);
            var lexter = new CFlatLexer(antlrStringStream);
            var tokens = new CommonTokenStream(lexter);
            var parser = new CFlatParser(tokens);

            var tree = parser.prog().Tree;

            var nodes = new CommonTreeNodeStream(tree);
            var walker = new CFlatTree(nodes, new ErrorSet());

            var prog = walker.prog();

            var context = new CompilerContext(new ClrCodeGenerator(outputFile), new ErrorSet());
            prog.Compile(context);

            context.Save(true);
        }
    }
}
