// $ANTLR 3.1.2 C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g 2009-06-19 18:23:25

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
namespace 
    CFlat

{

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;

public partial class CFlatParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"METHOD", 
		"CALL", 
		"CLASS", 
		"ID", 
		"EOS", 
		"EQUALS", 
		"RETURN", 
		"IF", 
		"LBRAC", 
		"RBRAC", 
		"WHILE", 
		"REL_OP", 
		"MINUS_OP", 
		"INT", 
		"STRING_LITERAL", 
		"CHAR_LITERAL", 
		"BOOL_LITERAL", 
		"ARITH_OP", 
		"MULT_OP", 
		"DIV_OP", 
		"REM_OP", 
		"CALLOUT", 
		"ALPHA", 
		"ALPHA_NUM", 
		"WS", 
		"'public'", 
		"'{'", 
		"'}'", 
		"'()'"
    };

    public const int ALPHA_NUM = 27;
    public const int MULT_OP = 22;
    public const int CLASS = 6;
    public const int T__29 = 29;
    public const int WHILE = 14;
    public const int DIV_OP = 23;
    public const int ARITH_OP = 21;
    public const int REM_OP = 24;
    public const int INT = 17;
    public const int EQUALS = 9;
    public const int BOOL_LITERAL = 20;
    public const int ID = 7;
    public const int EOF = -1;
    public const int LBRAC = 12;
    public const int ALPHA = 26;
    public const int IF = 11;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int WS = 28;
    public const int STRING_LITERAL = 18;
    public const int CHAR_LITERAL = 19;
    public const int REL_OP = 15;
    public const int RBRAC = 13;
    public const int EOS = 8;
    public const int RETURN = 10;
    public const int MINUS_OP = 16;
    public const int CALL = 5;
    public const int METHOD = 4;
    public const int CALLOUT = 25;

    // delegates
    // delegators



        public CFlatParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public CFlatParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return CFlatParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g"; }
    }


    public class prog_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "prog"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:23:1: prog : 'public' CLASS ID '{' ( method )* '}' -> ^( CLASS ID ( method )* ) ;
    public CFlatParser.prog_return prog() // throws RecognitionException [1]
    {   
        CFlatParser.prog_return retval = new CFlatParser.prog_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal1 = null;
        IToken CLASS2 = null;
        IToken ID3 = null;
        IToken char_literal4 = null;
        IToken char_literal6 = null;
        CFlatParser.method_return method5 = default(CFlatParser.method_return);


        CommonTree string_literal1_tree=null;
        CommonTree CLASS2_tree=null;
        CommonTree ID3_tree=null;
        CommonTree char_literal4_tree=null;
        CommonTree char_literal6_tree=null;
        RewriteRuleTokenStream stream_CLASS = new RewriteRuleTokenStream(adaptor,"token CLASS");
        RewriteRuleTokenStream stream_30 = new RewriteRuleTokenStream(adaptor,"token 30");
        RewriteRuleTokenStream stream_31 = new RewriteRuleTokenStream(adaptor,"token 31");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_29 = new RewriteRuleTokenStream(adaptor,"token 29");
        RewriteRuleSubtreeStream stream_method = new RewriteRuleSubtreeStream(adaptor,"rule method");
        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:23:5: ( 'public' CLASS ID '{' ( method )* '}' -> ^( CLASS ID ( method )* ) )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:23:7: 'public' CLASS ID '{' ( method )* '}'
            {
            	string_literal1=(IToken)Match(input,29,FOLLOW_29_in_prog78);  
            	stream_29.Add(string_literal1);

            	CLASS2=(IToken)Match(input,CLASS,FOLLOW_CLASS_in_prog80);  
            	stream_CLASS.Add(CLASS2);

            	ID3=(IToken)Match(input,ID,FOLLOW_ID_in_prog82);  
            	stream_ID.Add(ID3);

            	char_literal4=(IToken)Match(input,30,FOLLOW_30_in_prog84);  
            	stream_30.Add(char_literal4);

            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:23:29: ( method )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == 29) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:23:29: method
            			    {
            			    	PushFollow(FOLLOW_method_in_prog86);
            			    	method5 = method();
            			    	state.followingStackPointer--;

            			    	stream_method.Add(method5.Tree);

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	char_literal6=(IToken)Match(input,31,FOLLOW_31_in_prog89);  
            	stream_31.Add(char_literal6);



            	// AST REWRITE
            	// elements:          CLASS, method, ID
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 23:41: -> ^( CLASS ID ( method )* )
            	{
            	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:23:44: ^( CLASS ID ( method )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_CLASS.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_ID.NextNode());
            	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:23:55: ( method )*
            	    while ( stream_method.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_method.NextTree());

            	    }
            	    stream_method.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "prog"

    public class method_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "method"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:26:1: method : 'public' t= ID name= ID '()' '{' ( stat )* '}' -> ^( METHOD $t $name ( stat )* ) ;
    public CFlatParser.method_return method() // throws RecognitionException [1]
    {   
        CFlatParser.method_return retval = new CFlatParser.method_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken t = null;
        IToken name = null;
        IToken string_literal7 = null;
        IToken string_literal8 = null;
        IToken char_literal9 = null;
        IToken char_literal11 = null;
        CFlatParser.stat_return stat10 = default(CFlatParser.stat_return);


        CommonTree t_tree=null;
        CommonTree name_tree=null;
        CommonTree string_literal7_tree=null;
        CommonTree string_literal8_tree=null;
        CommonTree char_literal9_tree=null;
        CommonTree char_literal11_tree=null;
        RewriteRuleTokenStream stream_30 = new RewriteRuleTokenStream(adaptor,"token 30");
        RewriteRuleTokenStream stream_32 = new RewriteRuleTokenStream(adaptor,"token 32");
        RewriteRuleTokenStream stream_31 = new RewriteRuleTokenStream(adaptor,"token 31");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_29 = new RewriteRuleTokenStream(adaptor,"token 29");
        RewriteRuleSubtreeStream stream_stat = new RewriteRuleSubtreeStream(adaptor,"rule stat");
        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:26:8: ( 'public' t= ID name= ID '()' '{' ( stat )* '}' -> ^( METHOD $t $name ( stat )* ) )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:26:10: 'public' t= ID name= ID '()' '{' ( stat )* '}'
            {
            	string_literal7=(IToken)Match(input,29,FOLLOW_29_in_method113);  
            	stream_29.Add(string_literal7);

            	t=(IToken)Match(input,ID,FOLLOW_ID_in_method117);  
            	stream_ID.Add(t);

            	name=(IToken)Match(input,ID,FOLLOW_ID_in_method121);  
            	stream_ID.Add(name);

            	string_literal8=(IToken)Match(input,32,FOLLOW_32_in_method123);  
            	stream_32.Add(string_literal8);

            	char_literal9=(IToken)Match(input,30,FOLLOW_30_in_method125);  
            	stream_30.Add(char_literal9);

            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:26:41: ( stat )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == ID || (LA2_0 >= RETURN && LA2_0 <= LBRAC) || LA2_0 == WHILE || (LA2_0 >= MINUS_OP && LA2_0 <= BOOL_LITERAL)) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:26:41: stat
            			    {
            			    	PushFollow(FOLLOW_stat_in_method127);
            			    	stat10 = stat();
            			    	state.followingStackPointer--;

            			    	stream_stat.Add(stat10.Tree);

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements

            	char_literal11=(IToken)Match(input,31,FOLLOW_31_in_method130);  
            	stream_31.Add(char_literal11);



            	// AST REWRITE
            	// elements:          t, stat, name
            	// token labels:      t, name
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleTokenStream stream_t = new RewriteRuleTokenStream(adaptor, "token t", t);
            	RewriteRuleTokenStream stream_name = new RewriteRuleTokenStream(adaptor, "token name", name);
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 26:51: -> ^( METHOD $t $name ( stat )* )
            	{
            	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:26:54: ^( METHOD $t $name ( stat )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(METHOD, "METHOD"), root_1);

            	    adaptor.AddChild(root_1, stream_t.NextNode());
            	    adaptor.AddChild(root_1, stream_name.NextNode());
            	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:26:72: ( stat )*
            	    while ( stream_stat.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_stat.NextTree());

            	    }
            	    stream_stat.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "method"

    public class stat_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "stat"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:28:1: stat : ( expr EOS -> expr | t= ID name= ID EQUALS expr EOS -> ^( EQUALS ^( $t $name) expr ) | name= ID EQUALS expr EOS -> ^( EQUALS $name expr ) | RETURN expr EOS -> ^( RETURN expr ) | IF LBRAC expr RBRAC '{' ( stat )* '}' -> ^( IF expr ( stat )* ) | WHILE LBRAC expr RBRAC '{' ( stat )* '}' -> ^( WHILE expr ( stat )* ) );
    public CFlatParser.stat_return stat() // throws RecognitionException [1]
    {   
        CFlatParser.stat_return retval = new CFlatParser.stat_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken t = null;
        IToken name = null;
        IToken EOS13 = null;
        IToken EQUALS14 = null;
        IToken EOS16 = null;
        IToken EQUALS17 = null;
        IToken EOS19 = null;
        IToken RETURN20 = null;
        IToken EOS22 = null;
        IToken IF23 = null;
        IToken LBRAC24 = null;
        IToken RBRAC26 = null;
        IToken char_literal27 = null;
        IToken char_literal29 = null;
        IToken WHILE30 = null;
        IToken LBRAC31 = null;
        IToken RBRAC33 = null;
        IToken char_literal34 = null;
        IToken char_literal36 = null;
        CFlatParser.expr_return expr12 = default(CFlatParser.expr_return);

        CFlatParser.expr_return expr15 = default(CFlatParser.expr_return);

        CFlatParser.expr_return expr18 = default(CFlatParser.expr_return);

        CFlatParser.expr_return expr21 = default(CFlatParser.expr_return);

        CFlatParser.expr_return expr25 = default(CFlatParser.expr_return);

        CFlatParser.stat_return stat28 = default(CFlatParser.stat_return);

        CFlatParser.expr_return expr32 = default(CFlatParser.expr_return);

        CFlatParser.stat_return stat35 = default(CFlatParser.stat_return);


        CommonTree t_tree=null;
        CommonTree name_tree=null;
        CommonTree EOS13_tree=null;
        CommonTree EQUALS14_tree=null;
        CommonTree EOS16_tree=null;
        CommonTree EQUALS17_tree=null;
        CommonTree EOS19_tree=null;
        CommonTree RETURN20_tree=null;
        CommonTree EOS22_tree=null;
        CommonTree IF23_tree=null;
        CommonTree LBRAC24_tree=null;
        CommonTree RBRAC26_tree=null;
        CommonTree char_literal27_tree=null;
        CommonTree char_literal29_tree=null;
        CommonTree WHILE30_tree=null;
        CommonTree LBRAC31_tree=null;
        CommonTree RBRAC33_tree=null;
        CommonTree char_literal34_tree=null;
        CommonTree char_literal36_tree=null;
        RewriteRuleTokenStream stream_30 = new RewriteRuleTokenStream(adaptor,"token 30");
        RewriteRuleTokenStream stream_EQUALS = new RewriteRuleTokenStream(adaptor,"token EQUALS");
        RewriteRuleTokenStream stream_WHILE = new RewriteRuleTokenStream(adaptor,"token WHILE");
        RewriteRuleTokenStream stream_31 = new RewriteRuleTokenStream(adaptor,"token 31");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_RBRAC = new RewriteRuleTokenStream(adaptor,"token RBRAC");
        RewriteRuleTokenStream stream_LBRAC = new RewriteRuleTokenStream(adaptor,"token LBRAC");
        RewriteRuleTokenStream stream_IF = new RewriteRuleTokenStream(adaptor,"token IF");
        RewriteRuleTokenStream stream_RETURN = new RewriteRuleTokenStream(adaptor,"token RETURN");
        RewriteRuleTokenStream stream_EOS = new RewriteRuleTokenStream(adaptor,"token EOS");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        RewriteRuleSubtreeStream stream_stat = new RewriteRuleSubtreeStream(adaptor,"rule stat");
        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:28:5: ( expr EOS -> expr | t= ID name= ID EQUALS expr EOS -> ^( EQUALS ^( $t $name) expr ) | name= ID EQUALS expr EOS -> ^( EQUALS $name expr ) | RETURN expr EOS -> ^( RETURN expr ) | IF LBRAC expr RBRAC '{' ( stat )* '}' -> ^( IF expr ( stat )* ) | WHILE LBRAC expr RBRAC '{' ( stat )* '}' -> ^( WHILE expr ( stat )* ) )
            int alt5 = 6;
            switch ( input.LA(1) ) 
            {
            case LBRAC:
            case MINUS_OP:
            case INT:
            case STRING_LITERAL:
            case CHAR_LITERAL:
            case BOOL_LITERAL:
            	{
                alt5 = 1;
                }
                break;
            case ID:
            	{
                switch ( input.LA(2) ) 
                {
                case EOS:
                case REL_OP:
                case MINUS_OP:
                case ARITH_OP:
                case MULT_OP:
                case DIV_OP:
                case REM_OP:
                case 32:
                	{
                    alt5 = 1;
                    }
                    break;
                case ID:
                	{
                    alt5 = 2;
                    }
                    break;
                case EQUALS:
                	{
                    alt5 = 3;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d5s2 =
                	        new NoViableAltException("", 5, 2, input);

                	    throw nvae_d5s2;
                }

                }
                break;
            case RETURN:
            	{
                alt5 = 4;
                }
                break;
            case IF:
            	{
                alt5 = 5;
                }
                break;
            case WHILE:
            	{
                alt5 = 6;
                }
                break;
            	default:
            	    NoViableAltException nvae_d5s0 =
            	        new NoViableAltException("", 5, 0, input);

            	    throw nvae_d5s0;
            }

            switch (alt5) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:28:9: expr EOS
                    {
                    	PushFollow(FOLLOW_expr_in_stat154);
                    	expr12 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr12.Tree);
                    	EOS13=(IToken)Match(input,EOS,FOLLOW_EOS_in_stat156);  
                    	stream_EOS.Add(EOS13);



                    	// AST REWRITE
                    	// elements:          expr
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 28:17: -> expr
                    	{
                    	    adaptor.AddChild(root_0, stream_expr.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:30:2: t= ID name= ID EQUALS expr EOS
                    {
                    	t=(IToken)Match(input,ID,FOLLOW_ID_in_stat167);  
                    	stream_ID.Add(t);

                    	name=(IToken)Match(input,ID,FOLLOW_ID_in_stat171);  
                    	stream_ID.Add(name);

                    	EQUALS14=(IToken)Match(input,EQUALS,FOLLOW_EQUALS_in_stat173);  
                    	stream_EQUALS.Add(EQUALS14);

                    	PushFollow(FOLLOW_expr_in_stat175);
                    	expr15 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr15.Tree);
                    	EOS16=(IToken)Match(input,EOS,FOLLOW_EOS_in_stat177);  
                    	stream_EOS.Add(EOS16);



                    	// AST REWRITE
                    	// elements:          name, expr, EQUALS, t
                    	// token labels:      t, name
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleTokenStream stream_t = new RewriteRuleTokenStream(adaptor, "token t", t);
                    	RewriteRuleTokenStream stream_name = new RewriteRuleTokenStream(adaptor, "token name", name);
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 30:31: -> ^( EQUALS ^( $t $name) expr )
                    	{
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:30:34: ^( EQUALS ^( $t $name) expr )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_EQUALS.NextNode(), root_1);

                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:30:43: ^( $t $name)
                    	    {
                    	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
                    	    root_2 = (CommonTree)adaptor.BecomeRoot(stream_t.NextNode(), root_2);

                    	    adaptor.AddChild(root_2, stream_name.NextNode());

                    	    adaptor.AddChild(root_1, root_2);
                    	    }
                    	    adaptor.AddChild(root_1, stream_expr.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:32:2: name= ID EQUALS expr EOS
                    {
                    	name=(IToken)Match(input,ID,FOLLOW_ID_in_stat201);  
                    	stream_ID.Add(name);

                    	EQUALS17=(IToken)Match(input,EQUALS,FOLLOW_EQUALS_in_stat203);  
                    	stream_EQUALS.Add(EQUALS17);

                    	PushFollow(FOLLOW_expr_in_stat205);
                    	expr18 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr18.Tree);
                    	EOS19=(IToken)Match(input,EOS,FOLLOW_EOS_in_stat207);  
                    	stream_EOS.Add(EOS19);



                    	// AST REWRITE
                    	// elements:          EQUALS, expr, name
                    	// token labels:      name
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleTokenStream stream_name = new RewriteRuleTokenStream(adaptor, "token name", name);
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 32:26: -> ^( EQUALS $name expr )
                    	{
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:32:29: ^( EQUALS $name expr )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_EQUALS.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_name.NextNode());
                    	    adaptor.AddChild(root_1, stream_expr.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 4 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:34:2: RETURN expr EOS
                    {
                    	RETURN20=(IToken)Match(input,RETURN,FOLLOW_RETURN_in_stat224);  
                    	stream_RETURN.Add(RETURN20);

                    	PushFollow(FOLLOW_expr_in_stat226);
                    	expr21 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr21.Tree);
                    	EOS22=(IToken)Match(input,EOS,FOLLOW_EOS_in_stat228);  
                    	stream_EOS.Add(EOS22);



                    	// AST REWRITE
                    	// elements:          expr, RETURN
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 34:18: -> ^( RETURN expr )
                    	{
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:34:21: ^( RETURN expr )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_RETURN.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_expr.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 5 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:36:2: IF LBRAC expr RBRAC '{' ( stat )* '}'
                    {
                    	IF23=(IToken)Match(input,IF,FOLLOW_IF_in_stat242);  
                    	stream_IF.Add(IF23);

                    	LBRAC24=(IToken)Match(input,LBRAC,FOLLOW_LBRAC_in_stat244);  
                    	stream_LBRAC.Add(LBRAC24);

                    	PushFollow(FOLLOW_expr_in_stat246);
                    	expr25 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr25.Tree);
                    	RBRAC26=(IToken)Match(input,RBRAC,FOLLOW_RBRAC_in_stat248);  
                    	stream_RBRAC.Add(RBRAC26);

                    	char_literal27=(IToken)Match(input,30,FOLLOW_30_in_stat250);  
                    	stream_30.Add(char_literal27);

                    	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:36:26: ( stat )*
                    	do 
                    	{
                    	    int alt3 = 2;
                    	    int LA3_0 = input.LA(1);

                    	    if ( (LA3_0 == ID || (LA3_0 >= RETURN && LA3_0 <= LBRAC) || LA3_0 == WHILE || (LA3_0 >= MINUS_OP && LA3_0 <= BOOL_LITERAL)) )
                    	    {
                    	        alt3 = 1;
                    	    }


                    	    switch (alt3) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:36:26: stat
                    			    {
                    			    	PushFollow(FOLLOW_stat_in_stat252);
                    			    	stat28 = stat();
                    			    	state.followingStackPointer--;

                    			    	stream_stat.Add(stat28.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop3;
                    	    }
                    	} while (true);

                    	loop3:
                    		;	// Stops C# compiler whining that label 'loop3' has no statements

                    	char_literal29=(IToken)Match(input,31,FOLLOW_31_in_stat255);  
                    	stream_31.Add(char_literal29);



                    	// AST REWRITE
                    	// elements:          expr, IF, stat
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 36:36: -> ^( IF expr ( stat )* )
                    	{
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:36:39: ^( IF expr ( stat )* )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_IF.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_expr.NextTree());
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:36:49: ( stat )*
                    	    while ( stream_stat.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_stat.NextTree());

                    	    }
                    	    stream_stat.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 6 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:38:2: WHILE LBRAC expr RBRAC '{' ( stat )* '}'
                    {
                    	WHILE30=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_stat272);  
                    	stream_WHILE.Add(WHILE30);

                    	LBRAC31=(IToken)Match(input,LBRAC,FOLLOW_LBRAC_in_stat274);  
                    	stream_LBRAC.Add(LBRAC31);

                    	PushFollow(FOLLOW_expr_in_stat276);
                    	expr32 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr32.Tree);
                    	RBRAC33=(IToken)Match(input,RBRAC,FOLLOW_RBRAC_in_stat278);  
                    	stream_RBRAC.Add(RBRAC33);

                    	char_literal34=(IToken)Match(input,30,FOLLOW_30_in_stat280);  
                    	stream_30.Add(char_literal34);

                    	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:38:29: ( stat )*
                    	do 
                    	{
                    	    int alt4 = 2;
                    	    int LA4_0 = input.LA(1);

                    	    if ( (LA4_0 == ID || (LA4_0 >= RETURN && LA4_0 <= LBRAC) || LA4_0 == WHILE || (LA4_0 >= MINUS_OP && LA4_0 <= BOOL_LITERAL)) )
                    	    {
                    	        alt4 = 1;
                    	    }


                    	    switch (alt4) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:38:29: stat
                    			    {
                    			    	PushFollow(FOLLOW_stat_in_stat282);
                    			    	stat35 = stat();
                    			    	state.followingStackPointer--;

                    			    	stream_stat.Add(stat35.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop4;
                    	    }
                    	} while (true);

                    	loop4:
                    		;	// Stops C# compiler whining that label 'loop4' has no statements

                    	char_literal36=(IToken)Match(input,31,FOLLOW_31_in_stat285);  
                    	stream_31.Add(char_literal36);



                    	// AST REWRITE
                    	// elements:          stat, expr, WHILE
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 38:39: -> ^( WHILE expr ( stat )* )
                    	{
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:38:42: ^( WHILE expr ( stat )* )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_WHILE.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_expr.NextTree());
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:38:55: ( stat )*
                    	    while ( stream_stat.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_stat.NextTree());

                    	    }
                    	    stream_stat.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "stat"

    public class expr_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "expr"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:41:1: expr : additive_expr ( REL_OP additive_expr )* ;
    public CFlatParser.expr_return expr() // throws RecognitionException [1]
    {   
        CFlatParser.expr_return retval = new CFlatParser.expr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken REL_OP38 = null;
        CFlatParser.additive_expr_return additive_expr37 = default(CFlatParser.additive_expr_return);

        CFlatParser.additive_expr_return additive_expr39 = default(CFlatParser.additive_expr_return);


        CommonTree REL_OP38_tree=null;

        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:41:6: ( additive_expr ( REL_OP additive_expr )* )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:41:8: additive_expr ( REL_OP additive_expr )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additive_expr_in_expr307);
            	additive_expr37 = additive_expr();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, additive_expr37.Tree);
            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:41:22: ( REL_OP additive_expr )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( (LA6_0 == REL_OP) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:41:23: REL_OP additive_expr
            			    {
            			    	REL_OP38=(IToken)Match(input,REL_OP,FOLLOW_REL_OP_in_expr310); 
            			    		REL_OP38_tree = (CommonTree)adaptor.Create(REL_OP38);
            			    		root_0 = (CommonTree)adaptor.BecomeRoot(REL_OP38_tree, root_0);

            			    	PushFollow(FOLLOW_additive_expr_in_expr313);
            			    	additive_expr39 = additive_expr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, additive_expr39.Tree);

            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expr"

    public class additive_expr_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "additive_expr"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:43:1: additive_expr : multExpr ( ( '+' | '-' ) multExpr )* ;
    public CFlatParser.additive_expr_return additive_expr() // throws RecognitionException [1]
    {   
        CFlatParser.additive_expr_return retval = new CFlatParser.additive_expr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal41 = null;
        IToken char_literal42 = null;
        CFlatParser.multExpr_return multExpr40 = default(CFlatParser.multExpr_return);

        CFlatParser.multExpr_return multExpr43 = default(CFlatParser.multExpr_return);


        CommonTree char_literal41_tree=null;
        CommonTree char_literal42_tree=null;

        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:43:14: ( multExpr ( ( '+' | '-' ) multExpr )* )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:43:18: multExpr ( ( '+' | '-' ) multExpr )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multExpr_in_additive_expr324);
            	multExpr40 = multExpr();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, multExpr40.Tree);
            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:44:1: ( ( '+' | '-' ) multExpr )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == MINUS_OP || LA8_0 == ARITH_OP) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:44:2: ( '+' | '-' ) multExpr
            			    {
            			    	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:44:2: ( '+' | '-' )
            			    	int alt7 = 2;
            			    	int LA7_0 = input.LA(1);

            			    	if ( (LA7_0 == ARITH_OP) )
            			    	{
            			    	    alt7 = 1;
            			    	}
            			    	else if ( (LA7_0 == MINUS_OP) )
            			    	{
            			    	    alt7 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d7s0 =
            			    	        new NoViableAltException("", 7, 0, input);

            			    	    throw nvae_d7s0;
            			    	}
            			    	switch (alt7) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:44:3: '+'
            			    	        {
            			    	        	char_literal41=(IToken)Match(input,ARITH_OP,FOLLOW_ARITH_OP_in_additive_expr329); 
            			    	        		char_literal41_tree = (CommonTree)adaptor.Create(char_literal41);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal41_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:44:8: '-'
            			    	        {
            			    	        	char_literal42=(IToken)Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_additive_expr332); 
            			    	        		char_literal42_tree = (CommonTree)adaptor.Create(char_literal42);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal42_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multExpr_in_additive_expr336);
            			    	multExpr43 = multExpr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, multExpr43.Tree);

            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "additive_expr"

    public class multExpr_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "multExpr"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:47:1: multExpr : atom ( ( '*' | '/' | '%' ) atom )* ;
    public CFlatParser.multExpr_return multExpr() // throws RecognitionException [1]
    {   
        CFlatParser.multExpr_return retval = new CFlatParser.multExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set45 = null;
        CFlatParser.atom_return atom44 = default(CFlatParser.atom_return);

        CFlatParser.atom_return atom46 = default(CFlatParser.atom_return);


        CommonTree set45_tree=null;

        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:48:5: ( atom ( ( '*' | '/' | '%' ) atom )* )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:48:9: atom ( ( '*' | '/' | '%' ) atom )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_atom_in_multExpr357);
            	atom44 = atom();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, atom44.Tree);
            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:48:14: ( ( '*' | '/' | '%' ) atom )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( ((LA9_0 >= MULT_OP && LA9_0 <= REM_OP)) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:48:15: ( '*' | '/' | '%' ) atom
            			    {
            			    	set45=(IToken)input.LT(1);
            			    	set45 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= MULT_OP && input.LA(1) <= REM_OP) ) 
            			    	{
            			    	    input.Consume();
            			    	    root_0 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(set45), root_0);
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_atom_in_multExpr369);
            			    	atom46 = atom();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, atom46.Tree);

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "multExpr"

    public class atom_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "atom"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:51:1: atom : ( MINUS_OP INT | INT | LBRAC expr RBRAC -> expr | STRING_LITERAL | CHAR_LITERAL | BOOL_LITERAL | ID '()' -> ^( CALL ID ) | ID );
    public CFlatParser.atom_return atom() // throws RecognitionException [1]
    {   
        CFlatParser.atom_return retval = new CFlatParser.atom_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken MINUS_OP47 = null;
        IToken INT48 = null;
        IToken INT49 = null;
        IToken LBRAC50 = null;
        IToken RBRAC52 = null;
        IToken STRING_LITERAL53 = null;
        IToken CHAR_LITERAL54 = null;
        IToken BOOL_LITERAL55 = null;
        IToken ID56 = null;
        IToken string_literal57 = null;
        IToken ID58 = null;
        CFlatParser.expr_return expr51 = default(CFlatParser.expr_return);


        CommonTree MINUS_OP47_tree=null;
        CommonTree INT48_tree=null;
        CommonTree INT49_tree=null;
        CommonTree LBRAC50_tree=null;
        CommonTree RBRAC52_tree=null;
        CommonTree STRING_LITERAL53_tree=null;
        CommonTree CHAR_LITERAL54_tree=null;
        CommonTree BOOL_LITERAL55_tree=null;
        CommonTree ID56_tree=null;
        CommonTree string_literal57_tree=null;
        CommonTree ID58_tree=null;
        RewriteRuleTokenStream stream_32 = new RewriteRuleTokenStream(adaptor,"token 32");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_RBRAC = new RewriteRuleTokenStream(adaptor,"token RBRAC");
        RewriteRuleTokenStream stream_LBRAC = new RewriteRuleTokenStream(adaptor,"token LBRAC");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:51:5: ( MINUS_OP INT | INT | LBRAC expr RBRAC -> expr | STRING_LITERAL | CHAR_LITERAL | BOOL_LITERAL | ID '()' -> ^( CALL ID ) | ID )
            int alt10 = 8;
            alt10 = dfa10.Predict(input);
            switch (alt10) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:51:9: MINUS_OP INT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	MINUS_OP47=(IToken)Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_atom385); 
                    		MINUS_OP47_tree = (CommonTree)adaptor.Create(MINUS_OP47);
                    		adaptor.AddChild(root_0, MINUS_OP47_tree);

                    	INT48=(IToken)Match(input,INT,FOLLOW_INT_in_atom387); 
                    		INT48_tree = (CommonTree)adaptor.Create(INT48);
                    		adaptor.AddChild(root_0, INT48_tree);


                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:53:2: INT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	INT49=(IToken)Match(input,INT,FOLLOW_INT_in_atom393); 
                    		INT49_tree = (CommonTree)adaptor.Create(INT49);
                    		adaptor.AddChild(root_0, INT49_tree);


                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:55:2: LBRAC expr RBRAC
                    {
                    	LBRAC50=(IToken)Match(input,LBRAC,FOLLOW_LBRAC_in_atom399);  
                    	stream_LBRAC.Add(LBRAC50);

                    	PushFollow(FOLLOW_expr_in_atom401);
                    	expr51 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr51.Tree);
                    	RBRAC52=(IToken)Match(input,RBRAC,FOLLOW_RBRAC_in_atom403);  
                    	stream_RBRAC.Add(RBRAC52);



                    	// AST REWRITE
                    	// elements:          expr
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 55:19: -> expr
                    	{
                    	    adaptor.AddChild(root_0, stream_expr.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 4 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:57:2: STRING_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	STRING_LITERAL53=(IToken)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_atom413); 
                    		STRING_LITERAL53_tree = (CommonTree)adaptor.Create(STRING_LITERAL53);
                    		adaptor.AddChild(root_0, STRING_LITERAL53_tree);


                    }
                    break;
                case 5 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:59:2: CHAR_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	CHAR_LITERAL54=(IToken)Match(input,CHAR_LITERAL,FOLLOW_CHAR_LITERAL_in_atom419); 
                    		CHAR_LITERAL54_tree = (CommonTree)adaptor.Create(CHAR_LITERAL54);
                    		adaptor.AddChild(root_0, CHAR_LITERAL54_tree);


                    }
                    break;
                case 6 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:61:2: BOOL_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	BOOL_LITERAL55=(IToken)Match(input,BOOL_LITERAL,FOLLOW_BOOL_LITERAL_in_atom425); 
                    		BOOL_LITERAL55_tree = (CommonTree)adaptor.Create(BOOL_LITERAL55);
                    		adaptor.AddChild(root_0, BOOL_LITERAL55_tree);


                    }
                    break;
                case 7 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:63:2: ID '()'
                    {
                    	ID56=(IToken)Match(input,ID,FOLLOW_ID_in_atom431);  
                    	stream_ID.Add(ID56);

                    	string_literal57=(IToken)Match(input,32,FOLLOW_32_in_atom433);  
                    	stream_32.Add(string_literal57);



                    	// AST REWRITE
                    	// elements:          ID
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 63:10: -> ^( CALL ID )
                    	{
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:63:13: ^( CALL ID )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(CALL, "CALL"), root_1);

                    	    adaptor.AddChild(root_1, stream_ID.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 8 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:65:2: ID
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	ID58=(IToken)Match(input,ID,FOLLOW_ID_in_atom447); 
                    		ID58_tree = (CommonTree)adaptor.Create(ID58);
                    		adaptor.AddChild(root_0, ID58_tree);


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "atom"

    // Delegated rules


   	protected DFA10 dfa10;
	private void InitializeCyclicDFAs()
	{
    	this.dfa10 = new DFA10(this);
	}

    const string DFA10_eotS =
        "\x0a\uffff";
    const string DFA10_eofS =
        "\x0a\uffff";
    const string DFA10_minS =
        "\x01\x07\x06\uffff\x01\x08\x02\uffff";
    const string DFA10_maxS =
        "\x01\x14\x06\uffff\x01\x20\x02\uffff";
    const string DFA10_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\uffff\x01\x07\x01\x08";
    const string DFA10_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA10_transitionS = {
            "\x01\x07\x04\uffff\x01\x03\x03\uffff\x01\x01\x01\x02\x01\x04"+
            "\x01\x05\x01\x06",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x09\x04\uffff\x01\x09\x01\uffff\x02\x09\x04\uffff\x04"+
            "\x09\x07\uffff\x01\x08",
            "",
            ""
    };

    static readonly short[] DFA10_eot = DFA.UnpackEncodedString(DFA10_eotS);
    static readonly short[] DFA10_eof = DFA.UnpackEncodedString(DFA10_eofS);
    static readonly char[] DFA10_min = DFA.UnpackEncodedStringToUnsignedChars(DFA10_minS);
    static readonly char[] DFA10_max = DFA.UnpackEncodedStringToUnsignedChars(DFA10_maxS);
    static readonly short[] DFA10_accept = DFA.UnpackEncodedString(DFA10_acceptS);
    static readonly short[] DFA10_special = DFA.UnpackEncodedString(DFA10_specialS);
    static readonly short[][] DFA10_transition = DFA.UnpackEncodedStringArray(DFA10_transitionS);

    protected class DFA10 : DFA
    {
        public DFA10(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 10;
            this.eot = DFA10_eot;
            this.eof = DFA10_eof;
            this.min = DFA10_min;
            this.max = DFA10_max;
            this.accept = DFA10_accept;
            this.special = DFA10_special;
            this.transition = DFA10_transition;

        }

        override public string Description
        {
            get { return "51:1: atom : ( MINUS_OP INT | INT | LBRAC expr RBRAC -> expr | STRING_LITERAL | CHAR_LITERAL | BOOL_LITERAL | ID '()' -> ^( CALL ID ) | ID );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_29_in_prog78 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_CLASS_in_prog80 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_ID_in_prog82 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_prog84 = new BitSet(new ulong[]{0x00000000A0000000UL});
    public static readonly BitSet FOLLOW_method_in_prog86 = new BitSet(new ulong[]{0x00000000A0000000UL});
    public static readonly BitSet FOLLOW_31_in_prog89 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_29_in_method113 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_ID_in_method117 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_ID_in_method121 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_method123 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_method125 = new BitSet(new ulong[]{0x00000000801F5C80UL});
    public static readonly BitSet FOLLOW_stat_in_method127 = new BitSet(new ulong[]{0x00000000801F5C80UL});
    public static readonly BitSet FOLLOW_31_in_method130 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_stat154 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_EOS_in_stat156 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_stat167 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_ID_in_stat171 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_EQUALS_in_stat173 = new BitSet(new ulong[]{0x00000000001F1080UL});
    public static readonly BitSet FOLLOW_expr_in_stat175 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_EOS_in_stat177 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_stat201 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_EQUALS_in_stat203 = new BitSet(new ulong[]{0x00000000001F1080UL});
    public static readonly BitSet FOLLOW_expr_in_stat205 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_EOS_in_stat207 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RETURN_in_stat224 = new BitSet(new ulong[]{0x00000000001F1080UL});
    public static readonly BitSet FOLLOW_expr_in_stat226 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_EOS_in_stat228 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_stat242 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_LBRAC_in_stat244 = new BitSet(new ulong[]{0x00000000001F1080UL});
    public static readonly BitSet FOLLOW_expr_in_stat246 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RBRAC_in_stat248 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_stat250 = new BitSet(new ulong[]{0x00000000801F5C80UL});
    public static readonly BitSet FOLLOW_stat_in_stat252 = new BitSet(new ulong[]{0x00000000801F5C80UL});
    public static readonly BitSet FOLLOW_31_in_stat255 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHILE_in_stat272 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_LBRAC_in_stat274 = new BitSet(new ulong[]{0x00000000001F1080UL});
    public static readonly BitSet FOLLOW_expr_in_stat276 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RBRAC_in_stat278 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_stat280 = new BitSet(new ulong[]{0x00000000801F5C80UL});
    public static readonly BitSet FOLLOW_stat_in_stat282 = new BitSet(new ulong[]{0x00000000801F5C80UL});
    public static readonly BitSet FOLLOW_31_in_stat285 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additive_expr_in_expr307 = new BitSet(new ulong[]{0x0000000000008002UL});
    public static readonly BitSet FOLLOW_REL_OP_in_expr310 = new BitSet(new ulong[]{0x00000000001F1080UL});
    public static readonly BitSet FOLLOW_additive_expr_in_expr313 = new BitSet(new ulong[]{0x0000000000008002UL});
    public static readonly BitSet FOLLOW_multExpr_in_additive_expr324 = new BitSet(new ulong[]{0x0000000000210002UL});
    public static readonly BitSet FOLLOW_ARITH_OP_in_additive_expr329 = new BitSet(new ulong[]{0x00000000001F1080UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_additive_expr332 = new BitSet(new ulong[]{0x00000000001F1080UL});
    public static readonly BitSet FOLLOW_multExpr_in_additive_expr336 = new BitSet(new ulong[]{0x0000000000210002UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr357 = new BitSet(new ulong[]{0x0000000001C00002UL});
    public static readonly BitSet FOLLOW_set_in_multExpr360 = new BitSet(new ulong[]{0x00000000001F1080UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr369 = new BitSet(new ulong[]{0x0000000001C00002UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_atom385 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_INT_in_atom387 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_atom393 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRAC_in_atom399 = new BitSet(new ulong[]{0x00000000001F1080UL});
    public static readonly BitSet FOLLOW_expr_in_atom401 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RBRAC_in_atom403 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_atom413 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_LITERAL_in_atom419 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOL_LITERAL_in_atom425 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_atom431 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_atom433 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_atom447 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}