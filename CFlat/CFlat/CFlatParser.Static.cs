namespace CFlat
{

    public partial class CFlatParser
    {
        protected override object RecoverFromMismatchedToken(Antlr.Runtime.IIntStream input, int ttype, Antlr.Runtime.BitSet follow)
        {
            throw new ParserException();
        }

        public override void DisplayRecognitionError(string[] tokenNames, Antlr.Runtime.RecognitionException e)
        {
            base.DisplayRecognitionError(tokenNames, e);
        }
    }
}
