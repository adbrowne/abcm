using System;
using System.Collections.Generic;
using System.Text;

namespace PostFixTranslater
{
    public class PostfixParser
    {
        private Token lookahead;
        private IEnumerator<Token> enumerator;
        StringBuilder result;
        public string Parse(IEnumerable<Token> tokens)
        {
            enumerator = tokens.GetEnumerator();
            result = new StringBuilder();

            if (enumerator.MoveNext())
            {
                lookahead = enumerator.Current;
                expr();
            }
            return result.ToString();
        }

        private void expr()
        {
            term();
            rest();
        }

        private void term()
        {
            if (isDigit(lookahead))
            {
                output(lookahead);
                match(lookahead.Type);
            }
            else throw new InvalidOperationException(String.Format("Illegal term detected {0}", lookahead));
        }

        private void rest()
        {
            while (true)
            {
                if (lookahead.Type == TokenType.Plus)
                {
                    match(TokenType.Plus);
                    term();
                    output('+');
                }
                else if (lookahead.Type == TokenType.Minus)
                {
                    match(TokenType.Minus);
                    term();
                    output('-');
                }
                else
                {
                    break;
                }
            }
        }

        private void output(char c)
        {
            result.Append(c);
        }

        private void match(TokenType token)
        {
            if (lookahead.Type == token)
            {
                lookahead = enumerator.MoveNext() ? enumerator.Current : new Token(TokenType.Empty);
            }
            else throw new InvalidOperationException(String.Format("Failed to match on {0}", token));
        }



        private static bool isDigit(Token lookahead)
        {
            return lookahead.Type == TokenType.Digit;
        }

        private void output(Token token)
        {
            result.Append(token.Value.ToString());
        }
    }
}