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
        private ObjDesc topScope = new ObjDesc();
        private readonly ObjDesc guard = new ObjDesc();
        private const long WordSize = 4;

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
                if (sym == Token.Ident)
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

                while (sym == Token.Procedure)
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

                if (sym == Token.End)
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

                if (sym != Token.Period)
                    scanner.Mark(".?");

                if (!scanner.Error)
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
            const int markSize = 8;
            Int64 parblksize, locblksize;
            string procId;
            ObjDesc proc, obj;
            NextToken();
            if (sym == Token.Ident)
            {
                procId = scanner.id;
                proc = NewObj(GenType.Proc);
                NextToken();
                parblksize = markSize;
                generator.IncLevel(1);
                OpenScope();
                proc.val = -1;

                if (sym == Token.Lparen)
                {
                    // TODO: handle braces
                }
                else if (generator.curlev == GenType.Var)
                {
                    generator.EnterCmd(procId);
                }

                obj = topScope.next;
                locblksize = parblksize;

                while (obj != guard)
                {
                    obj.lev = generator.curlev;
                    if (obj.@class == GenType.Par)
                    {
                        locblksize -= WordSize;
                    }
                    else
                    {
                        obj.val = locblksize;
                        obj = obj.next;
                    }
                }

                proc.dsc = topScope.next;

                if (sym == Token.Semicolon)
                    NextToken();
                else
                {
                    scanner.Mark(";?");
                }

                locblksize = 0;
                Declarations(locblksize);
                while (sym == Token.Procedure)
                {
                    ProcedureDecl();
                    if (sym == Token.Semicolon)
                    {
                        NextToken();
                    }
                    else
                    {
                        scanner.Mark(";?");
                    }
                }

                // proc.val = OSG.PC; // TODO: Work out what this means
                generator.Enter(locblksize);
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
                {
                    scanner.Mark("END?");
                }

                if(sym == Token.Ident)
                {
                    if(procId != scanner.id)
                        scanner.Mark("no match");
                    NextToken();
                }

                generator.Return(parblksize - markSize);
                CloseScope();
                generator.IncLevel(-1);
            }
        }

        private ObjDesc NewObj(GenType proc)
        {
            ObjDesc @new;
            ObjDesc x = topScope;
            guard.name = scanner.id;

            while (x.next.name != scanner.id)
            {
                x = x.next;
            }

            if (x.next == guard)
            {
                @new = new ObjDesc();
                @new.name = scanner.id;
                @new.@class = proc;
                @new.next = guard;
                x.next = @new;
                return @new;
            }
            else
            {
                scanner.Mark("mult def");
                return x.next;
            }
        }

        private void Declarations(long varSize)
        {
            /* TODO: implement */
        }

        private void NextToken()
        {
            sym = scanner.Get();
        }

        private void OpenScope()
        {
            var s = new ObjDesc();
            s.@class = GenType.Head;
            s.dsc = topScope;
            s.next = guard;
            topScope = s;
        }
    }
}
