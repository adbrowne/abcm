namespace CFlat.Tree
{
    public class LessThanExpression : BinOpExpression
    {
        public LessThanExpression(Expression expr1, Expression expr2) : base(expr1, expr2)
        {
        }

        public override Types Type
        {
            get { return Types.Bool; }
        }
    }
}