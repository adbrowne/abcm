using CFlat;
using CFlat.Tree;

namespace CFlat.Tree
{
    public class AdditionExpression : BinOpExpression
    {
        public AdditionExpression(Expression expr1, Expression expr2) : base(expr1, expr2)
        {
        }

        public override Types Type
        {
            get { throw new System.NotImplementedException(); }
        }

        public override void Compile(CompilerContext context)
        {
            base.Compile(context);

            Expr1.Compile(context);
            Expr2.Compile(context);
            context.CodeGenerator.Operation(Operator.Add);
        }
    }
}