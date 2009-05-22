// $ANTLR 3.1.2 C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g 2009-05-22 12:51:05

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
namespace 
    Decaf

{

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;

public partial class DecafParser : Parser
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
		"MINUS_OP", 
		"INT", 
		"LBRAC", 
		"RBRAC", 
		"STRING_LITERAL", 
		"CHAR_LITERAL", 
		"BOOL_LITERAL", 
		"START", 
		"END", 
		"ARITH_OP", 
		"MULT_OP", 
		"DIV_OP", 
		"REM_OP", 
		"CALLOUT", 
		"ALPHA", 
		"ALPHA_NUM", 
		"WS", 
		"'public'", 
		"'class'", 
		"'{'", 
		"'}'", 
		"'(){'"
    };

    public const int ALPHA_NUM = 24;
    public const int MULT_OP = 19;
    public const int CLASS = 5;
    public const int T__29 = 29;
    public const int T__28 = 28;
    public const int T__27 = 27;
    public const int T__26 = 26;
    public const int DIV_OP = 20;
    public const int ARITH_OP = 18;
    public const int REM_OP = 21;
    public const int EQUALS = 8;
    public const int INT = 10;
    public const int BOOL_LITERAL = 15;
    public const int ID = 6;
    public const int EOF = -1;
    public const int LBRAC = 11;
    public const int ALPHA = 23;
    public const int T__30 = 30;
    public const int WS = 25;
    public const int STRING_LITERAL = 13;
    public const int CHAR_LITERAL = 14;
    public const int RBRAC = 12;
    public const int EOS = 7;
    public const int START = 16;
    public const int MINUS_OP = 9;
    public const int END = 17;
    public const int METHOD = 4;
    public const int CALLOUT = 22;

    // delegates
    // delegators



        public DecafParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public DecafParser(ITokenStream input, RecognizerSharedState state)
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
		get { return DecafParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g"; }
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:23:1: prog : 'public' 'class' ID '{' ( method )* '}' -> ^( CLASS ID ( method )* ) ;
    public DecafParser.prog_return prog() // throws RecognitionException [1]
    {   
        DecafParser.prog_return retval = new DecafParser.prog_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal1 = null;
        IToken string_literal2 = null;
        IToken ID3 = null;
        IToken char_literal4 = null;
        IToken char_literal6 = null;
        DecafParser.method_return method5 = default(DecafParser.method_return);


        CommonTree string_literal1_tree=null;
        CommonTree string_literal2_tree=null;
        CommonTree ID3_tree=null;
        CommonTree char_literal4_tree=null;
        CommonTree char_literal6_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_26 = new RewriteRuleTokenStream(adaptor,"token 26");
        RewriteRuleTokenStream stream_27 = new RewriteRuleTokenStream(adaptor,"token 27");
        RewriteRuleTokenStream stream_28 = new RewriteRuleTokenStream(adaptor,"token 28");
        RewriteRuleTokenStream stream_29 = new RewriteRuleTokenStream(adaptor,"token 29");
        RewriteRuleSubtreeStream stream_method = new RewriteRuleSubtreeStream(adaptor,"rule method");
        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:23:5: ( 'public' 'class' ID '{' ( method )* '}' -> ^( CLASS ID ( method )* ) )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:23:7: 'public' 'class' ID '{' ( method )* '}'
            {
            	string_literal1=(IToken)Match(input,26,FOLLOW_26_in_prog78);  
            	stream_26.Add(string_literal1);

            	string_literal2=(IToken)Match(input,27,FOLLOW_27_in_prog80);  
            	stream_27.Add(string_literal2);

            	ID3=(IToken)Match(input,ID,FOLLOW_ID_in_prog82);  
            	stream_ID.Add(ID3);

            	char_literal4=(IToken)Match(input,28,FOLLOW_28_in_prog84);  
            	stream_28.Add(char_literal4);

            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:23:31: ( method )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == 26) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:23:31: method
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

            	char_literal6=(IToken)Match(input,29,FOLLOW_29_in_prog89);  
            	stream_29.Add(char_literal6);



            	// AST REWRITE
            	// elements:          method, ID
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 23:43: -> ^( CLASS ID ( method )* )
            	{
            	    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:23:46: ^( CLASS ID ( method )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(CLASS, "CLASS"), root_1);

            	    adaptor.AddChild(root_1, stream_ID.NextNode());
            	    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:23:57: ( method )*
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:26:1: method : 'public' ID '(){' ( stat )* '}' -> ^( METHOD ID ( stat )* ) ;
    public DecafParser.method_return method() // throws RecognitionException [1]
    {   
        DecafParser.method_return retval = new DecafParser.method_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal7 = null;
        IToken ID8 = null;
        IToken string_literal9 = null;
        IToken char_literal11 = null;
        DecafParser.stat_return stat10 = default(DecafParser.stat_return);


        CommonTree string_literal7_tree=null;
        CommonTree ID8_tree=null;
        CommonTree string_literal9_tree=null;
        CommonTree char_literal11_tree=null;
        RewriteRuleTokenStream stream_30 = new RewriteRuleTokenStream(adaptor,"token 30");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_26 = new RewriteRuleTokenStream(adaptor,"token 26");
        RewriteRuleTokenStream stream_29 = new RewriteRuleTokenStream(adaptor,"token 29");
        RewriteRuleSubtreeStream stream_stat = new RewriteRuleSubtreeStream(adaptor,"rule stat");
        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:26:8: ( 'public' ID '(){' ( stat )* '}' -> ^( METHOD ID ( stat )* ) )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:26:10: 'public' ID '(){' ( stat )* '}'
            {
            	string_literal7=(IToken)Match(input,26,FOLLOW_26_in_method113);  
            	stream_26.Add(string_literal7);

            	ID8=(IToken)Match(input,ID,FOLLOW_ID_in_method115);  
            	stream_ID.Add(ID8);

            	string_literal9=(IToken)Match(input,30,FOLLOW_30_in_method117);  
            	stream_30.Add(string_literal9);

            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:26:28: ( stat )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == ID || (LA2_0 >= MINUS_OP && LA2_0 <= LBRAC) || (LA2_0 >= STRING_LITERAL && LA2_0 <= BOOL_LITERAL)) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:26:28: stat
            			    {
            			    	PushFollow(FOLLOW_stat_in_method119);
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

            	char_literal11=(IToken)Match(input,29,FOLLOW_29_in_method122);  
            	stream_29.Add(char_literal11);



            	// AST REWRITE
            	// elements:          ID, stat
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 26:38: -> ^( METHOD ID ( stat )* )
            	{
            	    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:26:41: ^( METHOD ID ( stat )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(METHOD, "METHOD"), root_1);

            	    adaptor.AddChild(root_1, stream_ID.NextNode());
            	    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:26:53: ( stat )*
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:28:1: stat : ( expr EOS -> expr | t= ID name= ID EQUALS expr EOS -> ^( EQUALS ^( $t $name) expr ) );
    public DecafParser.stat_return stat() // throws RecognitionException [1]
    {   
        DecafParser.stat_return retval = new DecafParser.stat_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken t = null;
        IToken name = null;
        IToken EOS13 = null;
        IToken EQUALS14 = null;
        IToken EOS16 = null;
        DecafParser.expr_return expr12 = default(DecafParser.expr_return);

        DecafParser.expr_return expr15 = default(DecafParser.expr_return);


        CommonTree t_tree=null;
        CommonTree name_tree=null;
        CommonTree EOS13_tree=null;
        CommonTree EQUALS14_tree=null;
        CommonTree EOS16_tree=null;
        RewriteRuleTokenStream stream_EQUALS = new RewriteRuleTokenStream(adaptor,"token EQUALS");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_EOS = new RewriteRuleTokenStream(adaptor,"token EOS");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:28:5: ( expr EOS -> expr | t= ID name= ID EQUALS expr EOS -> ^( EQUALS ^( $t $name) expr ) )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( ((LA3_0 >= MINUS_OP && LA3_0 <= LBRAC) || (LA3_0 >= STRING_LITERAL && LA3_0 <= BOOL_LITERAL)) )
            {
                alt3 = 1;
            }
            else if ( (LA3_0 == ID) )
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
            else 
            {
                NoViableAltException nvae_d3s0 =
                    new NoViableAltException("", 3, 0, input);

                throw nvae_d3s0;
            }
            switch (alt3) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:28:9: expr EOS
                    {
                    	PushFollow(FOLLOW_expr_in_stat142);
                    	expr12 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr12.Tree);
                    	EOS13=(IToken)Match(input,EOS,FOLLOW_EOS_in_stat144);  
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
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:30:2: t= ID name= ID EQUALS expr EOS
                    {
                    	t=(IToken)Match(input,ID,FOLLOW_ID_in_stat155);  
                    	stream_ID.Add(t);

                    	name=(IToken)Match(input,ID,FOLLOW_ID_in_stat159);  
                    	stream_ID.Add(name);

                    	EQUALS14=(IToken)Match(input,EQUALS,FOLLOW_EQUALS_in_stat161);  
                    	stream_EQUALS.Add(EQUALS14);

                    	PushFollow(FOLLOW_expr_in_stat163);
                    	expr15 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr15.Tree);
                    	EOS16=(IToken)Match(input,EOS,FOLLOW_EOS_in_stat165);  
                    	stream_EOS.Add(EOS16);



                    	// AST REWRITE
                    	// elements:          name, EQUALS, t, expr
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
                    	    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:30:34: ^( EQUALS ^( $t $name) expr )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_EQUALS.NextNode(), root_1);

                    	    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:30:43: ^( $t $name)
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:32:1: expr : multExpr ( ( '+' | '-' ) multExpr )* ;
    public DecafParser.expr_return expr() // throws RecognitionException [1]
    {   
        DecafParser.expr_return retval = new DecafParser.expr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal18 = null;
        IToken char_literal19 = null;
        DecafParser.multExpr_return multExpr17 = default(DecafParser.multExpr_return);

        DecafParser.multExpr_return multExpr20 = default(DecafParser.multExpr_return);


        CommonTree char_literal18_tree=null;
        CommonTree char_literal19_tree=null;

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:32:5: ( multExpr ( ( '+' | '-' ) multExpr )* )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:32:9: multExpr ( ( '+' | '-' ) multExpr )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multExpr_in_expr190);
            	multExpr17 = multExpr();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, multExpr17.Tree);
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:32:18: ( ( '+' | '-' ) multExpr )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == MINUS_OP) )
            	    {
            	        int LA5_2 = input.LA(2);

            	        if ( (LA5_2 == ID || (LA5_2 >= MINUS_OP && LA5_2 <= LBRAC) || (LA5_2 >= STRING_LITERAL && LA5_2 <= BOOL_LITERAL)) )
            	        {
            	            alt5 = 1;
            	        }


            	    }
            	    else if ( (LA5_0 == ARITH_OP) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:32:19: ( '+' | '-' ) multExpr
            			    {
            			    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:32:19: ( '+' | '-' )
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
            			    	        // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:32:20: '+'
            			    	        {
            			    	        	char_literal18=(IToken)Match(input,ARITH_OP,FOLLOW_ARITH_OP_in_expr194); 
            			    	        		char_literal18_tree = (CommonTree)adaptor.Create(char_literal18);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal18_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:32:25: '-'
            			    	        {
            			    	        	char_literal19=(IToken)Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_expr197); 
            			    	        		char_literal19_tree = (CommonTree)adaptor.Create(char_literal19);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal19_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multExpr_in_expr201);
            			    	multExpr20 = multExpr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, multExpr20.Tree);

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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:35:1: multExpr : atom ( ( '*' | '/' | '%' ) atom )* ;
    public DecafParser.multExpr_return multExpr() // throws RecognitionException [1]
    {   
        DecafParser.multExpr_return retval = new DecafParser.multExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set22 = null;
        DecafParser.atom_return atom21 = default(DecafParser.atom_return);

        DecafParser.atom_return atom23 = default(DecafParser.atom_return);


        CommonTree set22_tree=null;

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:36:5: ( atom ( ( '*' | '/' | '%' ) atom )* )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:36:9: atom ( ( '*' | '/' | '%' ) atom )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_atom_in_multExpr222);
            	atom21 = atom();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, atom21.Tree);
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:36:14: ( ( '*' | '/' | '%' ) atom )*
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
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:36:15: ( '*' | '/' | '%' ) atom
            			    {
            			    	set22=(IToken)input.LT(1);
            			    	set22 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= MULT_OP && input.LA(1) <= REM_OP) ) 
            			    	{
            			    	    input.Consume();
            			    	    root_0 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(set22), root_0);
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_atom_in_multExpr234);
            			    	atom23 = atom();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, atom23.Tree);

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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:39:1: atom : ( MINUS_OP INT | INT | ( LBRAC )+ ( expr )+ RBRAC -> expr | STRING_LITERAL | CHAR_LITERAL | BOOL_LITERAL | ID );
    public DecafParser.atom_return atom() // throws RecognitionException [1]
    {   
        DecafParser.atom_return retval = new DecafParser.atom_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken MINUS_OP24 = null;
        IToken INT25 = null;
        IToken INT26 = null;
        IToken LBRAC27 = null;
        IToken RBRAC29 = null;
        IToken STRING_LITERAL30 = null;
        IToken CHAR_LITERAL31 = null;
        IToken BOOL_LITERAL32 = null;
        IToken ID33 = null;
        DecafParser.expr_return expr28 = default(DecafParser.expr_return);


        CommonTree MINUS_OP24_tree=null;
        CommonTree INT25_tree=null;
        CommonTree INT26_tree=null;
        CommonTree LBRAC27_tree=null;
        CommonTree RBRAC29_tree=null;
        CommonTree STRING_LITERAL30_tree=null;
        CommonTree CHAR_LITERAL31_tree=null;
        CommonTree BOOL_LITERAL32_tree=null;
        CommonTree ID33_tree=null;
        RewriteRuleTokenStream stream_RBRAC = new RewriteRuleTokenStream(adaptor,"token RBRAC");
        RewriteRuleTokenStream stream_LBRAC = new RewriteRuleTokenStream(adaptor,"token LBRAC");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:39:5: ( MINUS_OP INT | INT | ( LBRAC )+ ( expr )+ RBRAC -> expr | STRING_LITERAL | CHAR_LITERAL | BOOL_LITERAL | ID )
            int alt9 = 7;
            switch ( input.LA(1) ) 
            {
            case MINUS_OP:
            	{
                alt9 = 1;
                }
                break;
            case INT:
            	{
                alt9 = 2;
                }
                break;
            case LBRAC:
            	{
                alt9 = 3;
                }
                break;
            case STRING_LITERAL:
            	{
                alt9 = 4;
                }
                break;
            case CHAR_LITERAL:
            	{
                alt9 = 5;
                }
                break;
            case BOOL_LITERAL:
            	{
                alt9 = 6;
                }
                break;
            case ID:
            	{
                alt9 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d9s0 =
            	        new NoViableAltException("", 9, 0, input);

            	    throw nvae_d9s0;
            }

            switch (alt9) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:39:9: MINUS_OP INT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	MINUS_OP24=(IToken)Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_atom250); 
                    		MINUS_OP24_tree = (CommonTree)adaptor.Create(MINUS_OP24);
                    		adaptor.AddChild(root_0, MINUS_OP24_tree);

                    	INT25=(IToken)Match(input,INT,FOLLOW_INT_in_atom252); 
                    		INT25_tree = (CommonTree)adaptor.Create(INT25);
                    		adaptor.AddChild(root_0, INT25_tree);


                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:41:2: INT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	INT26=(IToken)Match(input,INT,FOLLOW_INT_in_atom258); 
                    		INT26_tree = (CommonTree)adaptor.Create(INT26);
                    		adaptor.AddChild(root_0, INT26_tree);


                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:43:2: ( LBRAC )+ ( expr )+ RBRAC
                    {
                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:43:2: ( LBRAC )+
                    	int cnt7 = 0;
                    	do 
                    	{
                    	    int alt7 = 2;
                    	    int LA7_0 = input.LA(1);

                    	    if ( (LA7_0 == LBRAC) )
                    	    {
                    	        alt7 = 1;
                    	    }


                    	    switch (alt7) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:43:2: LBRAC
                    			    {
                    			    	LBRAC27=(IToken)Match(input,LBRAC,FOLLOW_LBRAC_in_atom264);  
                    			    	stream_LBRAC.Add(LBRAC27);


                    			    }
                    			    break;

                    			default:
                    			    if ( cnt7 >= 1 ) goto loop7;
                    		            EarlyExitException eee7 =
                    		                new EarlyExitException(7, input);
                    		            throw eee7;
                    	    }
                    	    cnt7++;
                    	} while (true);

                    	loop7:
                    		;	// Stops C# compiler whinging that label 'loop7' has no statements

                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:43:10: ( expr )+
                    	int cnt8 = 0;
                    	do 
                    	{
                    	    int alt8 = 2;
                    	    int LA8_0 = input.LA(1);

                    	    if ( (LA8_0 == ID || (LA8_0 >= MINUS_OP && LA8_0 <= LBRAC) || (LA8_0 >= STRING_LITERAL && LA8_0 <= BOOL_LITERAL)) )
                    	    {
                    	        alt8 = 1;
                    	    }


                    	    switch (alt8) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:43:10: expr
                    			    {
                    			    	PushFollow(FOLLOW_expr_in_atom268);
                    			    	expr28 = expr();
                    			    	state.followingStackPointer--;

                    			    	stream_expr.Add(expr28.Tree);

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt8 >= 1 ) goto loop8;
                    		            EarlyExitException eee8 =
                    		                new EarlyExitException(8, input);
                    		            throw eee8;
                    	    }
                    	    cnt8++;
                    	} while (true);

                    	loop8:
                    		;	// Stops C# compiler whinging that label 'loop8' has no statements

                    	RBRAC29=(IToken)Match(input,RBRAC,FOLLOW_RBRAC_in_atom272);  
                    	stream_RBRAC.Add(RBRAC29);



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
                    	// 43:23: -> expr
                    	{
                    	    adaptor.AddChild(root_0, stream_expr.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 4 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:45:2: STRING_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	STRING_LITERAL30=(IToken)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_atom282); 
                    		STRING_LITERAL30_tree = (CommonTree)adaptor.Create(STRING_LITERAL30);
                    		adaptor.AddChild(root_0, STRING_LITERAL30_tree);


                    }
                    break;
                case 5 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:47:2: CHAR_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	CHAR_LITERAL31=(IToken)Match(input,CHAR_LITERAL,FOLLOW_CHAR_LITERAL_in_atom288); 
                    		CHAR_LITERAL31_tree = (CommonTree)adaptor.Create(CHAR_LITERAL31);
                    		adaptor.AddChild(root_0, CHAR_LITERAL31_tree);


                    }
                    break;
                case 6 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:49:2: BOOL_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	BOOL_LITERAL32=(IToken)Match(input,BOOL_LITERAL,FOLLOW_BOOL_LITERAL_in_atom294); 
                    		BOOL_LITERAL32_tree = (CommonTree)adaptor.Create(BOOL_LITERAL32);
                    		adaptor.AddChild(root_0, BOOL_LITERAL32_tree);


                    }
                    break;
                case 7 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:51:2: ID
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	ID33=(IToken)Match(input,ID,FOLLOW_ID_in_atom300); 
                    		ID33_tree = (CommonTree)adaptor.Create(ID33);
                    		adaptor.AddChild(root_0, ID33_tree);


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

 

    public static readonly BitSet FOLLOW_26_in_prog78 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_prog80 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_ID_in_prog82 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_prog84 = new BitSet(new ulong[]{0x0000000024000000UL});
    public static readonly BitSet FOLLOW_method_in_prog86 = new BitSet(new ulong[]{0x0000000024000000UL});
    public static readonly BitSet FOLLOW_29_in_prog89 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_26_in_method113 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_ID_in_method115 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_method117 = new BitSet(new ulong[]{0x000000002000EE40UL});
    public static readonly BitSet FOLLOW_stat_in_method119 = new BitSet(new ulong[]{0x000000002000EE40UL});
    public static readonly BitSet FOLLOW_29_in_method122 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_stat142 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_EOS_in_stat144 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_stat155 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_ID_in_stat159 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_EQUALS_in_stat161 = new BitSet(new ulong[]{0x000000000000EE40UL});
    public static readonly BitSet FOLLOW_expr_in_stat163 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_EOS_in_stat165 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multExpr_in_expr190 = new BitSet(new ulong[]{0x0000000000040202UL});
    public static readonly BitSet FOLLOW_ARITH_OP_in_expr194 = new BitSet(new ulong[]{0x000000000000EE40UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_expr197 = new BitSet(new ulong[]{0x000000000000EE40UL});
    public static readonly BitSet FOLLOW_multExpr_in_expr201 = new BitSet(new ulong[]{0x0000000000040202UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr222 = new BitSet(new ulong[]{0x0000000000380002UL});
    public static readonly BitSet FOLLOW_set_in_multExpr225 = new BitSet(new ulong[]{0x000000000000EE40UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr234 = new BitSet(new ulong[]{0x0000000000380002UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_atom250 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_INT_in_atom252 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_atom258 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRAC_in_atom264 = new BitSet(new ulong[]{0x000000000000EE40UL});
    public static readonly BitSet FOLLOW_expr_in_atom268 = new BitSet(new ulong[]{0x000000000000FE40UL});
    public static readonly BitSet FOLLOW_RBRAC_in_atom272 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_atom282 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_LITERAL_in_atom288 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOL_LITERAL_in_atom294 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_atom300 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}