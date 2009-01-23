using System.Collections.Generic;

namespace PostFixTranslater
{
    public class SimpleLexer
    {
        public IEnumerable<Token> Tokenize(string input)
        {
            foreach (var nextChar in input)
            {
                if (nextChar == '0')
                    yield return Token.Zero;
                if (nextChar == '1')
                    yield return Token.One;
                if (nextChar == '2')
                    yield return Token.Two;
                if (nextChar == '3')
                    yield return Token.Three;
                if (nextChar == '4')
                    yield return Token.Four;
                if (nextChar == '5')
                    yield return Token.Five;
                if (nextChar == '6')
                    yield return Token.Six;
                if (nextChar == '7')
                    yield return Token.Seven;
                if (nextChar == '8')
                    yield return Token.Eight;
                if (nextChar == '9')
                    yield return Token.Nine;
                if (nextChar == '+')
                    yield return Token.Plus;
                if (nextChar == '-')
                    yield return Token.Minus;
            }
        }
    }
}