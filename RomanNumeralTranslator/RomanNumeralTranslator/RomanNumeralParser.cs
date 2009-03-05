using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralTranslator
{
    public class RomanNumeralParser
    {
        private IEnumerator<Token> enumerator;
        StringBuilder result;
        private Token lookahead;

        public string Parse(IEnumerable<Token> tokens)
        {
            enumerator = tokens.GetEnumerator();
            result = new StringBuilder();

            if (enumerator.MoveNext())
            {
                lookahead = enumerator.Current;
                num();
            }
            return result.ToString();
        }

        private void num()
        {
            while (true)
            {
                if (lookahead.Type == TokenType.Ones)
                {
                    ones();
                }
                else if (lookahead.Type == TokenType.Tens)
                {
                    tens();
                }
                else if (lookahead.Type == TokenType.Hundreds)
                {
                    hundreds();
                }
                else if (lookahead.Type == TokenType.Thousands)
                {
                    thousands();
                }
                else
                    break;
            }
        }

        private void thousands()
        {
            switch ((int)lookahead.Value)
            {
                case 0:
                    break;
                case 1:
                    output("M");
                    break;
                case 2:
                    output("MM");
                    break;
                case 3:
                    output("MMM");
                    break;
                default:
                    throw new InvalidOperationException("Cannot have numbers greater than 3999");
            }
            match(TokenType.Thousands);
        }

        private void hundreds()
        {
            switch ((int)lookahead.Value)
            {
                case 1:
                    output("C");
                    break;
                case 2:
                    output("CC");
                    break;
                case 3:
                    output("CCC");
                    break;
                case 4:
                    output("CD");
                    break;
                case 5:
                    output("D");
                    break;
                case 6:
                    output("DC");
                    break;
                case 7:
                    output("DCC");
                    break;
                case 8:
                    output("DCCC");
                    break;
                case 9:
                    output("CM");
                    break;
            }
            match(TokenType.Hundreds);
        }

        private void tens()
        {
            switch ((int)lookahead.Value)
            {
                case 1:
                    output("X");
                    break;
                case 2:
                    output("XX");
                    break;
                case 3:
                    output("XXX");
                    break;
                case 4:
                    output("XL");
                    break;
                case 5:
                    output("L");
                    break;
                case 6:
                    output("LX");
                    break;
                case 7:
                    output("LXX");
                    break;
                case 8:
                    output("LXXX");
                    break;
                case 9:
                    output("XC");
                    break;
            }
            match(TokenType.Tens);
        }

        private void ones()
        {
            switch((int)lookahead.Value)
            {
                case 1:
                    output("I");
                    break;
                case 2:
                    output("II");
                    break;
                case 3:
                    output("III");
                    break;
                case 4:
                    output("IV");
                    break;
                case 5:
                    output("V");
                    break;
                case 6:
                    output("VI");
                    break;
                case 7:
                    output("VII");
                    break;
                case 8:
                    output("VIII");
                    break;
                case 9:
                    output("IX");
                    break;
            }
            
            match(TokenType.Ones);
        }

        private void output(string output)
        {
            result.Append(output);
        }

        private void match(TokenType token)
        {
            if (lookahead.Type == token)
            {
                lookahead = enumerator.MoveNext() ? enumerator.Current : new Token(TokenType.Empty);
            }
            else throw new InvalidOperationException(String.Format("Failed to match on {0}", token));
        }
    }
}