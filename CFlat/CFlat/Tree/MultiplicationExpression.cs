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

        public override void Compile(CompilerContext context)
        {
            base.Compile(context);
            Expr1.Compile(context);
            Expr2.Compile(context);
            context.CodeGenerator.Operation(Operator.Multiply);
        }
    }
}