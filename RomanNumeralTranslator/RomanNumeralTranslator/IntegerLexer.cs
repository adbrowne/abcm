using System;
using System.Collections.Generic;

namespace RomanNumeralTranslator
{
    public class IntegerLexer
    {
        public IEnumerable<Token> Tokenize(string input)
        {
            var tokens =new List<Token>();
            int x =input.Length-1;
            TokenType currentType = TokenType.Ones;
            while (x >= 0)
            {
                tokens.Add(new Token(currentType, Int32.Parse(input[x].ToString())));
                currentType++;
                x--;
            }

            tokens.Reverse();
            return tokens;
        }
    }
}