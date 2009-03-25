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
        private OsgObject topScope = new OsgObject();
        private OsgObject universe = new OsgObject();
        private readonly OsgObject guard = new OsgObject();
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
            //enter(OsgClassMode.Typ, 1, "Writer", TypeDesc.classType);
            universe = topScope;
        }

        private void RegisterBuiltInProc(string procName, GenIlDelegate ilDelegate)
        {
            var x = topScope;
            while (x.next != guard)
                x = x.next;

            var proc = new OsgObject();
            proc.name = procName;
            proc.@class = OsgClassMode.Proc;
            proc.next = guard;
            proc.ILGen = ilDelegate;

            x.next = proc;
        }

        private void enter(OsgClassMode typ, int i, string name, TypeDesc type)
        {
            OsgObject osg = new OsgObject();
            osg.@class = typ;
            osg.val = i;
            osg.name = name;
            osg.type = type;
            osg.dsc = null;
            osg.next = topScope.next;
            topScope.next = osg;
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
            OsgObject osg, par;
            OsgItem x;
            do
            {
                if (sym.Value < Token.Ident.Value)
                {
                    scanner.Mark("statement?");
                    while (sym.Value >= Token.Ident.Value)
                    {
                        NextToken();
                    }
                }

                if (sym == Token.Ident)
                {
                    osg = find();
                    x = generator.MakeItem(osg);
                    NextToken();

                    if (x.mode == OsgClassMode.Proc)
                    {
                        par = osg.dsc;

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
                                    else if((int) sym.Value >= (int)Token.Semicolon.Value) 
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
                else if (sym.Value >= Token.Semicolon.Value & sym.Value < Token.If.Value | sym.Value >= Token.Array.Value)
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

        private void parameter(OsgObject fp)
        {
            OsgItem x;
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

        private bool IsParam(OsgObject obj)
        {
            return (obj.@class == OsgClassMode.Par || (obj.@class == OsgClassMode.Var && obj.val > 0));
        }

        private OsgItem expression()
        {
            Token op;
            OsgItem y, x;
            x = SimpleExpression();
            if((int)sym.Value > (int)Token.Eql.Value && (int) sym.Value <= (int) Token.Gtr.Value)
            {
                op = sym;
                NextToken();
                y = SimpleExpression();
                generator.Relation(op, x, y);
            }

            return x;
        }

        private OsgItem SimpleExpression()
        {
            throw new NotImplementedException();
        }

        internal void factor(ref OsgItem x)
        {
            OsgObject obj;
            if (sym.Value < Token.Lparen.Value)
            {
                scanner.Mark("ident?");
                while(sym.Value < Token.Lparen.Value)
                {
                    NextToken();
                }
            }

            if(sym == Token.Ident)
            {
                obj = find();
                NextToken();
                generator.MakeItem(x, obj);
                selector(x);
            }
    }

        private void selector(OsgItem x)
        {
            
        }

        private void ProcedureDecl()
        {
            const int markSize = 8;
            Int64 parblksize, locblksize;
            string procId;
            OsgObject proc, osg;
            NextToken();
            if (sym == Token.Ident)
            {
                procId = scanner.id;
                proc = NewObj(OsgClassMode.Proc);
                NextToken();
                parblksize = markSize;
                generator.IncLevel(1, procId);
                OpenScope();
                proc.val = -1;

                if (sym == Token.Lparen)
                {
                    // TODO: handle braces
                }
                else if (generator.curlev == OsgClassMode.Var)
                {
                    generator.EnterCmd(procId);
                }

                osg = topScope.next;
                locblksize = parblksize;

                while (osg != guard)
                {
                    osg.lev = generator.curlev;
                    if (osg.@class == OsgClassMode.Par)
                    {
                        locblksize -= WordSize;
                    }
                    else
                    {
                        osg.val = locblksize;
                        osg = osg.next;
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

        private OsgObject NewObj(OsgClassMode proc)
        {
            OsgObject @new;
            OsgObject x = topScope;
            guard.name = scanner.id;

            while (x.next.name != scanner.id)
            {
                x = x.next;
            }

            if (x.next == guard)
            {
                @new = new OsgObject();
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
            OsgObject osg;
            OsgObject first;
            TypeDesc tp;

            if ((int)sym.Value < (int)Token.Const.Value & sym.Value != Token.End.Value)
            {
                do
                {
                    NextToken();
                } while (((int)sym.Value < (int)Token.Const.Value) && sym.Value != Token.End.Value);
            }

            do
            {
                // TODO: Const
                //if(sym == Token.Const)
                //{
                //    NextToken();
                //    while (sym == Token.Ident)
                //    {
                //        osg = NewObj(OsgClassMode.Const);
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
                        first = IdentList(OsgClassMode.Var);
                        tp = type();

                        osg = first;

                        while (osg != guard)
                        {
                            osg.type = tp;
                            osg.lev = generator.curlev;
                            varSize = varSize + osg.type.size;
                            osg.val = -varSize;
                            osg = osg.next;
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

                    if ((int)sym.Value >= (int)Token.Const.Value & ((int)sym.Value <= (int)Token.Var.Value))
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

        private OsgObject IdentList(OsgClassMode var)
        {
            OsgObject first = null;
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
            OsgObject osg;
            TypeDesc type = TypeDesc.intType;
            if (sym == Token.Ident)
            {
                osg = find();
                NextToken();
                if (osg.@class == OsgClassMode.Typ)
                {
                    type = osg.type;
                }
                else
                {
                    scanner.Mark("type?");
                }
            }
            return type;
        }

        private OsgObject find()
        {
            OsgObject x, s;
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

        private void NextToken()
        {
            sym = scanner.Get();
        }

        private void OpenScope()
        {
            var s = new OsgObject();
            s.@class = OsgClassMode.Head;
            s.dsc = topScope;
            s.next = guard;
            topScope = s;
        }
    }
}
