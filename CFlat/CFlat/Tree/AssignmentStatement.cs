using CFlat;

namespace CFlat.Tree
{
    public class AssignmentStatement : Statement
    {
        public AssignmentStatement(string name, Expression expression) : base(expression)
        {
            VariableName = name;
        }

        public string VariableName
        { get; private set; }

        public override void Compile(CompilerContext context)
        {
            base.Compile(context);

            Expression.Compile(context);
            context.CodeGenerator.AssignExpression(VariableName);
        }
    }
}