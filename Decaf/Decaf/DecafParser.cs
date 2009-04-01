// $ANTLR 3.1.2 C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g 2009-04-01 21:33:41

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162

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
		"DIGIT", 
		"STRING_LITERAL", 
		"CHAR_LITERAL"
    };

    public const int STRING_LITERAL = 5;
    public const int DIGIT = 4;
    public const int CHAR_LITERAL = 6;
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:8:1: prog : ( expr )+ ;
    public void prog() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:8:5: ( ( expr )+ )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:8:9: ( expr )+
            {
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:8:9: ( expr )+
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
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:8:9: expr
            			    {
            			    	PushFollow(FOLLOW_expr_in_prog25);
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:10:1: expr : literal ;
    public void expr() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:10:6: ( literal )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:10:9: literal
            {
            	PushFollow(FOLLOW_literal_in_expr36);
            	literal();
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
    // $ANTLR end "expr"


    // $ANTLR start "literal"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:12:1: literal : int_literal ;
    public void literal() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:12:9: ( int_literal )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:12:12: int_literal
            {
            	PushFollow(FOLLOW_int_literal_in_literal45);
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:14:1: int_literal : decimal_literal ;
    public void int_literal() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:15:2: ( decimal_literal )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:15:5: decimal_literal
            {
            	PushFollow(FOLLOW_decimal_literal_in_int_literal55);
            	decimal_literal();
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
    // $ANTLR end "int_literal"


    // $ANTLR start "decimal_literal"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:17:2: decimal_literal : ( DIGIT )+ ;
    public void decimal_literal() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:17:17: ( ( DIGIT )+ )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:17:19: ( DIGIT )+
            {
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:17:19: ( DIGIT )+
            	int cnt2 = 0;
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == DIGIT) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:17:19: DIGIT
            			    {
            			    	Match(input,DIGIT,FOLLOW_DIGIT_in_decimal_literal64); 

            			    }
            			    break;

            			default:
            			    if ( cnt2 >= 1 ) goto loop2;
            		            EarlyExitException eee2 =
            		                new EarlyExitException(2, input);
            		            throw eee2;
            	    }
            	    cnt2++;
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whinging that label 'loop2' has no statements


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
    // $ANTLR end "decimal_literal"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_expr_in_prog25 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_literal_in_expr36 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_literal_in_literal45 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_decimal_literal_in_int_literal55 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DIGIT_in_decimal_literal64 = new BitSet(new ulong[]{0x0000000000000012UL});

}
