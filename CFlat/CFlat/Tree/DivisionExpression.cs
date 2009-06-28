using CFlat;

namespace CFlat.Tree
{
    public class DivisionExpression : BinOpExpression
    {
        public DivisionExpression(Expression expr1, Expression expr2) : base(expr1, expr2)
        {
        }

        public override Types Type
        {
            get { return Types.Int; }
        }

        public override void Compile(CompilerContext context)
        {
            base.Compile(context);
        }

        protected override Operator Operator
        {
            get { return Operator.Divide; }
        }
    }
}