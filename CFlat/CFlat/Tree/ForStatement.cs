using System;
using System.Collections.Generic;

namespace CFlat.Tree
{
    public class ForStatement : Statement
    {
        public List<Statement> Body { get; private set; }

        public DeclarationStatement Declaration { get; set; }

        public AssignmentStatement Iterator { get; set; }

        public ForStatement(Expression expression) : base(expression)
        {
            Body = new List<Statement>();
        }

        public override void Compile(CompilerContext context)
        {
            base.Compile(context);

            Declaration.Compile(context);

            var loopToken = context.CodeGenerator.BeginLoopExpression();
            Expression.Compile(context);
            context.CodeGenerator.BeginLoopBody(loopToken);

            foreach (var statement in Body)
            {
                statement.Compile(context);
            }

            Iterator.Compile(context);

            context.CodeGenerator.EndLoop(loopToken);
        }
    }
}