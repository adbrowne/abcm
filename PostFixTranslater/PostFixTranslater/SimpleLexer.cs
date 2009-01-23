using System;
using System.Collections.Generic;

namespace PostFixTranslater
{
    public class SimpleLexer
    {
        public IEnumerable<Token> Tokenize(string input)
        {
            int x = 0;
            while(x < input.Length)
            {
                var nextChar = input[x];

                if (nextChar == '+')
                    yield return new Token(TokenType.Plus);
                if (nextChar == '-')
                    yield return new Token(TokenType.Minus);
                
                int number;
                int count;
                if(TryGetNumber(input, x, out number , out count))
                {
                    x += (count - 1);
                    yield return new Token(TokenType.Digit, number);
                }

                x++;
            }
        }

        private bool TryGetNumber(string input, int startIndex, out int number, out int length)
        {
            int count = 0;
            while (startIndex + count <  input.Length && IsDigit(input[startIndex + count]))
            {
                count++;
            }

            bool foundNumber = (count > 0);

            number = foundNumber ? Int32.Parse(input.Substring(startIndex, count)) : 0;
            length = foundNumber ? count: 0;
            return foundNumber;                
        }

        private bool IsDigit(char input)
        {
            switch(input)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    return true;
                default:
                    return false;
            }
        }
    }
}