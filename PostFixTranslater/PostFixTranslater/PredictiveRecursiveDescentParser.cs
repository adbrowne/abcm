using System;
using System.Collections.Generic;
using System.Text;

namespace PostFixTranslater
{
    public class PredictiveRecursiveDescentParser
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
                match(lookahead);
            }
            else throw new InvalidOperationException(String.Format("Illegal term detected {0}", lookahead));
        }

        private void rest()
        {
            while (true)
            {
                if (lookahead == Token.Plus)
                {
                    match(Token.Plus);
                    term();
                    output('+');
                }
                else if (lookahead == Token.Minus)
                {
                    match(Token.Minus);
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

        private void match(Token token)
        {
            if (lookahead == token)
            {
                lookahead = enumerator.MoveNext() ? enumerator.Current : Token.Empty;
            }
            else throw new InvalidOperationException(String.Format("Failed to match on {0}", token));
        }



        private static bool isDigit(Token lookahead)
        {
            return (int)lookahead < 10;
        }

        private void output(Token token)
        {
            result.Append(((int)token).ToString());
        }
    }
}