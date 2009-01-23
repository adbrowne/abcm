namespace PostFixTranslater
{
    public enum TokenType
    {
        Digit,
        Plus,
        Minus,
        Empty
    }
    public struct Token
    {
        public TokenType Type { get; set; }
        public object Value { get; set; }

        public Token(TokenType type, object value) : this()
        {
            Type = type;
            Value = value;
        }

        public Token(TokenType type) : this(type, null)
        {
            
        }
    }
}