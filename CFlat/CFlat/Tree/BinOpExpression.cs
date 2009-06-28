using System;

namespace CFlat.Tree
{
    public abstract class BinOpExpression : Expression
    {
        public Expression Expr1 { get; private set; }
        public Expression Expr2 { get; private set; }

        protected BinOpExpression(Expression expr1, Expression expr2)
        {
            Expr1 = expr1;
            Expr2 = expr2;
        }

        public override void Compile(CompilerContext context)
        {
            base.Compile(context);

            if (Expr1.Type != Expr2.Type)
            {
                context.ErrorSet.Add(new CompileError(CompileErrorType.CannotApplyOperator, new object[] { Operator, Expr1.Type, Expr2.Type }));
                return;
            }

            Expr1.Compile(context);
            Expr2.Compile(context);
            context.CodeGenerator.Operation(Operator);
        }

        protected abstract Operator Operator { get; }
    }
}