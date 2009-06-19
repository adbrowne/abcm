// $ANTLR 3.1.2 C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g 2009-06-19 17:41:42

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

    public const int ALPHA_NUM = 26;
    public const int MULT_OP = 21;
    public const int CLASS = 6;
    public const int T__29 = 29;
    public const int T__28 = 28;
    public const int DIV_OP = 22;
    public const int ARITH_OP = 20;
    public const int REM_OP = 23;
    public const int INT = 16;
    public const int EQUALS = 9;
    public const int BOOL_LITERAL = 19;
    public const int ID = 7;
    public const int EOF = -1;
    public const int LBRAC = 12;
    public const int ALPHA = 25;
    public const int IF = 11;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int WS = 27;
    public const int STRING_LITERAL = 17;
    public const int CHAR_LITERAL = 18;
    public const int REL_OP = 14;
    public const int RBRAC = 13;
    public const int EOS = 8;
    public const int RETURN = 10;
    public const int MINUS_OP = 15;
    public const int CALL = 5;
    public const int METHOD = 4;
    public const int CALLOUT = 24;

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
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_28 = new RewriteRuleTokenStream(adaptor,"token 28");
        RewriteRuleTokenStream stream_29 = new RewriteRuleTokenStream(adaptor,"token 29");
        RewriteRuleSubtreeStream stream_method = new RewriteRuleSubtreeStream(adaptor,"rule method");
        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:23:5: ( 'public' CLASS ID '{' ( method )* '}' -> ^( CLASS ID ( method )* ) )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:23:7: 'public' CLASS ID '{' ( method )* '}'
            {
            	string_literal1=(IToken)Match(input,28,FOLLOW_28_in_prog78);  
            	stream_28.Add(string_literal1);

            	CLASS2=(IToken)Match(input,CLASS,FOLLOW_CLASS_in_prog80);  
            	stream_CLASS.Add(CLASS2);

            	ID3=(IToken)Match(input,ID,FOLLOW_ID_in_prog82);  
            	stream_ID.Add(ID3);

            	char_literal4=(IToken)Match(input,29,FOLLOW_29_in_prog84);  
            	stream_29.Add(char_literal4);

            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:23:29: ( method )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == 28) )
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

            	char_literal6=(IToken)Match(input,30,FOLLOW_30_in_prog89);  
            	stream_30.Add(char_literal6);



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
        RewriteRuleTokenStream stream_31 = new RewriteRuleTokenStream(adaptor,"token 31");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_28 = new RewriteRuleTokenStream(adaptor,"token 28");
        RewriteRuleTokenStream stream_29 = new RewriteRuleTokenStream(adaptor,"token 29");
        RewriteRuleSubtreeStream stream_stat = new RewriteRuleSubtreeStream(adaptor,"rule stat");
        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:26:8: ( 'public' t= ID name= ID '()' '{' ( stat )* '}' -> ^( METHOD $t $name ( stat )* ) )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:26:10: 'public' t= ID name= ID '()' '{' ( stat )* '}'
            {
            	string_literal7=(IToken)Match(input,28,FOLLOW_28_in_method113);  
            	stream_28.Add(string_literal7);

            	t=(IToken)Match(input,ID,FOLLOW_ID_in_method117);  
            	stream_ID.Add(t);

            	name=(IToken)Match(input,ID,FOLLOW_ID_in_method121);  
            	stream_ID.Add(name);

            	string_literal8=(IToken)Match(input,31,FOLLOW_31_in_method123);  
            	stream_31.Add(string_literal8);

            	char_literal9=(IToken)Match(input,29,FOLLOW_29_in_method125);  
            	stream_29.Add(char_literal9);

            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:26:41: ( stat )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == ID || (LA2_0 >= RETURN && LA2_0 <= LBRAC) || (LA2_0 >= MINUS_OP && LA2_0 <= BOOL_LITERAL)) )
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

            	char_literal11=(IToken)Match(input,30,FOLLOW_30_in_method130);  
            	stream_30.Add(char_literal11);



            	// AST REWRITE
            	// elements:          stat, name, t
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
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:28:1: stat : ( expr EOS -> expr | t= ID name= ID EQUALS expr EOS -> ^( EQUALS ^( $t $name) expr ) | name= ID EQUALS expr EOS -> ^( EQUALS $name expr ) | RETURN expr EOS -> ^( RETURN expr ) | IF LBRAC expr RBRAC '{' ( stat )* '}' -> ^( IF expr ( stat )* ) );
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
        CFlatParser.expr_return expr12 = default(CFlatParser.expr_return);

        CFlatParser.expr_return expr15 = default(CFlatParser.expr_return);

        CFlatParser.expr_return expr18 = default(CFlatParser.expr_return);

        CFlatParser.expr_return expr21 = default(CFlatParser.expr_return);

        CFlatParser.expr_return expr25 = default(CFlatParser.expr_return);

        CFlatParser.stat_return stat28 = default(CFlatParser.stat_return);


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
        RewriteRuleTokenStream stream_30 = new RewriteRuleTokenStream(adaptor,"token 30");
        RewriteRuleTokenStream stream_EQUALS = new RewriteRuleTokenStream(adaptor,"token EQUALS");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_RBRAC = new RewriteRuleTokenStream(adaptor,"token RBRAC");
        RewriteRuleTokenStream stream_LBRAC = new RewriteRuleTokenStream(adaptor,"token LBRAC");
        RewriteRuleTokenStream stream_IF = new RewriteRuleTokenStream(adaptor,"token IF");
        RewriteRuleTokenStream stream_29 = new RewriteRuleTokenStream(adaptor,"token 29");
        RewriteRuleTokenStream stream_RETURN = new RewriteRuleTokenStream(adaptor,"token RETURN");
        RewriteRuleTokenStream stream_EOS = new RewriteRuleTokenStream(adaptor,"token EOS");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        RewriteRuleSubtreeStream stream_stat = new RewriteRuleSubtreeStream(adaptor,"rule stat");
        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:28:5: ( expr EOS -> expr | t= ID name= ID EQUALS expr EOS -> ^( EQUALS ^( $t $name) expr ) | name= ID EQUALS expr EOS -> ^( EQUALS $name expr ) | RETURN expr EOS -> ^( RETURN expr ) | IF LBRAC expr RBRAC '{' ( stat )* '}' -> ^( IF expr ( stat )* ) )
            int alt4 = 5;
            switch ( input.LA(1) ) 
            {
            case LBRAC:
            case MINUS_OP:
            case INT:
            case STRING_LITERAL:
            case CHAR_LITERAL:
            case BOOL_LITERAL:
            	{
                alt4 = 1;
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
                case 31:
                	{
                    alt4 = 1;
                    }
                    break;
                case ID:
                	{
                    alt4 = 2;
                    }
                    break;
                case EQUALS:
                	{
                    alt4 = 3;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d4s2 =
                	        new NoViableAltException("", 4, 2, input);

                	    throw nvae_d4s2;
                }

                }
                break;
            case RETURN:
            	{
                alt4 = 4;
                }
                break;
            case IF:
            	{
                alt4 = 5;
                }
                break;
            	default:
            	    NoViableAltException nvae_d4s0 =
            	        new NoViableAltException("", 4, 0, input);

            	    throw nvae_d4s0;
            }

            switch (alt4) 
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
                    	// elements:          expr, name, t, EQUALS
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
                    	// elements:          name, expr, EQUALS
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
                    	// elements:          RETURN, expr
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

                    	char_literal27=(IToken)Match(input,29,FOLLOW_29_in_stat250);  
                    	stream_29.Add(char_literal27);

                    	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:36:26: ( stat )*
                    	do 
                    	{
                    	    int alt3 = 2;
                    	    int LA3_0 = input.LA(1);

                    	    if ( (LA3_0 == ID || (LA3_0 >= RETURN && LA3_0 <= LBRAC) || (LA3_0 >= MINUS_OP && LA3_0 <= BOOL_LITERAL)) )
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

                    	char_literal29=(IToken)Match(input,30,FOLLOW_30_in_stat255);  
                    	stream_30.Add(char_literal29);



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
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:39:1: expr : additive_expr ( REL_OP additive_expr )* ;
    public CFlatParser.expr_return expr() // throws RecognitionException [1]
    {   
        CFlatParser.expr_return retval = new CFlatParser.expr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken REL_OP31 = null;
        CFlatParser.additive_expr_return additive_expr30 = default(CFlatParser.additive_expr_return);

        CFlatParser.additive_expr_return additive_expr32 = default(CFlatParser.additive_expr_return);


        CommonTree REL_OP31_tree=null;

        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:39:6: ( additive_expr ( REL_OP additive_expr )* )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:39:8: additive_expr ( REL_OP additive_expr )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additive_expr_in_expr277);
            	additive_expr30 = additive_expr();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, additive_expr30.Tree);
            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:39:22: ( REL_OP additive_expr )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == REL_OP) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:39:23: REL_OP additive_expr
            			    {
            			    	REL_OP31=(IToken)Match(input,REL_OP,FOLLOW_REL_OP_in_expr280); 
            			    		REL_OP31_tree = (CommonTree)adaptor.Create(REL_OP31);
            			    		root_0 = (CommonTree)adaptor.BecomeRoot(REL_OP31_tree, root_0);

            			    	PushFollow(FOLLOW_additive_expr_in_expr283);
            			    	additive_expr32 = additive_expr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, additive_expr32.Tree);

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements


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
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:41:1: additive_expr : multExpr ( ( '+' | '-' ) multExpr )* ;
    public CFlatParser.additive_expr_return additive_expr() // throws RecognitionException [1]
    {   
        CFlatParser.additive_expr_return retval = new CFlatParser.additive_expr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal34 = null;
        IToken char_literal35 = null;
        CFlatParser.multExpr_return multExpr33 = default(CFlatParser.multExpr_return);

        CFlatParser.multExpr_return multExpr36 = default(CFlatParser.multExpr_return);


        CommonTree char_literal34_tree=null;
        CommonTree char_literal35_tree=null;

        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:41:14: ( multExpr ( ( '+' | '-' ) multExpr )* )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:41:18: multExpr ( ( '+' | '-' ) multExpr )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multExpr_in_additive_expr294);
            	multExpr33 = multExpr();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, multExpr33.Tree);
            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:42:1: ( ( '+' | '-' ) multExpr )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == MINUS_OP || LA7_0 == ARITH_OP) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:42:2: ( '+' | '-' ) multExpr
            			    {
            			    	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:42:2: ( '+' | '-' )
            			    	int alt6 = 2;
            			    	int LA6_0 = input.LA(1);

            			    	if ( (LA6_0 == ARITH_OP) )
            			    	{
            			    	    alt6 = 1;
            			    	}
            			    	else if ( (LA6_0 == MINUS_OP) )
            			    	{
            			    	    alt6 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d6s0 =
            			    	        new NoViableAltException("", 6, 0, input);

            			    	    throw nvae_d6s0;
            			    	}
            			    	switch (alt6) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:42:3: '+'
            			    	        {
            			    	        	char_literal34=(IToken)Match(input,ARITH_OP,FOLLOW_ARITH_OP_in_additive_expr299); 
            			    	        		char_literal34_tree = (CommonTree)adaptor.Create(char_literal34);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal34_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:42:8: '-'
            			    	        {
            			    	        	char_literal35=(IToken)Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_additive_expr302); 
            			    	        		char_literal35_tree = (CommonTree)adaptor.Create(char_literal35);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal35_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multExpr_in_additive_expr306);
            			    	multExpr36 = multExpr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, multExpr36.Tree);

            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements


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
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:45:1: multExpr : atom ( ( '*' | '/' | '%' ) atom )* ;
    public CFlatParser.multExpr_return multExpr() // throws RecognitionException [1]
    {   
        CFlatParser.multExpr_return retval = new CFlatParser.multExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set38 = null;
        CFlatParser.atom_return atom37 = default(CFlatParser.atom_return);

        CFlatParser.atom_return atom39 = default(CFlatParser.atom_return);


        CommonTree set38_tree=null;

        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:46:5: ( atom ( ( '*' | '/' | '%' ) atom )* )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:46:9: atom ( ( '*' | '/' | '%' ) atom )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_atom_in_multExpr327);
            	atom37 = atom();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, atom37.Tree);
            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:46:14: ( ( '*' | '/' | '%' ) atom )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( ((LA8_0 >= MULT_OP && LA8_0 <= REM_OP)) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:46:15: ( '*' | '/' | '%' ) atom
            			    {
            			    	set38=(IToken)input.LT(1);
            			    	set38 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= MULT_OP && input.LA(1) <= REM_OP) ) 
            			    	{
            			    	    input.Consume();
            			    	    root_0 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(set38), root_0);
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_atom_in_multExpr339);
            			    	atom39 = atom();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, atom39.Tree);

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
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:49:1: atom : ( MINUS_OP INT | INT | LBRAC expr RBRAC -> expr | STRING_LITERAL | CHAR_LITERAL | BOOL_LITERAL | ID '()' -> ^( CALL ID ) | ID );
    public CFlatParser.atom_return atom() // throws RecognitionException [1]
    {   
        CFlatParser.atom_return retval = new CFlatParser.atom_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken MINUS_OP40 = null;
        IToken INT41 = null;
        IToken INT42 = null;
        IToken LBRAC43 = null;
        IToken RBRAC45 = null;
        IToken STRING_LITERAL46 = null;
        IToken CHAR_LITERAL47 = null;
        IToken BOOL_LITERAL48 = null;
        IToken ID49 = null;
        IToken string_literal50 = null;
        IToken ID51 = null;
        CFlatParser.expr_return expr44 = default(CFlatParser.expr_return);


        CommonTree MINUS_OP40_tree=null;
        CommonTree INT41_tree=null;
        CommonTree INT42_tree=null;
        CommonTree LBRAC43_tree=null;
        CommonTree RBRAC45_tree=null;
        CommonTree STRING_LITERAL46_tree=null;
        CommonTree CHAR_LITERAL47_tree=null;
        CommonTree BOOL_LITERAL48_tree=null;
        CommonTree ID49_tree=null;
        CommonTree string_literal50_tree=null;
        CommonTree ID51_tree=null;
        RewriteRuleTokenStream stream_31 = new RewriteRuleTokenStream(adaptor,"token 31");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_RBRAC = new RewriteRuleTokenStream(adaptor,"token RBRAC");
        RewriteRuleTokenStream stream_LBRAC = new RewriteRuleTokenStream(adaptor,"token LBRAC");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:49:5: ( MINUS_OP INT | INT | LBRAC expr RBRAC -> expr | STRING_LITERAL | CHAR_LITERAL | BOOL_LITERAL | ID '()' -> ^( CALL ID ) | ID )
            int alt9 = 8;
            alt9 = dfa9.Predict(input);
            switch (alt9) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:49:9: MINUS_OP INT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	MINUS_OP40=(IToken)Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_atom355); 
                    		MINUS_OP40_tree = (CommonTree)adaptor.Create(MINUS_OP40);
                    		adaptor.AddChild(root_0, MINUS_OP40_tree);

                    	INT41=(IToken)Match(input,INT,FOLLOW_INT_in_atom357); 
                    		INT41_tree = (CommonTree)adaptor.Create(INT41);
                    		adaptor.AddChild(root_0, INT41_tree);


                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:51:2: INT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	INT42=(IToken)Match(input,INT,FOLLOW_INT_in_atom363); 
                    		INT42_tree = (CommonTree)adaptor.Create(INT42);
                    		adaptor.AddChild(root_0, INT42_tree);


                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:53:2: LBRAC expr RBRAC
                    {
                    	LBRAC43=(IToken)Match(input,LBRAC,FOLLOW_LBRAC_in_atom369);  
                    	stream_LBRAC.Add(LBRAC43);

                    	PushFollow(FOLLOW_expr_in_atom371);
                    	expr44 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr44.Tree);
                    	RBRAC45=(IToken)Match(input,RBRAC,FOLLOW_RBRAC_in_atom373);  
                    	stream_RBRAC.Add(RBRAC45);



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
                    	// 53:19: -> expr
                    	{
                    	    adaptor.AddChild(root_0, stream_expr.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 4 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:55:2: STRING_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	STRING_LITERAL46=(IToken)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_atom383); 
                    		STRING_LITERAL46_tree = (CommonTree)adaptor.Create(STRING_LITERAL46);
                    		adaptor.AddChild(root_0, STRING_LITERAL46_tree);


                    }
                    break;
                case 5 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:57:2: CHAR_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	CHAR_LITERAL47=(IToken)Match(input,CHAR_LITERAL,FOLLOW_CHAR_LITERAL_in_atom389); 
                    		CHAR_LITERAL47_tree = (CommonTree)adaptor.Create(CHAR_LITERAL47);
                    		adaptor.AddChild(root_0, CHAR_LITERAL47_tree);


                    }
                    break;
                case 6 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:59:2: BOOL_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	BOOL_LITERAL48=(IToken)Match(input,BOOL_LITERAL,FOLLOW_BOOL_LITERAL_in_atom395); 
                    		BOOL_LITERAL48_tree = (CommonTree)adaptor.Create(BOOL_LITERAL48);
                    		adaptor.AddChild(root_0, BOOL_LITERAL48_tree);


                    }
                    break;
                case 7 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:61:2: ID '()'
                    {
                    	ID49=(IToken)Match(input,ID,FOLLOW_ID_in_atom401);  
                    	stream_ID.Add(ID49);

                    	string_literal50=(IToken)Match(input,31,FOLLOW_31_in_atom403);  
                    	stream_31.Add(string_literal50);



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
                    	// 61:10: -> ^( CALL ID )
                    	{
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:61:13: ^( CALL ID )
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
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:63:2: ID
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	ID51=(IToken)Match(input,ID,FOLLOW_ID_in_atom417); 
                    		ID51_tree = (CommonTree)adaptor.Create(ID51);
                    		adaptor.AddChild(root_0, ID51_tree);


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


   	protected DFA9 dfa9;
	private void InitializeCyclicDFAs()
	{
    	this.dfa9 = new DFA9(this);
	}

    const string DFA9_eotS =
        "\x0a\uffff";
    const string DFA9_eofS =
        "\x0a\uffff";
    const string DFA9_minS =
        "\x01\x07\x06\uffff\x01\x08\x02\uffff";
    const string DFA9_maxS =
        "\x01\x13\x06\uffff\x01\x1f\x02\uffff";
    const string DFA9_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\uffff\x01\x07\x01\x08";
    const string DFA9_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA9_transitionS = {
            "\x01\x07\x04\uffff\x01\x03\x02\uffff\x01\x01\x01\x02\x01\x04"+
            "\x01\x05\x01\x06",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x09\x04\uffff\x03\x09\x04\uffff\x04\x09\x07\uffff\x01"+
            "\x08",
            "",
            ""
    };

    static readonly short[] DFA9_eot = DFA.UnpackEncodedString(DFA9_eotS);
    static readonly short[] DFA9_eof = DFA.UnpackEncodedString(DFA9_eofS);
    static readonly char[] DFA9_min = DFA.UnpackEncodedStringToUnsignedChars(DFA9_minS);
    static readonly char[] DFA9_max = DFA.UnpackEncodedStringToUnsignedChars(DFA9_maxS);
    static readonly short[] DFA9_accept = DFA.UnpackEncodedString(DFA9_acceptS);
    static readonly short[] DFA9_special = DFA.UnpackEncodedString(DFA9_specialS);
    static readonly short[][] DFA9_transition = DFA.UnpackEncodedStringArray(DFA9_transitionS);

    protected class DFA9 : DFA
    {
        public DFA9(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 9;
            this.eot = DFA9_eot;
            this.eof = DFA9_eof;
            this.min = DFA9_min;
            this.max = DFA9_max;
            this.accept = DFA9_accept;
            this.special = DFA9_special;
            this.transition = DFA9_transition;

        }

        override public string Description
        {
            get { return "49:1: atom : ( MINUS_OP INT | INT | LBRAC expr RBRAC -> expr | STRING_LITERAL | CHAR_LITERAL | BOOL_LITERAL | ID '()' -> ^( CALL ID ) | ID );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_28_in_prog78 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_CLASS_in_prog80 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_ID_in_prog82 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_prog84 = new BitSet(new ulong[]{0x0000000050000000UL});
    public static readonly BitSet FOLLOW_method_in_prog86 = new BitSet(new ulong[]{0x0000000050000000UL});
    public static readonly BitSet FOLLOW_30_in_prog89 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_28_in_method113 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_ID_in_method117 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_ID_in_method121 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_method123 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_method125 = new BitSet(new ulong[]{0x00000000400F9C80UL});
    public static readonly BitSet FOLLOW_stat_in_method127 = new BitSet(new ulong[]{0x00000000400F9C80UL});
    public static readonly BitSet FOLLOW_30_in_method130 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_stat154 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_EOS_in_stat156 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_stat167 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_ID_in_stat171 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_EQUALS_in_stat173 = new BitSet(new ulong[]{0x00000000000F9080UL});
    public static readonly BitSet FOLLOW_expr_in_stat175 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_EOS_in_stat177 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_stat201 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_EQUALS_in_stat203 = new BitSet(new ulong[]{0x00000000000F9080UL});
    public static readonly BitSet FOLLOW_expr_in_stat205 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_EOS_in_stat207 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RETURN_in_stat224 = new BitSet(new ulong[]{0x00000000000F9080UL});
    public static readonly BitSet FOLLOW_expr_in_stat226 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_EOS_in_stat228 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_stat242 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_LBRAC_in_stat244 = new BitSet(new ulong[]{0x00000000000F9080UL});
    public static readonly BitSet FOLLOW_expr_in_stat246 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RBRAC_in_stat248 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_stat250 = new BitSet(new ulong[]{0x00000000400F9C80UL});
    public static readonly BitSet FOLLOW_stat_in_stat252 = new BitSet(new ulong[]{0x00000000400F9C80UL});
    public static readonly BitSet FOLLOW_30_in_stat255 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additive_expr_in_expr277 = new BitSet(new ulong[]{0x0000000000004002UL});
    public static readonly BitSet FOLLOW_REL_OP_in_expr280 = new BitSet(new ulong[]{0x00000000000F9080UL});
    public static readonly BitSet FOLLOW_additive_expr_in_expr283 = new BitSet(new ulong[]{0x0000000000004002UL});
    public static readonly BitSet FOLLOW_multExpr_in_additive_expr294 = new BitSet(new ulong[]{0x0000000000108002UL});
    public static readonly BitSet FOLLOW_ARITH_OP_in_additive_expr299 = new BitSet(new ulong[]{0x00000000000F9080UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_additive_expr302 = new BitSet(new ulong[]{0x00000000000F9080UL});
    public static readonly BitSet FOLLOW_multExpr_in_additive_expr306 = new BitSet(new ulong[]{0x0000000000108002UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr327 = new BitSet(new ulong[]{0x0000000000E00002UL});
    public static readonly BitSet FOLLOW_set_in_multExpr330 = new BitSet(new ulong[]{0x00000000000F9080UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr339 = new BitSet(new ulong[]{0x0000000000E00002UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_atom355 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_INT_in_atom357 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_atom363 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRAC_in_atom369 = new BitSet(new ulong[]{0x00000000000F9080UL});
    public static readonly BitSet FOLLOW_expr_in_atom371 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RBRAC_in_atom373 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_atom383 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_LITERAL_in_atom389 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOL_LITERAL_in_atom395 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_atom401 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_atom403 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_atom417 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}