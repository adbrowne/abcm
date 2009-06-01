using System;

namespace Decaf.Tree
{
    public class CharExpression : Expression
    {
        public char Value { get; private set; }

        public CharExpression(string value)
        {
            Value = Convert.ToChar(value);
        }

        public override Types Type
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}