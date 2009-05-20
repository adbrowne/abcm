// $ANTLR 3.1.2 C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g 2009-05-20 19:29:45

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
		"'}'"
    };

    public const int ALPHA_NUM = 22;
    public const int MULT_OP = 17;
    public const int T__27 = 27;
    public const int T__26 = 26;
    public const int T__25 = 25;
    public const int DIV_OP = 18;
    public const int T__24 = 24;
    public const int ARITH_OP = 16;
    public const int REM_OP = 19;
    public const int EQUALS = 6;
    public const int INT = 8;
    public const int BOOL_LITERAL = 13;
    public const int ID = 4;
    public const int EOF = -1;
    public const int LBRAC = 9;
    public const int ALPHA = 21;
    public const int WS = 23;
    public const int STRING_LITERAL = 11;
    public const int CHAR_LITERAL = 12;
    public const int RBRAC = 10;
    public const int EOS = 5;
    public const int START = 14;
    public const int MINUS_OP = 7;
    public const int END = 15;
    public const int CALLOUT = 20;

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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:1: prog : 'public' 'class' ID '{' ( stat )* '}' -> ^( 'class' ID ( stat )* ) ;
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
        DecafParser.stat_return stat5 = default(DecafParser.stat_return);


        CommonTree string_literal1_tree=null;
        CommonTree string_literal2_tree=null;
        CommonTree ID3_tree=null;
        CommonTree char_literal4_tree=null;
        CommonTree char_literal6_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_24 = new RewriteRuleTokenStream(adaptor,"token 24");
        RewriteRuleTokenStream stream_25 = new RewriteRuleTokenStream(adaptor,"token 25");
        RewriteRuleTokenStream stream_26 = new RewriteRuleTokenStream(adaptor,"token 26");
        RewriteRuleTokenStream stream_27 = new RewriteRuleTokenStream(adaptor,"token 27");
        RewriteRuleSubtreeStream stream_stat = new RewriteRuleSubtreeStream(adaptor,"rule stat");
        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:5: ( 'public' 'class' ID '{' ( stat )* '}' -> ^( 'class' ID ( stat )* ) )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:7: 'public' 'class' ID '{' ( stat )* '}'
            {
            	string_literal1=(IToken)Match(input,24,FOLLOW_24_in_prog59);  
            	stream_24.Add(string_literal1);

            	string_literal2=(IToken)Match(input,25,FOLLOW_25_in_prog61);  
            	stream_25.Add(string_literal2);

            	ID3=(IToken)Match(input,ID,FOLLOW_ID_in_prog63);  
            	stream_ID.Add(ID3);

            	char_literal4=(IToken)Match(input,26,FOLLOW_26_in_prog65);  
            	stream_26.Add(char_literal4);

            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:31: ( stat )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == ID || (LA1_0 >= MINUS_OP && LA1_0 <= LBRAC) || (LA1_0 >= STRING_LITERAL && LA1_0 <= BOOL_LITERAL)) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:31: stat
            			    {
            			    	PushFollow(FOLLOW_stat_in_prog67);
            			    	stat5 = stat();
            			    	state.followingStackPointer--;

            			    	stream_stat.Add(stat5.Tree);

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	char_literal6=(IToken)Match(input,27,FOLLOW_27_in_prog70);  
            	stream_27.Add(char_literal6);



            	// AST REWRITE
            	// elements:          ID, 25, stat
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 18:41: -> ^( 'class' ID ( stat )* )
            	{
            	    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:44: ^( 'class' ID ( stat )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_25.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_ID.NextNode());
            	    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:57: ( stat )*
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
    // $ANTLR end "prog"

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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:21:1: stat : ( expr EOS -> expr | t= ID name= ID EQUALS expr EOS -> ^( EQUALS ^( $t $name) expr ) );
    public DecafParser.stat_return stat() // throws RecognitionException [1]
    {   
        DecafParser.stat_return retval = new DecafParser.stat_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken t = null;
        IToken name = null;
        IToken EOS8 = null;
        IToken EQUALS9 = null;
        IToken EOS11 = null;
        DecafParser.expr_return expr7 = default(DecafParser.expr_return);

        DecafParser.expr_return expr10 = default(DecafParser.expr_return);


        CommonTree t_tree=null;
        CommonTree name_tree=null;
        CommonTree EOS8_tree=null;
        CommonTree EQUALS9_tree=null;
        CommonTree EOS11_tree=null;
        RewriteRuleTokenStream stream_EQUALS = new RewriteRuleTokenStream(adaptor,"token EQUALS");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_EOS = new RewriteRuleTokenStream(adaptor,"token EOS");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:21:5: ( expr EOS -> expr | t= ID name= ID EQUALS expr EOS -> ^( EQUALS ^( $t $name) expr ) )
            int alt2 = 2;
            int LA2_0 = input.LA(1);

            if ( ((LA2_0 >= MINUS_OP && LA2_0 <= LBRAC) || (LA2_0 >= STRING_LITERAL && LA2_0 <= BOOL_LITERAL)) )
            {
                alt2 = 1;
            }
            else if ( (LA2_0 == ID) )
            {
                int LA2_2 = input.LA(2);

                if ( (LA2_2 == ID) )
                {
                    alt2 = 2;
                }
                else if ( (LA2_2 == EOS || LA2_2 == MINUS_OP || (LA2_2 >= ARITH_OP && LA2_2 <= REM_OP)) )
                {
                    alt2 = 1;
                }
                else 
                {
                    NoViableAltException nvae_d2s2 =
                        new NoViableAltException("", 2, 2, input);

                    throw nvae_d2s2;
                }
            }
            else 
            {
                NoViableAltException nvae_d2s0 =
                    new NoViableAltException("", 2, 0, input);

                throw nvae_d2s0;
            }
            switch (alt2) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:21:9: expr EOS
                    {
                    	PushFollow(FOLLOW_expr_in_stat95);
                    	expr7 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr7.Tree);
                    	EOS8=(IToken)Match(input,EOS,FOLLOW_EOS_in_stat97);  
                    	stream_EOS.Add(EOS8);



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
                    	// 21:17: -> expr
                    	{
                    	    adaptor.AddChild(root_0, stream_expr.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:23:2: t= ID name= ID EQUALS expr EOS
                    {
                    	t=(IToken)Match(input,ID,FOLLOW_ID_in_stat108);  
                    	stream_ID.Add(t);

                    	name=(IToken)Match(input,ID,FOLLOW_ID_in_stat112);  
                    	stream_ID.Add(name);

                    	EQUALS9=(IToken)Match(input,EQUALS,FOLLOW_EQUALS_in_stat114);  
                    	stream_EQUALS.Add(EQUALS9);

                    	PushFollow(FOLLOW_expr_in_stat116);
                    	expr10 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr10.Tree);
                    	EOS11=(IToken)Match(input,EOS,FOLLOW_EOS_in_stat118);  
                    	stream_EOS.Add(EOS11);



                    	// AST REWRITE
                    	// elements:          EQUALS, name, t, expr
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
                    	// 23:31: -> ^( EQUALS ^( $t $name) expr )
                    	{
                    	    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:23:34: ^( EQUALS ^( $t $name) expr )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_EQUALS.NextNode(), root_1);

                    	    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:23:43: ^( $t $name)
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:25:1: expr : multExpr ( ( '+' | '-' ) multExpr )* ;
    public DecafParser.expr_return expr() // throws RecognitionException [1]
    {   
        DecafParser.expr_return retval = new DecafParser.expr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal13 = null;
        IToken char_literal14 = null;
        DecafParser.multExpr_return multExpr12 = default(DecafParser.multExpr_return);

        DecafParser.multExpr_return multExpr15 = default(DecafParser.multExpr_return);


        CommonTree char_literal13_tree=null;
        CommonTree char_literal14_tree=null;

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:25:5: ( multExpr ( ( '+' | '-' ) multExpr )* )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:25:9: multExpr ( ( '+' | '-' ) multExpr )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multExpr_in_expr143);
            	multExpr12 = multExpr();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, multExpr12.Tree);
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:25:18: ( ( '+' | '-' ) multExpr )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == MINUS_OP) )
            	    {
            	        int LA4_2 = input.LA(2);

            	        if ( (LA4_2 == ID || (LA4_2 >= MINUS_OP && LA4_2 <= LBRAC) || (LA4_2 >= STRING_LITERAL && LA4_2 <= BOOL_LITERAL)) )
            	        {
            	            alt4 = 1;
            	        }


            	    }
            	    else if ( (LA4_0 == ARITH_OP) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:25:19: ( '+' | '-' ) multExpr
            			    {
            			    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:25:19: ( '+' | '-' )
            			    	int alt3 = 2;
            			    	int LA3_0 = input.LA(1);

            			    	if ( (LA3_0 == ARITH_OP) )
            			    	{
            			    	    alt3 = 1;
            			    	}
            			    	else if ( (LA3_0 == MINUS_OP) )
            			    	{
            			    	    alt3 = 2;
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
            			    	        // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:25:20: '+'
            			    	        {
            			    	        	char_literal13=(IToken)Match(input,ARITH_OP,FOLLOW_ARITH_OP_in_expr147); 
            			    	        		char_literal13_tree = (CommonTree)adaptor.Create(char_literal13);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal13_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:25:25: '-'
            			    	        {
            			    	        	char_literal14=(IToken)Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_expr150); 
            			    	        		char_literal14_tree = (CommonTree)adaptor.Create(char_literal14);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal14_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multExpr_in_expr154);
            			    	multExpr15 = multExpr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, multExpr15.Tree);

            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements


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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:28:1: multExpr : atom ( ( '*' | '/' | '%' ) atom )* ;
    public DecafParser.multExpr_return multExpr() // throws RecognitionException [1]
    {   
        DecafParser.multExpr_return retval = new DecafParser.multExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set17 = null;
        DecafParser.atom_return atom16 = default(DecafParser.atom_return);

        DecafParser.atom_return atom18 = default(DecafParser.atom_return);


        CommonTree set17_tree=null;

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:29:5: ( atom ( ( '*' | '/' | '%' ) atom )* )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:29:9: atom ( ( '*' | '/' | '%' ) atom )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_atom_in_multExpr175);
            	atom16 = atom();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, atom16.Tree);
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:29:14: ( ( '*' | '/' | '%' ) atom )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( ((LA5_0 >= MULT_OP && LA5_0 <= REM_OP)) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:29:15: ( '*' | '/' | '%' ) atom
            			    {
            			    	set17=(IToken)input.LT(1);
            			    	set17 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= MULT_OP && input.LA(1) <= REM_OP) ) 
            			    	{
            			    	    input.Consume();
            			    	    root_0 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(set17), root_0);
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_atom_in_multExpr187);
            			    	atom18 = atom();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, atom18.Tree);

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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:32:1: atom : ( MINUS_OP INT | INT | ( LBRAC )+ ( expr )+ RBRAC -> expr | STRING_LITERAL | CHAR_LITERAL | BOOL_LITERAL | ID );
    public DecafParser.atom_return atom() // throws RecognitionException [1]
    {   
        DecafParser.atom_return retval = new DecafParser.atom_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken MINUS_OP19 = null;
        IToken INT20 = null;
        IToken INT21 = null;
        IToken LBRAC22 = null;
        IToken RBRAC24 = null;
        IToken STRING_LITERAL25 = null;
        IToken CHAR_LITERAL26 = null;
        IToken BOOL_LITERAL27 = null;
        IToken ID28 = null;
        DecafParser.expr_return expr23 = default(DecafParser.expr_return);


        CommonTree MINUS_OP19_tree=null;
        CommonTree INT20_tree=null;
        CommonTree INT21_tree=null;
        CommonTree LBRAC22_tree=null;
        CommonTree RBRAC24_tree=null;
        CommonTree STRING_LITERAL25_tree=null;
        CommonTree CHAR_LITERAL26_tree=null;
        CommonTree BOOL_LITERAL27_tree=null;
        CommonTree ID28_tree=null;
        RewriteRuleTokenStream stream_RBRAC = new RewriteRuleTokenStream(adaptor,"token RBRAC");
        RewriteRuleTokenStream stream_LBRAC = new RewriteRuleTokenStream(adaptor,"token LBRAC");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:32:5: ( MINUS_OP INT | INT | ( LBRAC )+ ( expr )+ RBRAC -> expr | STRING_LITERAL | CHAR_LITERAL | BOOL_LITERAL | ID )
            int alt8 = 7;
            switch ( input.LA(1) ) 
            {
            case MINUS_OP:
            	{
                alt8 = 1;
                }
                break;
            case INT:
            	{
                alt8 = 2;
                }
                break;
            case LBRAC:
            	{
                alt8 = 3;
                }
                break;
            case STRING_LITERAL:
            	{
                alt8 = 4;
                }
                break;
            case CHAR_LITERAL:
            	{
                alt8 = 5;
                }
                break;
            case BOOL_LITERAL:
            	{
                alt8 = 6;
                }
                break;
            case ID:
            	{
                alt8 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d8s0 =
            	        new NoViableAltException("", 8, 0, input);

            	    throw nvae_d8s0;
            }

            switch (alt8) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:32:9: MINUS_OP INT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	MINUS_OP19=(IToken)Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_atom203); 
                    		MINUS_OP19_tree = (CommonTree)adaptor.Create(MINUS_OP19);
                    		adaptor.AddChild(root_0, MINUS_OP19_tree);

                    	INT20=(IToken)Match(input,INT,FOLLOW_INT_in_atom205); 
                    		INT20_tree = (CommonTree)adaptor.Create(INT20);
                    		adaptor.AddChild(root_0, INT20_tree);


                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:34:2: INT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	INT21=(IToken)Match(input,INT,FOLLOW_INT_in_atom211); 
                    		INT21_tree = (CommonTree)adaptor.Create(INT21);
                    		adaptor.AddChild(root_0, INT21_tree);


                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:36:2: ( LBRAC )+ ( expr )+ RBRAC
                    {
                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:36:2: ( LBRAC )+
                    	int cnt6 = 0;
                    	do 
                    	{
                    	    int alt6 = 2;
                    	    int LA6_0 = input.LA(1);

                    	    if ( (LA6_0 == LBRAC) )
                    	    {
                    	        alt6 = 1;
                    	    }


                    	    switch (alt6) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:36:2: LBRAC
                    			    {
                    			    	LBRAC22=(IToken)Match(input,LBRAC,FOLLOW_LBRAC_in_atom217);  
                    			    	stream_LBRAC.Add(LBRAC22);


                    			    }
                    			    break;

                    			default:
                    			    if ( cnt6 >= 1 ) goto loop6;
                    		            EarlyExitException eee6 =
                    		                new EarlyExitException(6, input);
                    		            throw eee6;
                    	    }
                    	    cnt6++;
                    	} while (true);

                    	loop6:
                    		;	// Stops C# compiler whinging that label 'loop6' has no statements

                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:36:10: ( expr )+
                    	int cnt7 = 0;
                    	do 
                    	{
                    	    int alt7 = 2;
                    	    int LA7_0 = input.LA(1);

                    	    if ( (LA7_0 == ID || (LA7_0 >= MINUS_OP && LA7_0 <= LBRAC) || (LA7_0 >= STRING_LITERAL && LA7_0 <= BOOL_LITERAL)) )
                    	    {
                    	        alt7 = 1;
                    	    }


                    	    switch (alt7) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:36:10: expr
                    			    {
                    			    	PushFollow(FOLLOW_expr_in_atom221);
                    			    	expr23 = expr();
                    			    	state.followingStackPointer--;

                    			    	stream_expr.Add(expr23.Tree);

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

                    	RBRAC24=(IToken)Match(input,RBRAC,FOLLOW_RBRAC_in_atom225);  
                    	stream_RBRAC.Add(RBRAC24);



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
                    	// 36:23: -> expr
                    	{
                    	    adaptor.AddChild(root_0, stream_expr.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 4 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:38:2: STRING_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	STRING_LITERAL25=(IToken)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_atom235); 
                    		STRING_LITERAL25_tree = (CommonTree)adaptor.Create(STRING_LITERAL25);
                    		adaptor.AddChild(root_0, STRING_LITERAL25_tree);


                    }
                    break;
                case 5 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:40:2: CHAR_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	CHAR_LITERAL26=(IToken)Match(input,CHAR_LITERAL,FOLLOW_CHAR_LITERAL_in_atom241); 
                    		CHAR_LITERAL26_tree = (CommonTree)adaptor.Create(CHAR_LITERAL26);
                    		adaptor.AddChild(root_0, CHAR_LITERAL26_tree);


                    }
                    break;
                case 6 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:42:2: BOOL_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	BOOL_LITERAL27=(IToken)Match(input,BOOL_LITERAL,FOLLOW_BOOL_LITERAL_in_atom247); 
                    		BOOL_LITERAL27_tree = (CommonTree)adaptor.Create(BOOL_LITERAL27);
                    		adaptor.AddChild(root_0, BOOL_LITERAL27_tree);


                    }
                    break;
                case 7 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:44:2: ID
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	ID28=(IToken)Match(input,ID,FOLLOW_ID_in_atom253); 
                    		ID28_tree = (CommonTree)adaptor.Create(ID28);
                    		adaptor.AddChild(root_0, ID28_tree);


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

 

    public static readonly BitSet FOLLOW_24_in_prog59 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_25_in_prog61 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_prog63 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_26_in_prog65 = new BitSet(new ulong[]{0x0000000008003B90UL});
    public static readonly BitSet FOLLOW_stat_in_prog67 = new BitSet(new ulong[]{0x0000000008003B90UL});
    public static readonly BitSet FOLLOW_27_in_prog70 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_stat95 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_EOS_in_stat97 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_stat108 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_stat112 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_EQUALS_in_stat114 = new BitSet(new ulong[]{0x0000000000003B90UL});
    public static readonly BitSet FOLLOW_expr_in_stat116 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_EOS_in_stat118 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multExpr_in_expr143 = new BitSet(new ulong[]{0x0000000000010082UL});
    public static readonly BitSet FOLLOW_ARITH_OP_in_expr147 = new BitSet(new ulong[]{0x0000000000003B90UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_expr150 = new BitSet(new ulong[]{0x0000000000003B90UL});
    public static readonly BitSet FOLLOW_multExpr_in_expr154 = new BitSet(new ulong[]{0x0000000000010082UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr175 = new BitSet(new ulong[]{0x00000000000E0002UL});
    public static readonly BitSet FOLLOW_set_in_multExpr178 = new BitSet(new ulong[]{0x0000000000003B90UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr187 = new BitSet(new ulong[]{0x00000000000E0002UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_atom203 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_INT_in_atom205 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_atom211 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRAC_in_atom217 = new BitSet(new ulong[]{0x0000000000003B90UL});
    public static readonly BitSet FOLLOW_expr_in_atom221 = new BitSet(new ulong[]{0x0000000000003F90UL});
    public static readonly BitSet FOLLOW_RBRAC_in_atom225 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_atom235 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_LITERAL_in_atom241 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOL_LITERAL_in_atom247 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_atom253 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}