namespace PostFixTranslater
{
    public class PostfixTranslator
    {
        public string Tranlate(string input)
        {
            var lexer = new SimpleLexer();
            var parser = new PredictiveRecursiveDescentParser();
            return parser.Parse(lexer.Tokenize(input));
        }
    }
}