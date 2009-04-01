// $ANTLR 3.1.2 C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g 2009-04-01 22:32:16

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


public partial class DecafParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"ARITH_OP", 
		"DIGIT", 
		"STRING_LITERAL", 
		"CHAR_LITERAL"
    };

    public const int STRING_LITERAL = 6;
    public const int CHAR_LITERAL = 7;
    public const int ARITH_OP = 4;
    public const int DIGIT = 5;
    public const int EOF = -1;

    // delegates
    // delegators



        public DecafParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public DecafParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        

    override public string[] TokenNames {
		get { return DecafParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g"; }
    }



    // $ANTLR start "prog"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:16:1: prog : ( expr )+ ;
    public void prog() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:16:5: ( ( expr )+ )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:16:9: ( expr )+
            {
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:16:9: ( expr )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == DIGIT) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:16:9: expr
            			    {
            			    	PushFollow(FOLLOW_expr_in_prog43);
            			    	expr();
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


    // $ANTLR start "expr"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:1: expr : ( literal ) ( binop expr )* ;
    public void expr() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:6: ( ( literal ) ( binop expr )* )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:9: ( literal ) ( binop expr )*
            {
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:9: ( literal )
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:10: literal
            	{
            		PushFollow(FOLLOW_literal_in_expr55);
            		literal();
            		state.followingStackPointer--;


            	}

            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:19: ( binop expr )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == ARITH_OP) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:20: binop expr
            			    {
            			    	PushFollow(FOLLOW_binop_in_expr59);
            			    	binop();
            			    	state.followingStackPointer--;

            			    	PushFollow(FOLLOW_expr_in_expr61);
            			    	expr();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


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
    // $ANTLR end "expr"


    // $ANTLR start "binop"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:20:1: binop : ARITH_OP ;
    public void binop() // throws RecognitionException [1]
    {   
        IToken ARITH_OP1 = null;

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:20:7: ( ARITH_OP )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:20:10: ARITH_OP
            {
            	ARITH_OP1=(IToken)Match(input,ARITH_OP,FOLLOW_ARITH_OP_in_binop72); 
            	 Generator.Operator(((ARITH_OP1 != null) ? ARITH_OP1.Text : null));

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
    // $ANTLR end "binop"


    // $ANTLR start "literal"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:25:1: literal : int_literal ;
    public void literal() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:25:9: ( int_literal )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:25:12: int_literal
            {
            	PushFollow(FOLLOW_int_literal_in_literal93);
            	int_literal();
            	state.followingStackPointer--;


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
    // $ANTLR end "literal"


    // $ANTLR start "int_literal"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:27:1: int_literal : decimal_literal ;
    public void int_literal() // throws RecognitionException [1]
    {   
        int decimal_literal2 = default(int);


        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:27:13: ( decimal_literal )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:27:16: decimal_literal
            {
            	PushFollow(FOLLOW_decimal_literal_in_int_literal102);
            	decimal_literal2 = decimal_literal();
            	state.followingStackPointer--;

            	 Generator.OutputDigit(decimal_literal2);

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
    // $ANTLR end "int_literal"


    // $ANTLR start "decimal_literal"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:29:1: decimal_literal returns [int value] : ( DIGIT )+ ;
    public int decimal_literal() // throws RecognitionException [1]
    {   
        int value = default(int);

        IToken DIGIT3 = null;

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:30:2: ( ( DIGIT )+ )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:30:4: ( DIGIT )+
            {
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:30:4: ( DIGIT )+
            	int cnt3 = 0;
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == DIGIT) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:30:4: DIGIT
            			    {
            			    	DIGIT3=(IToken)Match(input,DIGIT,FOLLOW_DIGIT_in_decimal_literal118); 

            			    }
            			    break;

            			default:
            			    if ( cnt3 >= 1 ) goto loop3;
            		            EarlyExitException eee3 =
            		                new EarlyExitException(3, input);
            		            throw eee3;
            	    }
            	    cnt3++;
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whinging that label 'loop3' has no statements

            	value =  int.Parse(((DIGIT3 != null) ? DIGIT3.Text : null));

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
    // $ANTLR end "decimal_literal"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_expr_in_prog43 = new BitSet(new ulong[]{0x0000000000000022UL});
    public static readonly BitSet FOLLOW_literal_in_expr55 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_binop_in_expr59 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_expr_in_expr61 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_ARITH_OP_in_binop72 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_literal_in_literal93 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_decimal_literal_in_int_literal102 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DIGIT_in_decimal_literal118 = new BitSet(new ulong[]{0x0000000000000022UL});

}
}