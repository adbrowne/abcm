using System.Collections.Generic;

namespace CFlat.Tree
{
    public class WhileStatement : Statement
    {
            public List<Statement> Body { get; private set; }

            public WhileStatement(Expression expression)
                : base(expression)
            {
                Body = new List<Statement>();
            }

            public override void Compile(CompilerContext context)
            {
                base.Compile(context);
                var whileToken = context.CodeGenerator.BeginWhileExpression();
                Expression.Compile(context);
                context.CodeGenerator.BeginWhileBody(whileToken);

                foreach (var statement in Body)
                {
                    statement.Compile(context);
                }

                context.CodeGenerator.EndWhile(whileToken);
            }
        }
}