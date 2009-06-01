using System;

namespace Decaf.Tree
{
    public class Statement
    {
        public Statement(Expression expression)
        {
            Expression = expression;
        }

        public Expression Expression
        {
            get;private set;
        }

        public virtual void Compile(ErrorSet errorSet)
        {
            
        }
    }
}