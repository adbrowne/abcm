using CFlat;

namespace CFlat.Tree
{
    public class ReturnStatement : Statement
    {
        public ReturnStatement(Expression expression) : base(expression)
        {

        }

        public override void Compile(ErrorSet errorSet, CompilerContext context)
        {
            base.Compile(errorSet, context);

            context.CodeGenerator.BeginExpression();

            Expression.Compile(errorSet, context);
            
            context.CodeGenerator.EndExpression();

            context.CodeGenerator.ReturnExpression();
        }
    }
}