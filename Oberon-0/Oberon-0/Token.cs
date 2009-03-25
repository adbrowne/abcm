namespace Oberon_0
{
    class Token : Enumeration
    {
        private Token(int value, string displayName) : base(value, displayName) { }

        public static readonly Token Times = new Token(1, "Times");

        public static readonly Token Null = new Token(2, "Null");
        public static readonly Token Div = new Token(3, "Div");
        public static readonly Token Mod = new Token(4, "Times");
        public static readonly Token And = new Token(5, "And");
        public static readonly Token Plus = new Token(6, "Plus");
        public static readonly Token Minus = new Token(7, "Minus");
        public static readonly Token Or = new Token(8, "Or");

        public static readonly Token Eql = new Token(9, "Eql");
        public static readonly Token Neq = new Token(10, "Neq");
        public static readonly Token Lss = new Token(11, "Lss");
        public static readonly Token Geq = new Token(12, "Geq");
        public static readonly Token Leq = new Token(13, "Leq");
        public static readonly Token Gtr = new Token(14, "Gtr");

        public static readonly Token Period = new Token(18, "Period");
        public static readonly Token Comma = new Token(19, "Comma");
        public static readonly Token Colon = new Token(20, "Colon");
        public static readonly Token Rparen = new Token(22, "Rparen");
        public static readonly Token Rbrak = new Token(23, "Rbrak");

        public static readonly Token Of = new Token(25, "Of");
        public static readonly Token Then = new Token(26, "Then");
        public static readonly Token Do = new Token(27, "Do");

        public static readonly Token Lparen = new Token(29, "Lparen");
        public static readonly Token Lbrak = new Token(30, "Lbrak");
        public static readonly Token Not = new Token(32, "Not");
        public static readonly Token Becomes = new Token(33, "Becomes");
        public static readonly Token Number = new Token(34, "Number");
        public static readonly Token Ident = new Token(37, "Ident");

        public static readonly Token Semicolon = new Token(38, "Semicolon");
        public static readonly Token End = new Token(40, "End");
        public static readonly Token Else = new Token(41, "Else");
        public static readonly Token Elsif = new Token(42, "Elsif");

        public static readonly Token If = new Token(44, "If");
        public static readonly Token While = new Token(46, "While");

        public static readonly Token Array = new Token(54, "Array");
        public static readonly Token Record = new Token(55, "Record");

        public static readonly Token Const = new Token(57, "Const");
        public static readonly Token Type = new Token(58, "Type");
        public static readonly Token Var = new Token(59, "Var");
        public static readonly Token Procedure = new Token(60, "Procedure");
        public static readonly Token Begin = new Token(61, "Begin");
        public static readonly Token Module = new Token(63, "Module");
        public static readonly Token Eof = new Token(64, "Eof");
    }
}
