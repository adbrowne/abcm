namespace CFlat
{
    public partial class CFlatLexer
    {
        public override void ReportError(Antlr.Runtime.RecognitionException e)
        {
            throw new ParserException(e.Message, e);
        }
    }
}
