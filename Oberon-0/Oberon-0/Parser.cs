using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.IO;

namespace Oberon_0
{
    class Parser
    {
        private Token sym;
        private Scanner scanner;
        private Generator generator;

        public void Compile(Stream input)
        {
            var keyTab = new KeyTable();
            scanner = new Scanner(input, keyTab);
            NextToken();
            Module();
        }

        public void Module()
        {
            int varSize;
            string modId = string.Empty;
            Debug.WriteLine(" compiling ");

            if (sym == Token.Module)
            {
                NextToken(); 
                generator = new Generator();
                generator.Open();
                OpenScope();
                varSize = 0;
                if(sym == Token.Ident)
                {
                    modId = scanner.id;
                    NextToken();
                }
                else
                {
                    scanner.Mark("ident?");
                }

                if (sym == Token.Semicolon)
                    NextToken();
                else
                    scanner.Mark(";?");

                Declarations(varSize);

                while(sym == Token.Procedure)
                {
                    ProcedureDecl();
                    if (sym == Token.Semicolon)
                    {
                        NextToken();
                    }
                    else
                        scanner.Mark(";?");
                }

                generator.Header(varSize);

                if (sym == Token.Begin)
                {
                    NextToken();
                    StatSequence();
                }

                if(sym == Token.End)
                {
                    NextToken();
                }
                else
                    scanner.Mark("END?");

                if (sym == Token.Ident)
                {
                    if (modId != scanner.id)
                    {
                        scanner.Mark("no match");
                    }
                    NextToken();
                }
                else
                    scanner.Mark("ident?");

                if(sym != Token.Period)
                    scanner.Mark(".?");

                if(!scanner.Error)
                {
                    Debug.WriteLine("code generated");
                }
                CloseScope();
            }
            else
            {
                scanner.Mark("MODULE?");
            }
        }

        private void CloseScope()
        {
            /* TODO: implement */
        }

        private void StatSequence()
        {
            /* TODO: implement */
        }

        private void ProcedureDecl()
        {
            /* TODO: implement */
        }

        private void Declarations(int varSize)
        {
            /* TODO: implement */
        }

        private void NextToken()
        {
            sym = scanner.Get();
        }

        private void OpenScope()
        {
            /* TODO: implement */
        }
    }
}
