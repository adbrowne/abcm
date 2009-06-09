using Antlr.Runtime.Tree;
using CFlat.Tree;

namespace CFlat
{

    public partial class CFlatTree
    {
        private ITreeBuilder TB { get; set; }
        public CFlatTree(ITreeNodeStream input, ErrorSet errorSet)
            : this(input)
        {
            TB = new TreeBuilder();
        }

        protected override object RecoverFromMismatchedToken(Antlr.Runtime.IIntStream input, int ttype, Antlr.Runtime.BitSet follow)
        {
            throw new ParserException();
        }
    }
}
