using System;

namespace CFlat.Tree
{
    public class GreaterThanExpression : BinOpExpression
    {
        public GreaterThanExpression(Expression expr1, Expression expr2)
            : base(expr1, expr2)
        {
        }

        public override Types Type
        {
            get { return Types.Bool; }
        }

        protected override Operator Operator
        {
            get { return Operator.GreaterThan; }
        }
    }
}