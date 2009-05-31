// $ANTLR 3.1.2 C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g 2009-04-10 23:23:54

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162

using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class ExprParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"NEWLINE", 
		"ID", 
		"INT", 
		"WS", 
		"'='", 
		"'+'", 
		"'-'", 
		"'*'", 
		"'('", 
		"')'"
    };

    public const int WS = 7;
    public const int NEWLINE = 4;
    public const int T__12 = 12;
    public const int T__11 = 11;
    public const int T__13 = 13;
    public const int T__10 = 10;
    public const int INT = 6;
    public const int ID = 5;
    public const int EOF = -1;
    public const int T__9 = 9;
    public const int T__8 = 8;

    // delegates
    // delegators



        public ExprParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public ExprParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        

    override public string[] TokenNames {
		get { return ExprParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g"; }
    }


    /** Map variable name to Integer object holding value */
    private Dictionary<string, int> memory = new Dictionary<string, int>();



    // $ANTLR start "prog"
    // C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:17:1: prog : ( stat )+ ;
    public void prog() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:17:5: ( ( stat )+ )
            // C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:17:9: ( stat )+
            {
            	// C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:17:9: ( stat )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= NEWLINE && LA1_0 <= INT) || LA1_0 == 10 || LA1_0 == 12) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:17:9: stat
            			    {
            			    	PushFollow(FOLLOW_stat_in_prog37);
            			    	stat();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whinging that label 'loop1' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "prog"


    // $ANTLR start "stat"
    // C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:19:1: stat : ( expr NEWLINE | ID '=' expr NEWLINE | NEWLINE );
    public void stat() // throws RecognitionException [1]
    {   
        IToken ID2 = null;
        int expr1 = default(int);

        int expr3 = default(int);


        try 
    	{
            // C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:19:5: ( expr NEWLINE | ID '=' expr NEWLINE | NEWLINE )
            int alt2 = 3;
            switch ( input.LA(1) ) 
            {
            case INT:
            case 10:
            case 12:
            	{
                alt2 = 1;
                }
                break;
            case ID:
            	{
                int LA2_2 = input.LA(2);

                if ( (LA2_2 == 8) )
                {
                    alt2 = 2;
                }
                else if ( (LA2_2 == NEWLINE || (LA2_2 >= 9 && LA2_2 <= 11)) )
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
                break;
            case NEWLINE:
            	{
                alt2 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("", 2, 0, input);

            	    throw nvae_d2s0;
            }

            switch (alt2) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:19:9: expr NEWLINE
                    {
                    	PushFollow(FOLLOW_expr_in_stat64);
                    	expr1 = expr();
                    	state.followingStackPointer--;

                    	Match(input,NEWLINE,FOLLOW_NEWLINE_in_stat66); 
                    	Console.WriteLine(expr1);

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:20:9: ID '=' expr NEWLINE
                    {
                    	ID2=(IToken)Match(input,ID,FOLLOW_ID_in_stat78); 
                    	Match(input,8,FOLLOW_8_in_stat80); 
                    	PushFollow(FOLLOW_expr_in_stat82);
                    	expr3 = expr();
                    	state.followingStackPointer--;

                    	Match(input,NEWLINE,FOLLOW_NEWLINE_in_stat84); 
                    	memory.Add(((ID2 != null) ? ID2.Text : null), expr3);

                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:22:9: NEWLINE
                    {
                    	Match(input,NEWLINE,FOLLOW_NEWLINE_in_stat104); 

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "stat"


    // $ANTLR start "expr"
    // C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:25:1: expr returns [int value] : e= multExpr ( '+' e= multExpr | '-' e= multExpr )* ;
    public int expr() // throws RecognitionException [1]
    {   
        int value = default(int);

        int e = default(int);


        try 
    	{
            // C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:26:5: (e= multExpr ( '+' e= multExpr | '-' e= multExpr )* )
            // C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:26:9: e= multExpr ( '+' e= multExpr | '-' e= multExpr )*
            {
            	PushFollow(FOLLOW_multExpr_in_expr129);
            	e = multExpr();
            	state.followingStackPointer--;

            	value =  e;
            	// C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:27:9: ( '+' e= multExpr | '-' e= multExpr )*
            	do 
            	{
            	    int alt3 = 3;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == 9) )
            	    {
            	        alt3 = 1;
            	    }
            	    else if ( (LA3_0 == 10) )
            	    {
            	        alt3 = 2;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:27:13: '+' e= multExpr
            			    {
            			    	Match(input,9,FOLLOW_9_in_expr145); 
            			    	PushFollow(FOLLOW_multExpr_in_expr149);
            			    	e = multExpr();
            			    	state.followingStackPointer--;

            			    	value += e;

            			    }
            			    break;
            			case 2 :
            			    // C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:28:13: '-' e= multExpr
            			    {
            			    	Match(input,10,FOLLOW_10_in_expr165); 
            			    	PushFollow(FOLLOW_multExpr_in_expr169);
            			    	e = multExpr();
            			    	state.followingStackPointer--;

            			    	value -= e;

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "expr"


    // $ANTLR start "multExpr"
    // C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:32:1: multExpr returns [int value] : e= atom ( '*' e= atom )* ;
    public int multExpr() // throws RecognitionException [1]
    {   
        int value = default(int);

        int e = default(int);


        try 
    	{
            // C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:33:5: (e= atom ( '*' e= atom )* )
            // C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:33:9: e= atom ( '*' e= atom )*
            {
            	PushFollow(FOLLOW_atom_in_multExpr207);
            	e = atom();
            	state.followingStackPointer--;

            	value =  e;
            	// C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:33:37: ( '*' e= atom )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == 11) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:33:38: '*' e= atom
            			    {
            			    	Match(input,11,FOLLOW_11_in_multExpr212); 
            			    	PushFollow(FOLLOW_atom_in_multExpr216);
            			    	e = atom();
            			    	state.followingStackPointer--;

            			    	value *= e;

            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "multExpr"


    // $ANTLR start "atom"
    // C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:36:1: atom returns [int value] : ( '-' INT | INT | ID | '(' expr ')' );
    public int atom() // throws RecognitionException [1]
    {   
        int value = default(int);

        IToken INT4 = null;
        IToken INT5 = null;
        IToken ID6 = null;
        int expr7 = default(int);


        try 
    	{
            // C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:37:5: ( '-' INT | INT | ID | '(' expr ')' )
            int alt5 = 4;
            switch ( input.LA(1) ) 
            {
            case 10:
            	{
                alt5 = 1;
                }
                break;
            case INT:
            	{
                alt5 = 2;
                }
                break;
            case ID:
            	{
                alt5 = 3;
                }
                break;
            case 12:
            	{
                alt5 = 4;
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
                    // C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:37:9: '-' INT
                    {
                    	Match(input,10,FOLLOW_10_in_atom244); 
                    	INT4=(IToken)Match(input,INT,FOLLOW_INT_in_atom246); 
                    	value =  -int.Parse(((INT4 != null) ? INT4.Text : null));

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:38:8: INT
                    {
                    	INT5=(IToken)Match(input,INT,FOLLOW_INT_in_atom257); 
                    	value =  int.Parse(((INT5 != null) ? INT5.Text : null));

                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:39:9: ID
                    {
                    	ID6=(IToken)Match(input,ID,FOLLOW_ID_in_atom269); 

                    	        int v = memory[((ID6 != null) ? ID6.Text : null)];
                    	        if ( v!=null ) value =  v;
                    	        else Console.WriteLine("undefined variable "+((ID6 != null) ? ID6.Text : null));
                    	        

                    }
                    break;
                case 4 :
                    // C:\\data\\code\\abcm\\Antlr\\Expression\\Expression\\Expr.g:45:9: '(' expr ')'
                    {
                    	Match(input,12,FOLLOW_12_in_atom289); 
                    	PushFollow(FOLLOW_expr_in_atom291);
                    	expr7 = expr();
                    	state.followingStackPointer--;

                    	Match(input,13,FOLLOW_13_in_atom293); 
                    	value =  expr7;

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "atom"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_stat_in_prog37 = new BitSet(new ulong[]{0x0000000000001472UL});
    public static readonly BitSet FOLLOW_expr_in_stat64 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_stat66 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_stat78 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_8_in_stat80 = new BitSet(new ulong[]{0x0000000000001460UL});
    public static readonly BitSet FOLLOW_expr_in_stat82 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_stat84 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_stat104 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multExpr_in_expr129 = new BitSet(new ulong[]{0x0000000000000602UL});
    public static readonly BitSet FOLLOW_9_in_expr145 = new BitSet(new ulong[]{0x0000000000001460UL});
    public static readonly BitSet FOLLOW_multExpr_in_expr149 = new BitSet(new ulong[]{0x0000000000000602UL});
    public static readonly BitSet FOLLOW_10_in_expr165 = new BitSet(new ulong[]{0x0000000000001460UL});
    public static readonly BitSet FOLLOW_multExpr_in_expr169 = new BitSet(new ulong[]{0x0000000000000602UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr207 = new BitSet(new ulong[]{0x0000000000000802UL});
    public static readonly BitSet FOLLOW_11_in_multExpr212 = new BitSet(new ulong[]{0x0000000000001460UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr216 = new BitSet(new ulong[]{0x0000000000000802UL});
    public static readonly BitSet FOLLOW_10_in_atom244 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_INT_in_atom246 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_atom257 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_atom269 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_12_in_atom289 = new BitSet(new ulong[]{0x0000000000001460UL});
    public static readonly BitSet FOLLOW_expr_in_atom291 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_13_in_atom293 = new BitSet(new ulong[]{0x0000000000000002UL});

}
