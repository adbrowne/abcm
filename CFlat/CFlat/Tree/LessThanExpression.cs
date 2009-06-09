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

        public override void Compile(CompilerContext context)
        {
            base.Compile(context);

            Expr1.Compile(context);
            Expr2.Compile(context);
            context.CodeGenerator.Operation(Operator.LessThan);
        }
    }
}