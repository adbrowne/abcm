using System;

namespace Decaf.Tree
{
    public class IntegerExpression : Expression
    {
        public IntegerExpression(string value)
        {
            Value = Int32.Parse(value);
        }

        public int Value
        {
            get; private set;
        }
    }
}