using CFlat;

namespace CFlat.Tree
{
    public class RemainderExpression : BinOpExpression
    {
        public RemainderExpression(Expression expr1, Expression expr2) : base(expr1, expr2)
        {
        }

        public override Types Type
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}