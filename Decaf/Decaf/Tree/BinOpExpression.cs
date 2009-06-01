namespace Decaf.Tree
{
    public abstract class BinOpExpression : Expression
    {
        public Expression Expr1 { get; private set; }
        public Expression Expr2 { get; private set; }

        public BinOpExpression(Expression expr1, Expression expr2)
        {
            Expr1 = expr1;
            Expr2 = expr2;
        }
    }
}