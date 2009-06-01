using System;

namespace Decaf.Tree
{
    public class BooleanExpression : Expression
    {
        public bool Value { get; private set; }

        public BooleanExpression(string value)
        {
            Value = Convert.ToBoolean(value);
        }
    }
}