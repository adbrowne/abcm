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

        public override object RecoverFromMismatchedSet(Antlr.Runtime.IIntStream input, Antlr.Runtime.RecognitionException e, Antlr.Runtime.BitSet follow)
        {
            return base.RecoverFromMismatchedSet(input, e, follow);
        }

        public override void Recover(Antlr.Runtime.IIntStream input, Antlr.Runtime.RecognitionException re)
        {
            base.Recover(input, re);
        }

        public override void DisplayRecognitionError(string[] tokenNames, Antlr.Runtime.RecognitionException e)
        {
            base.DisplayRecognitionError(tokenNames, e);
        }
    }
}
