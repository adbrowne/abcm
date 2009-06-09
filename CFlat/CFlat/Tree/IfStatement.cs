using System.Collections.Generic;

namespace CFlat.Tree
{
    public class IfStatement : Statement
    {
        public List<Statement> IfBody { get; private set; }

        public IfStatement(Expression expression) : base(expression)
        {
            IfBody = new List<Statement>();
        }

        public override void Compile(CompilerContext context)
        {
            base.Compile(context);
            Expression.Compile(context);
            context.CodeGenerator.BeginIf();
            foreach (var statement in IfBody)
            {
                statement.Compile(context);
            }
            context.CodeGenerator.EndIf();
        }
    }
}