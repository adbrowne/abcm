// $ANTLR 3.1.2 C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g 2009-05-20 14:28:22

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
		"EQUALS", 
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
		"EOS", 
		"CALLOUT", 
		"ALPHA", 
		"ALPHA_NUM", 
		"WS"
    };

    public const int ALPHA_NUM = 20;
    public const int MULT_OP = 14;
    public const int DIV_OP = 15;
    public const int ARITH_OP = 13;
    public const int REM_OP = 16;
    public const int INT = 7;
    public const int EQUALS = 5;
    public const int BOOL_LITERAL = 12;
    public const int ID = 4;
    public const int EOF = -1;
    public const int LBRAC = 8;
    public const int ALPHA = 19;
    public const int WS = 21;
    public const int STRING_LITERAL = 10;
    public const int CHAR_LITERAL = 11;
    public const int RBRAC = 9;
    public const int EOS = 17;
    public const int MINUS_OP = 6;
    public const int CALLOUT = 18;

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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:1: prog : ( stat ) ;
    public DecafParser.prog_return prog() // throws RecognitionException [1]
    {   
        DecafParser.prog_return retval = new DecafParser.prog_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        DecafParser.stat_return stat1 = default(DecafParser.stat_return);



        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:5: ( ( stat ) )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:7: ( stat )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:7: ( stat )
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:9: stat
            	{
            		PushFollow(FOLLOW_stat_in_prog61);
            		stat1 = stat();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, stat1.Tree);

            	}


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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:21:1: stat : ( expr -> expr | t= ID name= ID EQUALS expr -> ^( EQUALS ^( $t $name) expr ) );
    public DecafParser.stat_return stat() // throws RecognitionException [1]
    {   
        DecafParser.stat_return retval = new DecafParser.stat_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken t = null;
        IToken name = null;
        IToken EQUALS3 = null;
        DecafParser.expr_return expr2 = default(DecafParser.expr_return);

        DecafParser.expr_return expr4 = default(DecafParser.expr_return);


        CommonTree t_tree=null;
        CommonTree name_tree=null;
        CommonTree EQUALS3_tree=null;
        RewriteRuleTokenStream stream_EQUALS = new RewriteRuleTokenStream(adaptor,"token EQUALS");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:21:5: ( expr -> expr | t= ID name= ID EQUALS expr -> ^( EQUALS ^( $t $name) expr ) )
            int alt1 = 2;
            int LA1_0 = input.LA(1);

            if ( ((LA1_0 >= MINUS_OP && LA1_0 <= LBRAC) || (LA1_0 >= STRING_LITERAL && LA1_0 <= BOOL_LITERAL)) )
            {
                alt1 = 1;
            }
            else if ( (LA1_0 == ID) )
            {
                int LA1_2 = input.LA(2);

                if ( (LA1_2 == ID) )
                {
                    alt1 = 2;
                }
                else if ( (LA1_2 == EOF || LA1_2 == MINUS_OP || (LA1_2 >= ARITH_OP && LA1_2 <= REM_OP)) )
                {
                    alt1 = 1;
                }
                else 
                {
                    NoViableAltException nvae_d1s2 =
                        new NoViableAltException("", 1, 2, input);

                    throw nvae_d1s2;
                }
            }
            else 
            {
                NoViableAltException nvae_d1s0 =
                    new NoViableAltException("", 1, 0, input);

                throw nvae_d1s0;
            }
            switch (alt1) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:21:9: expr
                    {
                    	PushFollow(FOLLOW_expr_in_stat77);
                    	expr2 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr2.Tree);


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
                    	// 21:14: -> expr
                    	{
                    	    adaptor.AddChild(root_0, stream_expr.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:23:2: t= ID name= ID EQUALS expr
                    {
                    	t=(IToken)Match(input,ID,FOLLOW_ID_in_stat89);  
                    	stream_ID.Add(t);

                    	name=(IToken)Match(input,ID,FOLLOW_ID_in_stat93);  
                    	stream_ID.Add(name);

                    	EQUALS3=(IToken)Match(input,EQUALS,FOLLOW_EQUALS_in_stat95);  
                    	stream_EQUALS.Add(EQUALS3);

                    	PushFollow(FOLLOW_expr_in_stat97);
                    	expr4 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr4.Tree);


                    	// AST REWRITE
                    	// elements:          name, expr, t, EQUALS
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
                    	// 23:27: -> ^( EQUALS ^( $t $name) expr )
                    	{
                    	    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:23:30: ^( EQUALS ^( $t $name) expr )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_EQUALS.NextNode(), root_1);

                    	    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:23:39: ^( $t $name)
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

        IToken char_literal6 = null;
        IToken char_literal7 = null;
        DecafParser.multExpr_return multExpr5 = default(DecafParser.multExpr_return);

        DecafParser.multExpr_return multExpr8 = default(DecafParser.multExpr_return);


        CommonTree char_literal6_tree=null;
        CommonTree char_literal7_tree=null;

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:25:5: ( multExpr ( ( '+' | '-' ) multExpr )* )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:25:9: multExpr ( ( '+' | '-' ) multExpr )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multExpr_in_expr122);
            	multExpr5 = multExpr();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, multExpr5.Tree);
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:25:18: ( ( '+' | '-' ) multExpr )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == MINUS_OP) )
            	    {
            	        int LA3_2 = input.LA(2);

            	        if ( (LA3_2 == ID || (LA3_2 >= MINUS_OP && LA3_2 <= LBRAC) || (LA3_2 >= STRING_LITERAL && LA3_2 <= BOOL_LITERAL)) )
            	        {
            	            alt3 = 1;
            	        }


            	    }
            	    else if ( (LA3_0 == ARITH_OP) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:25:19: ( '+' | '-' ) multExpr
            			    {
            			    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:25:19: ( '+' | '-' )
            			    	int alt2 = 2;
            			    	int LA2_0 = input.LA(1);

            			    	if ( (LA2_0 == ARITH_OP) )
            			    	{
            			    	    alt2 = 1;
            			    	}
            			    	else if ( (LA2_0 == MINUS_OP) )
            			    	{
            			    	    alt2 = 2;
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
            			    	        // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:25:20: '+'
            			    	        {
            			    	        	char_literal6=(IToken)Match(input,ARITH_OP,FOLLOW_ARITH_OP_in_expr126); 
            			    	        		char_literal6_tree = (CommonTree)adaptor.Create(char_literal6);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal6_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:25:25: '-'
            			    	        {
            			    	        	char_literal7=(IToken)Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_expr129); 
            			    	        		char_literal7_tree = (CommonTree)adaptor.Create(char_literal7);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal7_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multExpr_in_expr133);
            			    	multExpr8 = multExpr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, multExpr8.Tree);

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


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

        IToken set10 = null;
        DecafParser.atom_return atom9 = default(DecafParser.atom_return);

        DecafParser.atom_return atom11 = default(DecafParser.atom_return);


        CommonTree set10_tree=null;

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:29:5: ( atom ( ( '*' | '/' | '%' ) atom )* )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:29:9: atom ( ( '*' | '/' | '%' ) atom )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_atom_in_multExpr154);
            	atom9 = atom();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, atom9.Tree);
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:29:14: ( ( '*' | '/' | '%' ) atom )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( ((LA4_0 >= MULT_OP && LA4_0 <= REM_OP)) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:29:15: ( '*' | '/' | '%' ) atom
            			    {
            			    	set10=(IToken)input.LT(1);
            			    	set10 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= MULT_OP && input.LA(1) <= REM_OP) ) 
            			    	{
            			    	    input.Consume();
            			    	    root_0 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(set10), root_0);
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_atom_in_multExpr166);
            			    	atom11 = atom();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, atom11.Tree);

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

        IToken MINUS_OP12 = null;
        IToken INT13 = null;
        IToken INT14 = null;
        IToken LBRAC15 = null;
        IToken RBRAC17 = null;
        IToken STRING_LITERAL18 = null;
        IToken CHAR_LITERAL19 = null;
        IToken BOOL_LITERAL20 = null;
        IToken ID21 = null;
        DecafParser.expr_return expr16 = default(DecafParser.expr_return);


        CommonTree MINUS_OP12_tree=null;
        CommonTree INT13_tree=null;
        CommonTree INT14_tree=null;
        CommonTree LBRAC15_tree=null;
        CommonTree RBRAC17_tree=null;
        CommonTree STRING_LITERAL18_tree=null;
        CommonTree CHAR_LITERAL19_tree=null;
        CommonTree BOOL_LITERAL20_tree=null;
        CommonTree ID21_tree=null;
        RewriteRuleTokenStream stream_RBRAC = new RewriteRuleTokenStream(adaptor,"token RBRAC");
        RewriteRuleTokenStream stream_LBRAC = new RewriteRuleTokenStream(adaptor,"token LBRAC");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:32:5: ( MINUS_OP INT | INT | ( LBRAC )+ ( expr )+ RBRAC -> expr | STRING_LITERAL | CHAR_LITERAL | BOOL_LITERAL | ID )
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
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:32:9: MINUS_OP INT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	MINUS_OP12=(IToken)Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_atom182); 
                    		MINUS_OP12_tree = (CommonTree)adaptor.Create(MINUS_OP12);
                    		adaptor.AddChild(root_0, MINUS_OP12_tree);

                    	INT13=(IToken)Match(input,INT,FOLLOW_INT_in_atom184); 
                    		INT13_tree = (CommonTree)adaptor.Create(INT13);
                    		adaptor.AddChild(root_0, INT13_tree);


                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:34:2: INT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	INT14=(IToken)Match(input,INT,FOLLOW_INT_in_atom190); 
                    		INT14_tree = (CommonTree)adaptor.Create(INT14);
                    		adaptor.AddChild(root_0, INT14_tree);


                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:36:2: ( LBRAC )+ ( expr )+ RBRAC
                    {
                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:36:2: ( LBRAC )+
                    	int cnt5 = 0;
                    	do 
                    	{
                    	    int alt5 = 2;
                    	    int LA5_0 = input.LA(1);

                    	    if ( (LA5_0 == LBRAC) )
                    	    {
                    	        alt5 = 1;
                    	    }


                    	    switch (alt5) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:36:2: LBRAC
                    			    {
                    			    	LBRAC15=(IToken)Match(input,LBRAC,FOLLOW_LBRAC_in_atom196);  
                    			    	stream_LBRAC.Add(LBRAC15);


                    			    }
                    			    break;

                    			default:
                    			    if ( cnt5 >= 1 ) goto loop5;
                    		            EarlyExitException eee5 =
                    		                new EarlyExitException(5, input);
                    		            throw eee5;
                    	    }
                    	    cnt5++;
                    	} while (true);

                    	loop5:
                    		;	// Stops C# compiler whinging that label 'loop5' has no statements

                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:36:10: ( expr )+
                    	int cnt6 = 0;
                    	do 
                    	{
                    	    int alt6 = 2;
                    	    int LA6_0 = input.LA(1);

                    	    if ( (LA6_0 == ID || (LA6_0 >= MINUS_OP && LA6_0 <= LBRAC) || (LA6_0 >= STRING_LITERAL && LA6_0 <= BOOL_LITERAL)) )
                    	    {
                    	        alt6 = 1;
                    	    }


                    	    switch (alt6) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:36:10: expr
                    			    {
                    			    	PushFollow(FOLLOW_expr_in_atom200);
                    			    	expr16 = expr();
                    			    	state.followingStackPointer--;

                    			    	stream_expr.Add(expr16.Tree);

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

                    	RBRAC17=(IToken)Match(input,RBRAC,FOLLOW_RBRAC_in_atom204);  
                    	stream_RBRAC.Add(RBRAC17);



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

                    	STRING_LITERAL18=(IToken)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_atom214); 
                    		STRING_LITERAL18_tree = (CommonTree)adaptor.Create(STRING_LITERAL18);
                    		adaptor.AddChild(root_0, STRING_LITERAL18_tree);


                    }
                    break;
                case 5 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:40:2: CHAR_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	CHAR_LITERAL19=(IToken)Match(input,CHAR_LITERAL,FOLLOW_CHAR_LITERAL_in_atom220); 
                    		CHAR_LITERAL19_tree = (CommonTree)adaptor.Create(CHAR_LITERAL19);
                    		adaptor.AddChild(root_0, CHAR_LITERAL19_tree);


                    }
                    break;
                case 6 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:42:2: BOOL_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	BOOL_LITERAL20=(IToken)Match(input,BOOL_LITERAL,FOLLOW_BOOL_LITERAL_in_atom226); 
                    		BOOL_LITERAL20_tree = (CommonTree)adaptor.Create(BOOL_LITERAL20);
                    		adaptor.AddChild(root_0, BOOL_LITERAL20_tree);


                    }
                    break;
                case 7 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:44:2: ID
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	ID21=(IToken)Match(input,ID,FOLLOW_ID_in_atom232); 
                    		ID21_tree = (CommonTree)adaptor.Create(ID21);
                    		adaptor.AddChild(root_0, ID21_tree);


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

 

    public static readonly BitSet FOLLOW_stat_in_prog61 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_stat77 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_stat89 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ID_in_stat93 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_EQUALS_in_stat95 = new BitSet(new ulong[]{0x0000000000001DD0UL});
    public static readonly BitSet FOLLOW_expr_in_stat97 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multExpr_in_expr122 = new BitSet(new ulong[]{0x0000000000002042UL});
    public static readonly BitSet FOLLOW_ARITH_OP_in_expr126 = new BitSet(new ulong[]{0x0000000000001DD0UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_expr129 = new BitSet(new ulong[]{0x0000000000001DD0UL});
    public static readonly BitSet FOLLOW_multExpr_in_expr133 = new BitSet(new ulong[]{0x0000000000002042UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr154 = new BitSet(new ulong[]{0x000000000001C002UL});
    public static readonly BitSet FOLLOW_set_in_multExpr157 = new BitSet(new ulong[]{0x0000000000001DD0UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr166 = new BitSet(new ulong[]{0x000000000001C002UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_atom182 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_INT_in_atom184 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_atom190 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRAC_in_atom196 = new BitSet(new ulong[]{0x0000000000001DD0UL});
    public static readonly BitSet FOLLOW_expr_in_atom200 = new BitSet(new ulong[]{0x0000000000001FD0UL});
    public static readonly BitSet FOLLOW_RBRAC_in_atom204 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_atom214 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_LITERAL_in_atom220 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOL_LITERAL_in_atom226 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_atom232 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}