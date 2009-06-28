using CFlat;

namespace CFlat.Tree
{
    public class MultiplicationExpression : BinOpExpression
    {
        public MultiplicationExpression(Expression expr1, Expression expr2) : base(expr1, expr2)
        {
        }

        public override Types Type
        {
            get { return Types.Int; }
        }

        protected override Operator Operator
        {
            get { return Operator.Multiply; }
        }
    }
}