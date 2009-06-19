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
        }
}