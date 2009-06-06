using CFlat;

namespace CFlat.Tree
{
    public class StringExpression : Expression
    {
        public string Value { get; private set; }

        public StringExpression(string value)
        {
            Value = value.Substring(1).Substring(0,value.Length - 2);
        }

        public override Types Type
        {
            get { return Types.String; }
        }
    }
}