namespace Decaf.Tree
{
    public class StringExpression : Expression
    {
        public string Value { get; private set; }

        public StringExpression(string value)
        {
            Value = value.Substring(1).Substring(0,value.Length - 2);
        }
    }
}