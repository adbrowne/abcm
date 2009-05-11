// $ANTLR 3.1.2 C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g 2009-05-12 01:31:11

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
		"MINUS_OP", 
		"INT", 
		"LBRAC", 
		"RBRAC", 
		"STRING_LITERAL", 
		"CHAR_LITERAL", 
		"BOOL_LITERAL", 
		"ID", 
		"ARITH_OP", 
		"MULT_OP", 
		"DIV_OP", 
		"REM_OP", 
		"CALLOUT", 
		"ALPHA", 
		"ALPHA_NUM"
    };

    public const int ALPHA_NUM = 18;
    public const int MULT_OP = 13;
    public const int STRING_LITERAL = 8;
    public const int CHAR_LITERAL = 9;
    public const int DIV_OP = 14;
    public const int ARITH_OP = 12;
    public const int RBRAC = 7;
    public const int REM_OP = 15;
    public const int MINUS_OP = 4;
    public const int INT = 5;
    public const int BOOL_LITERAL = 10;
    public const int ID = 11;
    public const int EOF = -1;
    public const int LBRAC = 6;
    public const int ALPHA = 17;
    public const int CALLOUT = 16;

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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:21:1: stat : expr ;
    public DecafParser.stat_return stat() // throws RecognitionException [1]
    {   
        DecafParser.stat_return retval = new DecafParser.stat_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        DecafParser.expr_return expr2 = default(DecafParser.expr_return);



        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:21:5: ( expr )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:21:9: expr
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expr_in_stat77);
            	expr2 = expr();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expr2.Tree);

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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:23:1: expr : multExpr ( ( '+' | '-' ) multExpr )* ;
    public DecafParser.expr_return expr() // throws RecognitionException [1]
    {   
        DecafParser.expr_return retval = new DecafParser.expr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal4 = null;
        IToken char_literal5 = null;
        DecafParser.multExpr_return multExpr3 = default(DecafParser.multExpr_return);

        DecafParser.multExpr_return multExpr6 = default(DecafParser.multExpr_return);


        CommonTree char_literal4_tree=null;
        CommonTree char_literal5_tree=null;

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:23:5: ( multExpr ( ( '+' | '-' ) multExpr )* )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:23:9: multExpr ( ( '+' | '-' ) multExpr )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multExpr_in_expr86);
            	multExpr3 = multExpr();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, multExpr3.Tree);
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:23:18: ( ( '+' | '-' ) multExpr )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == MINUS_OP) )
            	    {
            	        int LA2_2 = input.LA(2);

            	        if ( ((LA2_2 >= MINUS_OP && LA2_2 <= LBRAC) || (LA2_2 >= STRING_LITERAL && LA2_2 <= ID)) )
            	        {
            	            alt2 = 1;
            	        }


            	    }
            	    else if ( (LA2_0 == ARITH_OP) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:23:19: ( '+' | '-' ) multExpr
            			    {
            			    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:23:19: ( '+' | '-' )
            			    	int alt1 = 2;
            			    	int LA1_0 = input.LA(1);

            			    	if ( (LA1_0 == ARITH_OP) )
            			    	{
            			    	    alt1 = 1;
            			    	}
            			    	else if ( (LA1_0 == MINUS_OP) )
            			    	{
            			    	    alt1 = 2;
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
            			    	        // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:23:20: '+'
            			    	        {
            			    	        	char_literal4=(IToken)Match(input,ARITH_OP,FOLLOW_ARITH_OP_in_expr90); 
            			    	        		char_literal4_tree = (CommonTree)adaptor.Create(char_literal4);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal4_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:23:25: '-'
            			    	        {
            			    	        	char_literal5=(IToken)Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_expr93); 
            			    	        		char_literal5_tree = (CommonTree)adaptor.Create(char_literal5);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal5_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multExpr_in_expr97);
            			    	multExpr6 = multExpr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, multExpr6.Tree);

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:26:1: multExpr : atom ( ( '*' | '/' | '%' ) atom )* ;
    public DecafParser.multExpr_return multExpr() // throws RecognitionException [1]
    {   
        DecafParser.multExpr_return retval = new DecafParser.multExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set8 = null;
        DecafParser.atom_return atom7 = default(DecafParser.atom_return);

        DecafParser.atom_return atom9 = default(DecafParser.atom_return);


        CommonTree set8_tree=null;

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:27:5: ( atom ( ( '*' | '/' | '%' ) atom )* )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:27:9: atom ( ( '*' | '/' | '%' ) atom )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_atom_in_multExpr118);
            	atom7 = atom();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, atom7.Tree);
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:27:14: ( ( '*' | '/' | '%' ) atom )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= MULT_OP && LA3_0 <= REM_OP)) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:27:15: ( '*' | '/' | '%' ) atom
            			    {
            			    	set8=(IToken)input.LT(1);
            			    	set8 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= MULT_OP && input.LA(1) <= REM_OP) ) 
            			    	{
            			    	    input.Consume();
            			    	    root_0 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(set8), root_0);
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_atom_in_multExpr130);
            			    	atom9 = atom();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, atom9.Tree);

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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:30:1: atom : ( MINUS_OP INT | INT | ( LBRAC )+ ( expr )+ RBRAC -> expr | STRING_LITERAL | CHAR_LITERAL | BOOL_LITERAL | ID );
    public DecafParser.atom_return atom() // throws RecognitionException [1]
    {   
        DecafParser.atom_return retval = new DecafParser.atom_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken MINUS_OP10 = null;
        IToken INT11 = null;
        IToken INT12 = null;
        IToken LBRAC13 = null;
        IToken RBRAC15 = null;
        IToken STRING_LITERAL16 = null;
        IToken CHAR_LITERAL17 = null;
        IToken BOOL_LITERAL18 = null;
        IToken ID19 = null;
        DecafParser.expr_return expr14 = default(DecafParser.expr_return);


        CommonTree MINUS_OP10_tree=null;
        CommonTree INT11_tree=null;
        CommonTree INT12_tree=null;
        CommonTree LBRAC13_tree=null;
        CommonTree RBRAC15_tree=null;
        CommonTree STRING_LITERAL16_tree=null;
        CommonTree CHAR_LITERAL17_tree=null;
        CommonTree BOOL_LITERAL18_tree=null;
        CommonTree ID19_tree=null;
        RewriteRuleTokenStream stream_RBRAC = new RewriteRuleTokenStream(adaptor,"token RBRAC");
        RewriteRuleTokenStream stream_LBRAC = new RewriteRuleTokenStream(adaptor,"token LBRAC");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:30:5: ( MINUS_OP INT | INT | ( LBRAC )+ ( expr )+ RBRAC -> expr | STRING_LITERAL | CHAR_LITERAL | BOOL_LITERAL | ID )
            int alt6 = 7;
            switch ( input.LA(1) ) 
            {
            case MINUS_OP:
            	{
                alt6 = 1;
                }
                break;
            case INT:
            	{
                alt6 = 2;
                }
                break;
            case LBRAC:
            	{
                alt6 = 3;
                }
                break;
            case STRING_LITERAL:
            	{
                alt6 = 4;
                }
                break;
            case CHAR_LITERAL:
            	{
                alt6 = 5;
                }
                break;
            case BOOL_LITERAL:
            	{
                alt6 = 6;
                }
                break;
            case ID:
            	{
                alt6 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d6s0 =
            	        new NoViableAltException("", 6, 0, input);

            	    throw nvae_d6s0;
            }

            switch (alt6) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:30:9: MINUS_OP INT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	MINUS_OP10=(IToken)Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_atom146); 
                    		MINUS_OP10_tree = (CommonTree)adaptor.Create(MINUS_OP10);
                    		adaptor.AddChild(root_0, MINUS_OP10_tree);

                    	INT11=(IToken)Match(input,INT,FOLLOW_INT_in_atom148); 
                    		INT11_tree = (CommonTree)adaptor.Create(INT11);
                    		adaptor.AddChild(root_0, INT11_tree);


                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:32:2: INT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	INT12=(IToken)Match(input,INT,FOLLOW_INT_in_atom154); 
                    		INT12_tree = (CommonTree)adaptor.Create(INT12);
                    		adaptor.AddChild(root_0, INT12_tree);


                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:34:2: ( LBRAC )+ ( expr )+ RBRAC
                    {
                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:34:2: ( LBRAC )+
                    	int cnt4 = 0;
                    	do 
                    	{
                    	    int alt4 = 2;
                    	    int LA4_0 = input.LA(1);

                    	    if ( (LA4_0 == LBRAC) )
                    	    {
                    	        alt4 = 1;
                    	    }


                    	    switch (alt4) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:34:2: LBRAC
                    			    {
                    			    	LBRAC13=(IToken)Match(input,LBRAC,FOLLOW_LBRAC_in_atom160);  
                    			    	stream_LBRAC.Add(LBRAC13);


                    			    }
                    			    break;

                    			default:
                    			    if ( cnt4 >= 1 ) goto loop4;
                    		            EarlyExitException eee4 =
                    		                new EarlyExitException(4, input);
                    		            throw eee4;
                    	    }
                    	    cnt4++;
                    	} while (true);

                    	loop4:
                    		;	// Stops C# compiler whinging that label 'loop4' has no statements

                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:34:10: ( expr )+
                    	int cnt5 = 0;
                    	do 
                    	{
                    	    int alt5 = 2;
                    	    int LA5_0 = input.LA(1);

                    	    if ( ((LA5_0 >= MINUS_OP && LA5_0 <= LBRAC) || (LA5_0 >= STRING_LITERAL && LA5_0 <= ID)) )
                    	    {
                    	        alt5 = 1;
                    	    }


                    	    switch (alt5) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:34:10: expr
                    			    {
                    			    	PushFollow(FOLLOW_expr_in_atom164);
                    			    	expr14 = expr();
                    			    	state.followingStackPointer--;

                    			    	stream_expr.Add(expr14.Tree);

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

                    	RBRAC15=(IToken)Match(input,RBRAC,FOLLOW_RBRAC_in_atom168);  
                    	stream_RBRAC.Add(RBRAC15);



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
                    	// 34:23: -> expr
                    	{
                    	    adaptor.AddChild(root_0, stream_expr.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 4 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:36:2: STRING_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	STRING_LITERAL16=(IToken)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_atom178); 
                    		STRING_LITERAL16_tree = (CommonTree)adaptor.Create(STRING_LITERAL16);
                    		adaptor.AddChild(root_0, STRING_LITERAL16_tree);


                    }
                    break;
                case 5 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:38:2: CHAR_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	CHAR_LITERAL17=(IToken)Match(input,CHAR_LITERAL,FOLLOW_CHAR_LITERAL_in_atom184); 
                    		CHAR_LITERAL17_tree = (CommonTree)adaptor.Create(CHAR_LITERAL17);
                    		adaptor.AddChild(root_0, CHAR_LITERAL17_tree);


                    }
                    break;
                case 6 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:40:2: BOOL_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	BOOL_LITERAL18=(IToken)Match(input,BOOL_LITERAL,FOLLOW_BOOL_LITERAL_in_atom190); 
                    		BOOL_LITERAL18_tree = (CommonTree)adaptor.Create(BOOL_LITERAL18);
                    		adaptor.AddChild(root_0, BOOL_LITERAL18_tree);


                    }
                    break;
                case 7 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:42:2: ID
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	ID19=(IToken)Match(input,ID,FOLLOW_ID_in_atom196); 
                    		ID19_tree = (CommonTree)adaptor.Create(ID19);
                    		adaptor.AddChild(root_0, ID19_tree);


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
    public static readonly BitSet FOLLOW_multExpr_in_expr86 = new BitSet(new ulong[]{0x0000000000001012UL});
    public static readonly BitSet FOLLOW_ARITH_OP_in_expr90 = new BitSet(new ulong[]{0x0000000000000F70UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_expr93 = new BitSet(new ulong[]{0x0000000000000F70UL});
    public static readonly BitSet FOLLOW_multExpr_in_expr97 = new BitSet(new ulong[]{0x0000000000001012UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr118 = new BitSet(new ulong[]{0x000000000000E002UL});
    public static readonly BitSet FOLLOW_set_in_multExpr121 = new BitSet(new ulong[]{0x0000000000000F70UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr130 = new BitSet(new ulong[]{0x000000000000E002UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_atom146 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_INT_in_atom148 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_atom154 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRAC_in_atom160 = new BitSet(new ulong[]{0x0000000000000F70UL});
    public static readonly BitSet FOLLOW_expr_in_atom164 = new BitSet(new ulong[]{0x0000000000000FF0UL});
    public static readonly BitSet FOLLOW_RBRAC_in_atom168 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_atom178 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_LITERAL_in_atom184 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOL_LITERAL_in_atom190 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_atom196 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}