// $ANTLR 3.1.2 C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g 2009-06-07 21:39:39

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
		"CLASS", 
		"ID", 
		"EOS", 
		"EQUALS", 
		"RETURN", 
		"MINUS_OP", 
		"INT", 
		"LBRAC", 
		"RBRAC", 
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
		"'(){'"
    };

    public const int ALPHA_NUM = 23;
    public const int MULT_OP = 18;
    public const int CLASS = 5;
    public const int T__28 = 28;
    public const int T__27 = 27;
    public const int T__26 = 26;
    public const int T__25 = 25;
    public const int DIV_OP = 19;
    public const int ARITH_OP = 17;
    public const int REM_OP = 20;
    public const int EQUALS = 8;
    public const int INT = 11;
    public const int BOOL_LITERAL = 16;
    public const int ID = 6;
    public const int EOF = -1;
    public const int LBRAC = 12;
    public const int ALPHA = 22;
    public const int WS = 24;
    public const int STRING_LITERAL = 14;
    public const int CHAR_LITERAL = 15;
    public const int RBRAC = 13;
    public const int EOS = 7;
    public const int RETURN = 9;
    public const int MINUS_OP = 10;
    public const int METHOD = 4;
    public const int CALLOUT = 21;

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
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:22:1: prog : 'public' CLASS ID '{' ( method )* '}' -> ^( CLASS ID ( method )* ) ;
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
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_25 = new RewriteRuleTokenStream(adaptor,"token 25");
        RewriteRuleTokenStream stream_26 = new RewriteRuleTokenStream(adaptor,"token 26");
        RewriteRuleTokenStream stream_27 = new RewriteRuleTokenStream(adaptor,"token 27");
        RewriteRuleSubtreeStream stream_method = new RewriteRuleSubtreeStream(adaptor,"rule method");
        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:22:5: ( 'public' CLASS ID '{' ( method )* '}' -> ^( CLASS ID ( method )* ) )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:22:7: 'public' CLASS ID '{' ( method )* '}'
            {
            	string_literal1=(IToken)Match(input,25,FOLLOW_25_in_prog71);  
            	stream_25.Add(string_literal1);

            	CLASS2=(IToken)Match(input,CLASS,FOLLOW_CLASS_in_prog73);  
            	stream_CLASS.Add(CLASS2);

            	ID3=(IToken)Match(input,ID,FOLLOW_ID_in_prog75);  
            	stream_ID.Add(ID3);

            	char_literal4=(IToken)Match(input,26,FOLLOW_26_in_prog77);  
            	stream_26.Add(char_literal4);

            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:22:29: ( method )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == 25) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:22:29: method
            			    {
            			    	PushFollow(FOLLOW_method_in_prog79);
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

            	char_literal6=(IToken)Match(input,27,FOLLOW_27_in_prog82);  
            	stream_27.Add(char_literal6);



            	// AST REWRITE
            	// elements:          method, CLASS, ID
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 22:41: -> ^( CLASS ID ( method )* )
            	{
            	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:22:44: ^( CLASS ID ( method )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_CLASS.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_ID.NextNode());
            	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:22:55: ( method )*
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
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:25:1: method : 'public' t= ID name= ID '(){' ( stat )* '}' -> ^( METHOD $t $name ( stat )* ) ;
    public CFlatParser.method_return method() // throws RecognitionException [1]
    {   
        CFlatParser.method_return retval = new CFlatParser.method_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken t = null;
        IToken name = null;
        IToken string_literal7 = null;
        IToken string_literal8 = null;
        IToken char_literal10 = null;
        CFlatParser.stat_return stat9 = default(CFlatParser.stat_return);


        CommonTree t_tree=null;
        CommonTree name_tree=null;
        CommonTree string_literal7_tree=null;
        CommonTree string_literal8_tree=null;
        CommonTree char_literal10_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_25 = new RewriteRuleTokenStream(adaptor,"token 25");
        RewriteRuleTokenStream stream_27 = new RewriteRuleTokenStream(adaptor,"token 27");
        RewriteRuleTokenStream stream_28 = new RewriteRuleTokenStream(adaptor,"token 28");
        RewriteRuleSubtreeStream stream_stat = new RewriteRuleSubtreeStream(adaptor,"rule stat");
        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:25:8: ( 'public' t= ID name= ID '(){' ( stat )* '}' -> ^( METHOD $t $name ( stat )* ) )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:25:10: 'public' t= ID name= ID '(){' ( stat )* '}'
            {
            	string_literal7=(IToken)Match(input,25,FOLLOW_25_in_method106);  
            	stream_25.Add(string_literal7);

            	t=(IToken)Match(input,ID,FOLLOW_ID_in_method110);  
            	stream_ID.Add(t);

            	name=(IToken)Match(input,ID,FOLLOW_ID_in_method114);  
            	stream_ID.Add(name);

            	string_literal8=(IToken)Match(input,28,FOLLOW_28_in_method116);  
            	stream_28.Add(string_literal8);

            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:25:38: ( stat )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == ID || (LA2_0 >= RETURN && LA2_0 <= LBRAC) || (LA2_0 >= STRING_LITERAL && LA2_0 <= BOOL_LITERAL)) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:25:38: stat
            			    {
            			    	PushFollow(FOLLOW_stat_in_method118);
            			    	stat9 = stat();
            			    	state.followingStackPointer--;

            			    	stream_stat.Add(stat9.Tree);

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements

            	char_literal10=(IToken)Match(input,27,FOLLOW_27_in_method121);  
            	stream_27.Add(char_literal10);



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
            	// 25:48: -> ^( METHOD $t $name ( stat )* )
            	{
            	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:25:51: ^( METHOD $t $name ( stat )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(METHOD, "METHOD"), root_1);

            	    adaptor.AddChild(root_1, stream_t.NextNode());
            	    adaptor.AddChild(root_1, stream_name.NextNode());
            	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:25:69: ( stat )*
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
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:27:1: stat : ( expr EOS -> expr | t= ID name= ID EQUALS expr EOS -> ^( EQUALS ^( $t $name) expr ) | RETURN expr EOS -> ^( RETURN expr ) );
    public CFlatParser.stat_return stat() // throws RecognitionException [1]
    {   
        CFlatParser.stat_return retval = new CFlatParser.stat_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken t = null;
        IToken name = null;
        IToken EOS12 = null;
        IToken EQUALS13 = null;
        IToken EOS15 = null;
        IToken RETURN16 = null;
        IToken EOS18 = null;
        CFlatParser.expr_return expr11 = default(CFlatParser.expr_return);

        CFlatParser.expr_return expr14 = default(CFlatParser.expr_return);

        CFlatParser.expr_return expr17 = default(CFlatParser.expr_return);


        CommonTree t_tree=null;
        CommonTree name_tree=null;
        CommonTree EOS12_tree=null;
        CommonTree EQUALS13_tree=null;
        CommonTree EOS15_tree=null;
        CommonTree RETURN16_tree=null;
        CommonTree EOS18_tree=null;
        RewriteRuleTokenStream stream_EQUALS = new RewriteRuleTokenStream(adaptor,"token EQUALS");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_RETURN = new RewriteRuleTokenStream(adaptor,"token RETURN");
        RewriteRuleTokenStream stream_EOS = new RewriteRuleTokenStream(adaptor,"token EOS");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:27:5: ( expr EOS -> expr | t= ID name= ID EQUALS expr EOS -> ^( EQUALS ^( $t $name) expr ) | RETURN expr EOS -> ^( RETURN expr ) )
            int alt3 = 3;
            switch ( input.LA(1) ) 
            {
            case MINUS_OP:
            case INT:
            case LBRAC:
            case STRING_LITERAL:
            case CHAR_LITERAL:
            case BOOL_LITERAL:
            	{
                alt3 = 1;
                }
                break;
            case ID:
            	{
                int LA3_2 = input.LA(2);

                if ( (LA3_2 == ID) )
                {
                    alt3 = 2;
                }
                else if ( (LA3_2 == EOS || LA3_2 == MINUS_OP || (LA3_2 >= ARITH_OP && LA3_2 <= REM_OP)) )
                {
                    alt3 = 1;
                }
                else 
                {
                    NoViableAltException nvae_d3s2 =
                        new NoViableAltException("", 3, 2, input);

                    throw nvae_d3s2;
                }
                }
                break;
            case RETURN:
            	{
                alt3 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d3s0 =
            	        new NoViableAltException("", 3, 0, input);

            	    throw nvae_d3s0;
            }

            switch (alt3) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:27:9: expr EOS
                    {
                    	PushFollow(FOLLOW_expr_in_stat145);
                    	expr11 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr11.Tree);
                    	EOS12=(IToken)Match(input,EOS,FOLLOW_EOS_in_stat147);  
                    	stream_EOS.Add(EOS12);



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
                    	// 27:17: -> expr
                    	{
                    	    adaptor.AddChild(root_0, stream_expr.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:29:2: t= ID name= ID EQUALS expr EOS
                    {
                    	t=(IToken)Match(input,ID,FOLLOW_ID_in_stat158);  
                    	stream_ID.Add(t);

                    	name=(IToken)Match(input,ID,FOLLOW_ID_in_stat162);  
                    	stream_ID.Add(name);

                    	EQUALS13=(IToken)Match(input,EQUALS,FOLLOW_EQUALS_in_stat164);  
                    	stream_EQUALS.Add(EQUALS13);

                    	PushFollow(FOLLOW_expr_in_stat166);
                    	expr14 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr14.Tree);
                    	EOS15=(IToken)Match(input,EOS,FOLLOW_EOS_in_stat168);  
                    	stream_EOS.Add(EOS15);



                    	// AST REWRITE
                    	// elements:          t, EQUALS, name, expr
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
                    	// 29:31: -> ^( EQUALS ^( $t $name) expr )
                    	{
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:29:34: ^( EQUALS ^( $t $name) expr )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_EQUALS.NextNode(), root_1);

                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:29:43: ^( $t $name)
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
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:31:2: RETURN expr EOS
                    {
                    	RETURN16=(IToken)Match(input,RETURN,FOLLOW_RETURN_in_stat190);  
                    	stream_RETURN.Add(RETURN16);

                    	PushFollow(FOLLOW_expr_in_stat192);
                    	expr17 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr17.Tree);
                    	EOS18=(IToken)Match(input,EOS,FOLLOW_EOS_in_stat194);  
                    	stream_EOS.Add(EOS18);



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
                    	// 31:18: -> ^( RETURN expr )
                    	{
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:31:21: ^( RETURN expr )
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
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:33:1: expr : multExpr ( ( '+' | '-' ) multExpr )* ;
    public CFlatParser.expr_return expr() // throws RecognitionException [1]
    {   
        CFlatParser.expr_return retval = new CFlatParser.expr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal20 = null;
        IToken char_literal21 = null;
        CFlatParser.multExpr_return multExpr19 = default(CFlatParser.multExpr_return);

        CFlatParser.multExpr_return multExpr22 = default(CFlatParser.multExpr_return);


        CommonTree char_literal20_tree=null;
        CommonTree char_literal21_tree=null;

        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:33:5: ( multExpr ( ( '+' | '-' ) multExpr )* )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:33:9: multExpr ( ( '+' | '-' ) multExpr )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multExpr_in_expr211);
            	multExpr19 = multExpr();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, multExpr19.Tree);
            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:34:1: ( ( '+' | '-' ) multExpr )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == MINUS_OP || LA5_0 == ARITH_OP) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:34:2: ( '+' | '-' ) multExpr
            			    {
            			    	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:34:2: ( '+' | '-' )
            			    	int alt4 = 2;
            			    	int LA4_0 = input.LA(1);

            			    	if ( (LA4_0 == ARITH_OP) )
            			    	{
            			    	    alt4 = 1;
            			    	}
            			    	else if ( (LA4_0 == MINUS_OP) )
            			    	{
            			    	    alt4 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d4s0 =
            			    	        new NoViableAltException("", 4, 0, input);

            			    	    throw nvae_d4s0;
            			    	}
            			    	switch (alt4) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:34:3: '+'
            			    	        {
            			    	        	char_literal20=(IToken)Match(input,ARITH_OP,FOLLOW_ARITH_OP_in_expr216); 
            			    	        		char_literal20_tree = (CommonTree)adaptor.Create(char_literal20);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal20_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:34:8: '-'
            			    	        {
            			    	        	char_literal21=(IToken)Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_expr219); 
            			    	        		char_literal21_tree = (CommonTree)adaptor.Create(char_literal21);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal21_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multExpr_in_expr223);
            			    	multExpr22 = multExpr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, multExpr22.Tree);

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
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:37:1: multExpr : atom ( ( '*' | '/' | '%' ) atom )* ;
    public CFlatParser.multExpr_return multExpr() // throws RecognitionException [1]
    {   
        CFlatParser.multExpr_return retval = new CFlatParser.multExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set24 = null;
        CFlatParser.atom_return atom23 = default(CFlatParser.atom_return);

        CFlatParser.atom_return atom25 = default(CFlatParser.atom_return);


        CommonTree set24_tree=null;

        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:38:5: ( atom ( ( '*' | '/' | '%' ) atom )* )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:38:9: atom ( ( '*' | '/' | '%' ) atom )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_atom_in_multExpr244);
            	atom23 = atom();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, atom23.Tree);
            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:38:14: ( ( '*' | '/' | '%' ) atom )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= MULT_OP && LA6_0 <= REM_OP)) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:38:15: ( '*' | '/' | '%' ) atom
            			    {
            			    	set24=(IToken)input.LT(1);
            			    	set24 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= MULT_OP && input.LA(1) <= REM_OP) ) 
            			    	{
            			    	    input.Consume();
            			    	    root_0 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(set24), root_0);
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_atom_in_multExpr256);
            			    	atom25 = atom();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, atom25.Tree);

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
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:41:1: atom : ( MINUS_OP INT | INT | LBRAC expr RBRAC -> expr | STRING_LITERAL | CHAR_LITERAL | BOOL_LITERAL | ID );
    public CFlatParser.atom_return atom() // throws RecognitionException [1]
    {   
        CFlatParser.atom_return retval = new CFlatParser.atom_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken MINUS_OP26 = null;
        IToken INT27 = null;
        IToken INT28 = null;
        IToken LBRAC29 = null;
        IToken RBRAC31 = null;
        IToken STRING_LITERAL32 = null;
        IToken CHAR_LITERAL33 = null;
        IToken BOOL_LITERAL34 = null;
        IToken ID35 = null;
        CFlatParser.expr_return expr30 = default(CFlatParser.expr_return);


        CommonTree MINUS_OP26_tree=null;
        CommonTree INT27_tree=null;
        CommonTree INT28_tree=null;
        CommonTree LBRAC29_tree=null;
        CommonTree RBRAC31_tree=null;
        CommonTree STRING_LITERAL32_tree=null;
        CommonTree CHAR_LITERAL33_tree=null;
        CommonTree BOOL_LITERAL34_tree=null;
        CommonTree ID35_tree=null;
        RewriteRuleTokenStream stream_RBRAC = new RewriteRuleTokenStream(adaptor,"token RBRAC");
        RewriteRuleTokenStream stream_LBRAC = new RewriteRuleTokenStream(adaptor,"token LBRAC");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:41:5: ( MINUS_OP INT | INT | LBRAC expr RBRAC -> expr | STRING_LITERAL | CHAR_LITERAL | BOOL_LITERAL | ID )
            int alt7 = 7;
            switch ( input.LA(1) ) 
            {
            case MINUS_OP:
            	{
                alt7 = 1;
                }
                break;
            case INT:
            	{
                alt7 = 2;
                }
                break;
            case LBRAC:
            	{
                alt7 = 3;
                }
                break;
            case STRING_LITERAL:
            	{
                alt7 = 4;
                }
                break;
            case CHAR_LITERAL:
            	{
                alt7 = 5;
                }
                break;
            case BOOL_LITERAL:
            	{
                alt7 = 6;
                }
                break;
            case ID:
            	{
                alt7 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d7s0 =
            	        new NoViableAltException("", 7, 0, input);

            	    throw nvae_d7s0;
            }

            switch (alt7) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:41:9: MINUS_OP INT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	MINUS_OP26=(IToken)Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_atom272); 
                    		MINUS_OP26_tree = (CommonTree)adaptor.Create(MINUS_OP26);
                    		adaptor.AddChild(root_0, MINUS_OP26_tree);

                    	INT27=(IToken)Match(input,INT,FOLLOW_INT_in_atom274); 
                    		INT27_tree = (CommonTree)adaptor.Create(INT27);
                    		adaptor.AddChild(root_0, INT27_tree);


                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:43:2: INT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	INT28=(IToken)Match(input,INT,FOLLOW_INT_in_atom280); 
                    		INT28_tree = (CommonTree)adaptor.Create(INT28);
                    		adaptor.AddChild(root_0, INT28_tree);


                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:45:2: LBRAC expr RBRAC
                    {
                    	LBRAC29=(IToken)Match(input,LBRAC,FOLLOW_LBRAC_in_atom286);  
                    	stream_LBRAC.Add(LBRAC29);

                    	PushFollow(FOLLOW_expr_in_atom288);
                    	expr30 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr30.Tree);
                    	RBRAC31=(IToken)Match(input,RBRAC,FOLLOW_RBRAC_in_atom290);  
                    	stream_RBRAC.Add(RBRAC31);



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
                    	// 45:19: -> expr
                    	{
                    	    adaptor.AddChild(root_0, stream_expr.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 4 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:47:2: STRING_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	STRING_LITERAL32=(IToken)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_atom300); 
                    		STRING_LITERAL32_tree = (CommonTree)adaptor.Create(STRING_LITERAL32);
                    		adaptor.AddChild(root_0, STRING_LITERAL32_tree);


                    }
                    break;
                case 5 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:49:2: CHAR_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	CHAR_LITERAL33=(IToken)Match(input,CHAR_LITERAL,FOLLOW_CHAR_LITERAL_in_atom306); 
                    		CHAR_LITERAL33_tree = (CommonTree)adaptor.Create(CHAR_LITERAL33);
                    		adaptor.AddChild(root_0, CHAR_LITERAL33_tree);


                    }
                    break;
                case 6 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:51:2: BOOL_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	BOOL_LITERAL34=(IToken)Match(input,BOOL_LITERAL,FOLLOW_BOOL_LITERAL_in_atom312); 
                    		BOOL_LITERAL34_tree = (CommonTree)adaptor.Create(BOOL_LITERAL34);
                    		adaptor.AddChild(root_0, BOOL_LITERAL34_tree);


                    }
                    break;
                case 7 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:53:2: ID
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	ID35=(IToken)Match(input,ID,FOLLOW_ID_in_atom318); 
                    		ID35_tree = (CommonTree)adaptor.Create(ID35);
                    		adaptor.AddChild(root_0, ID35_tree);


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


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_25_in_prog71 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_CLASS_in_prog73 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_ID_in_prog75 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_26_in_prog77 = new BitSet(new ulong[]{0x000000000A000000UL});
    public static readonly BitSet FOLLOW_method_in_prog79 = new BitSet(new ulong[]{0x000000000A000000UL});
    public static readonly BitSet FOLLOW_27_in_prog82 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_25_in_method106 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_ID_in_method110 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_ID_in_method114 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_method116 = new BitSet(new ulong[]{0x000000000801DE40UL});
    public static readonly BitSet FOLLOW_stat_in_method118 = new BitSet(new ulong[]{0x000000000801DE40UL});
    public static readonly BitSet FOLLOW_27_in_method121 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_stat145 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_EOS_in_stat147 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_stat158 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_ID_in_stat162 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_EQUALS_in_stat164 = new BitSet(new ulong[]{0x000000000001DC40UL});
    public static readonly BitSet FOLLOW_expr_in_stat166 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_EOS_in_stat168 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RETURN_in_stat190 = new BitSet(new ulong[]{0x000000000001DC40UL});
    public static readonly BitSet FOLLOW_expr_in_stat192 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_EOS_in_stat194 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multExpr_in_expr211 = new BitSet(new ulong[]{0x0000000000020402UL});
    public static readonly BitSet FOLLOW_ARITH_OP_in_expr216 = new BitSet(new ulong[]{0x000000000001DC40UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_expr219 = new BitSet(new ulong[]{0x000000000001DC40UL});
    public static readonly BitSet FOLLOW_multExpr_in_expr223 = new BitSet(new ulong[]{0x0000000000020402UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr244 = new BitSet(new ulong[]{0x00000000001C0002UL});
    public static readonly BitSet FOLLOW_set_in_multExpr247 = new BitSet(new ulong[]{0x000000000001DC40UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr256 = new BitSet(new ulong[]{0x00000000001C0002UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_atom272 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_INT_in_atom274 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_atom280 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRAC_in_atom286 = new BitSet(new ulong[]{0x000000000001DC40UL});
    public static readonly BitSet FOLLOW_expr_in_atom288 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RBRAC_in_atom290 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_atom300 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_LITERAL_in_atom306 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOL_LITERAL_in_atom312 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_atom318 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}