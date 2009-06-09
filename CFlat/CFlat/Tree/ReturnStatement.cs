using CFlat;

namespace CFlat.Tree
{
    public class ReturnStatement : Statement
    {
        public ReturnStatement(Expression expression) : base(expression)
        {

        }

        public override void Compile(CompilerContext context)
        {
            base.Compile(context);

            context.CodeGenerator.BeginExpression();

            Expression.Compile(context);
            
            context.CodeGenerator.EndExpression();

            context.CodeGenerator.ReturnExpression(Expression.Type);
        }
    }
}