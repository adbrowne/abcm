using System;
using CFlat;

namespace CFlat.Tree
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

        public override Types Type
        {
            get { return Types.Int; }
        }
    }
}