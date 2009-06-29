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
    }
}