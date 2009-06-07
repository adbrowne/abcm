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
            get { throw new System.NotImplementedException(); }
        }

        public override void Compile(ErrorSet set, CompilerContext context)
        {
            base.Compile(set, context);
            Expr1.Compile(set, context);
            Expr2.Compile(set, context);
            context.CodeGenerator.Operation("Multiplication");
        }
    }
}