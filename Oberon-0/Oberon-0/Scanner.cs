using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace Oberon_0
{
    internal class Scanner
    {
        internal Token sym;
        char ch;
        Stream t;
        internal int val;

        private readonly KeyTable keyTable;

        public void EnterKW(Token token, string name)
        {
            keyTable.Add(name, token);
        }

        public void Mark(string msg)
        {
            Debug.WriteLine(msg);

        }

        public Scanner(Stream t, KeyTable keyTable)
        {
            this.t = t;
            this.keyTable = keyTable;

            if (Eof())
                throw new InvalidOperationException("Cannot init empty stream");
            ReadChar();

            EnterKW(Token.Null, "BY");

            EnterKW(Token.Do, "DO");
            EnterKW(Token.If, "IF");
            EnterKW(Token.Null, "IN");
            EnterKW(Token.Null, "IS");
            EnterKW(Token.Of, "OF");
            EnterKW(Token.Or, "OR");
            EnterKW(Token.Null, "TO");
            EnterKW(Token.End, "END");
            EnterKW(Token.Null, "FOR");
            EnterKW(Token.Mod, "MOD");
            EnterKW(Token.Null, "NIL");
            EnterKW(Token.Var, "VAR");
            EnterKW(Token.Null, "CASE");
            EnterKW(Token.Else, "ELSE");
            EnterKW(Token.Null, "EXIT");
            EnterKW(Token.Then, "THEN");
            EnterKW(Token.Type, "TYPE");
            EnterKW(Token.Null, "WITH");
            EnterKW(Token.Array, "ARRAY");
            EnterKW(Token.Begin, "BEGIN");
            EnterKW(Token.Const, "CONST");
            EnterKW(Token.Elsif, "ELSIF");
            EnterKW(Token.Null, "IMPORT");
            EnterKW(Token.Null, "UNTIL");
            EnterKW(Token.While, "WHILE");
            EnterKW(Token.Record, "RECORD");
            EnterKW(Token.Null, "REPEAT");
            EnterKW(Token.Null, "RETURN");
            EnterKW(Token.Null, "POINTER");
            EnterKW(Token.Procedure, "PROCEDURE");
            EnterKW(Token.Div, "DIV");
            EnterKW(Token.Null, "LOOP");
            EnterKW(Token.Module, "MODULE");
        }

        internal Token Get()
        {
            while (!Eof() && (ch == ' ' || ch == '\n'))
            {
                ReadChar();
            }

            if (Eof())
            {
                sym = Token.Eof;
            }
            else if (ch == '&')
            {
                ReadChar();
                sym = Token.And;
            }
            else if (ch == '*')
            {
                ReadChar();
                sym = Token.Times;
            }
            else if (ch == '+')
            {
                ReadChar();
                sym = Token.Plus;
            }
            else if (ch == '-')
            {
                ReadChar();
                sym = Token.Minus;
            }
            else if (ch == '=')
            {
                ReadChar();
                sym = Token.Eql;
            }
            else if (ch == '#')
            {
                ReadChar();
                sym = Token.Neq;
            }
            else if (ch == '<')
            {
                ReadChar();
                if (ch == '=')
                {
                    ReadChar();
                    sym = Token.Leq;
                }
                else
                    sym = Token.Lss;
            }
            else if (ch == '>')
            {
                ReadChar();

                if (ch == '=')
                {
                    sym = Token.Geq;
                }
                else
                    sym = Token.Gtr;
            }
            else if (ch == ';')
            {
                ReadChar();
                sym = Token.Semicolon;
            }
            else if (ch == ',')
            {
                ReadChar();
                sym = Token.Comma;
            }
            else if (ch == ':')
            {
                ReadChar();
                if (ch == '=')
                {
                    ReadChar();
                    sym = Token.Becomes;
                }
                else
                    sym = Token.Colon;
            }
            else if (ch == '.')
            {
                ReadChar();
                sym = Token.Period;
            }
            else if (ch == '(')
            {
                ReadChar();
                if (ch == '*')
                {
                    Comment();
                    sym = Get();
                }
                else
                {
                    sym = Token.Lparen;
                }
            }
            else if (ch == ')')
            {
                ReadChar();
                sym = Token.Rparen;
            }
            else if (ch == '[')
            {
                ReadChar();
                sym = Token.Lbrak;
            }
            else if (ch == ']')
            {
                ReadChar();
                sym = Token.Rbrak;
            }
            else if (ch.IsNumeric())
            {
                Number();
            }
            else if (ch.IsAlpha())
            {
                Ident();
            }
            else if (ch == '~')
            {
                ReadChar();
                sym = Token.Not;
            }
            else
            {
                ReadChar();
                sym = Token.Null;
            }

            return sym;
        }

        private bool Eof()
        {
            return t.Position == t.Length;
        }

        internal void Comment()
        {
            ReadChar();
            while (true)
            {
                while (true)
                {
                    while (ch == '(')
                    {
                        ReadChar();
                        if (ch == '*')
                            break;
                    }
                    if (ch == '*')
                    {
                        ReadChar();
                        break;
                    }
                    if (Eof())
                        break;
                    ReadChar();
                }
                if (ch == ')')
                {
                    ReadChar();
                    break;
                }
                if (Eof())
                {
                    Mark("Comment not terminated");
                    break;
                }
            }
        }

        internal void Ident()
        {
            id = "";
            int i = 0;
            do
            {
                if (i < IdLen)
                {
                    id += ch;
                    i++;
                }
                ReadChar();
            } while (ch.IsAlphaNum());
            if (keyTable.ContainsKey(id))
                sym = keyTable[id];
            else
                sym = Token.Ident;
        }

        internal void Number()
        {
            sym = Token.Number;
            val = 0;
            do
            {
                val *= 10;
                val += Int32.Parse(ch.ToString());
                ReadChar();
            } while (ch.IsNumeric());
        }

        private void ReadChar()
        {
            int readByte = t.ReadByte();
            ch = (char)readByte;
        }

        private const int IdLen = 16;
        internal string id;
        public bool Error;
    }

    public static class CharHelpers
    {
        static readonly Regex numRegex = new Regex("[0-9]", RegexOptions.Compiled);
        static readonly Regex alphaRegex = new Regex("[A-Z]", RegexOptions.Compiled);
        static readonly Regex alphaNumRegex = new Regex("[A-Z0-9a-z]", RegexOptions.Compiled);

        public static bool IsNumeric(this char c)
        {
            Match match =
                numRegex.Match(c.ToString());
            return (match.Success);
        }

        public static bool IsAlpha(this char c)
        {
            return (alphaRegex.Match(c.ToString()).Success);
        }

        public static bool IsAlphaNum(this char c)
        {
            return (alphaNumRegex.Match(c.ToString()).Success);
        }
    }
}
