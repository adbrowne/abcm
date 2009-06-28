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
            get { return Types.Int; }
        }

        public override void Compile(CompilerContext context)
        {
            base.Compile(context);

            if(Expr1.Type != Expr2.Type)
            {
                context.ErrorSet.Add(new CompileError(CompileErrorType.CannotApplyOperator, new object[] {Operator.Add, Expr1.Type, Expr2.Type}));
                return;
            }

            Expr1.Compile(context);
            Expr2.Compile(context);
            context.CodeGenerator.Operation(Operator.Add);
        }
    }
}