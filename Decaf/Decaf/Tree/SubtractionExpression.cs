namespace Decaf.Tree
{
    public class SubtractionExpression : BinOpExpression
    {
        public SubtractionExpression(Expression expr1, Expression expr2) : base(expr1, expr2)
        {
        }

        public override Types Type
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}