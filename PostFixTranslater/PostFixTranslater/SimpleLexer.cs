using System;
using System.Collections.Generic;

namespace PostFixTranslater
{
    public class SimpleLexer
    {
        public IEnumerable<Token> Tokenize(string input)
        {
            foreach (var nextChar in input)
            {
                if (nextChar == '+')
                    yield return new Token(TokenType.Plus);
                if (nextChar == '-')
                    yield return new Token(TokenType.Minus);
                
                int number;
                if(Int32.TryParse(nextChar.ToString(), out number ))
                {
                    yield return new Token(TokenType.Digit, number);
                }
            }
        }
    }
}