using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection.Emit;

namespace Oberon_0
{
    class Parser
    {
        private Token sym;
        private Scanner scanner;
        private Generator generator;
        private ObjDesc topScope = new ObjDesc();
        private ObjDesc universe = new ObjDesc();
        private readonly ObjDesc guard = new ObjDesc();
        private const long WordSize = 4;
        
        public Parser()
        {
            topScope = null;
            OpenScope();
            RegisterBuiltInProc("Write",
                (iLGen =>
                {
                    iLGen.Emit(OpCodes.Ldstr, "Test String");
                    iLGen.Emit(OpCodes.Call,
                               typeof(System.Console).GetMethod("WriteLine",
                                                                 new System.Type[] { typeof(string) }));
                }));
            //enter(GenType.Typ, 1, "Writer", TypeDesc.classType);
            universe = topScope;
        }

        private void RegisterBuiltInProc(string procName, GenIlDelegate ilDelegate)
        {
            var x = topScope;
            while (x.next != guard)
                x = x.next;

            var proc = new ObjDesc();
            proc.name = procName;
            proc.@class = GenType.Proc;
            proc.next = guard;
            proc.ILGen = ilDelegate;

            x.next = proc;
        }

        private void enter(GenType typ, int i, string name, TypeDesc type)
        {
            ObjDesc obj = new ObjDesc();
            obj.@class = typ;
            obj.val = i;
            obj.name = name;
            obj.type = type;
            obj.dsc = null;
            obj.next = topScope.next;
            topScope.next = obj;
        }

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

                generator = new Generator("output.exe");
                generator.Open(modId);
                OpenScope();
                
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
                    generator.Complete();
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
            ObjDesc obj, par;
            GenItem x;
            do
            {
                if ((int)sym < (int)Token.Ident)
                {
                    scanner.Mark("statement?");
                    while ((int)sym >= (int)Token.Ident)
                    {
                        NextToken();
                    }
                }

                if (sym == Token.Ident)
                {
                    obj = find();
                    x = generator.MakeItem(obj);
                    NextToken();

                    if (x.mode == GenType.Proc)
                    {
                        par = obj.dsc;

                        if (sym == Token.Lparen)
                        {
                            NextToken();
                            if (sym == Token.Rparen)
                            {
                                NextToken();
                            }
                            else
                            {
                                do
                                {
                                    parameter(par);
                                    if(sym == Token.Comma) NextToken();
                                    else if (sym == Token.Rparen) {
                                        NextToken();
                                        break;
                                    }
                                    else if((int) sym >= (int)Token.Semicolon) 
                                        break;
                                    else
                                    {
                                        scanner.Mark(") or ,?");
                                    }

                                } while (true);
                                // TODO: Handle parameters  
                            }
                        }
                        generator.Call(x);
                    }
                }
                else
                {
                    break;
                }

                if (sym == Token.Semicolon)
                    NextToken();
                else if ((int)sym >= (int)Token.Semicolon & (int)sym < (int)Token.If | sym >= Token.Array)
                {
                    break;
                }
                else
                {
                    scanner.Mark(";?");
                }

            } while (true);
            /* TODO: implement */
        }

        private void parameter(ObjDesc fp)
        {
            GenItem x;
            x = expression();
            if(IsParam(fp))
            {
                generator.Parameter(x, fp.type, fp.@class);
                fp = fp.next;
            }
            else
            {
                scanner.Mark("too many parameters");
            }
        }

        private bool IsParam(ObjDesc fp)
        {
            throw new NotImplementedException();
        }

        private GenItem expression()
        {
            throw new NotImplementedException();
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
                generator.IncLevel(1, procId);
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

                if (sym == Token.End)
                {
                    NextToken();
                }
                else
                {
                    scanner.Mark("END?");
                }

                if (sym == Token.Ident)
                {
                    if (procId != scanner.id)
                        scanner.Mark("no match");
                    NextToken();
                }

                generator.Return(parblksize - markSize);
                CloseScope();
                generator.IncLevel(-1, procId);
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
            ObjDesc obj;
            ObjDesc first;
            TypeDesc tp;

            if ((int)sym < (int)Token.Const & sym != Token.End)
            {
                do
                {
                    NextToken();
                } while (((int)sym < (int)Token.Const) && sym != Token.End);
            }

            do
            {
                // TODO: Const
                //if(sym == Token.Const)
                //{
                //    NextToken();
                //    while (sym == Token.Ident)
                //    {
                //        obj = NewObj(GenType.Const);
                //        NextToken();
                //        if(sym == Token.Eql)
                //        {
                //            NextToken();
                //        }
                //        else
                //        {
                //            scanner.Mark("=?");
                //        }

                //        x = Expression();
                //    }
                //}

                if (sym == Token.Var)
                {
                    NextToken();
                    while (sym == Token.Ident)
                    {
                        first = IdentList(GenType.Var);
                        tp = type();

                        obj = first;

                        while (obj != guard)
                        {
                            obj.type = tp;
                            obj.lev = generator.curlev;
                            varSize = varSize + obj.type.size;
                            obj.val = -varSize;
                            obj = obj.next;
                        }

                        if (sym == Token.Semicolon)
                        {
                            NextToken();
                        }
                        else
                        {
                            scanner.Mark(";?");
                        }
                    }

                    if ((int)sym >= (int)Token.Const & ((int)sym <= (int)Token.Var))
                    {
                        scanner.Mark("declaration?");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    // not sure about this clause
                    break;
                }

            } while (true);
        }

        private ObjDesc IdentList(GenType var)
        {
            ObjDesc first = null;
            if (sym == Token.Ident)
            {
                first = NewObj(var);

                //TODO: Multiple vars

                NextToken();
                if (sym == Token.Colon)
                {
                    NextToken();
                }
                else
                {
                    scanner.Mark(":?");
                }
            }

            return first;
        }

        private TypeDesc type()
        {
            ObjDesc obj;
            TypeDesc type = TypeDesc.intType;
            if (sym == Token.Ident)
            {
                obj = find();
                NextToken();
                if (obj.@class == GenType.Typ)
                {
                    type = obj.type;
                }
                else
                {
                    scanner.Mark("type?");
                }
            }
            return type;
        }

        private ObjDesc find()
        {
            ObjDesc x, s;
            s = topScope;
            guard.name = scanner.id;
            do
            {
                x = s.next;
                while (x.name != scanner.id)
                    x = x.next;

                if (x != guard)
                {
                    return x;
                }

                if (s == universe)
                {
                    scanner.Mark("undef");
                    return x;
                }

                s = s.dsc;
            } while (true);

        }

        private GenItem Expression()
        {
            throw new NotImplementedException();
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
