// $ANTLR 3.1.2 C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g 2009-04-05 22:43:40

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
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:16:11: expr
            			    {
            			    	Generator.BeginExpression();
            			    	PushFollow(FOLLOW_expr_in_prog47);
            			    	expr();
            			    	state.followingStackPointer--;

            			    	 Generator.EndExpression(); 

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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:1: expr : ( ( (l= literal ) ) (b= binop e= expr )* ) ;
    public void expr() // throws RecognitionException [1]
    {   
        DecafParser.literal_return l = default(DecafParser.literal_return);

        string b = default(string);


        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:6: ( ( ( (l= literal ) ) (b= binop e= expr )* ) )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:8: ( ( (l= literal ) ) (b= binop e= expr )* )
            {
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:8: ( ( (l= literal ) ) (b= binop e= expr )* )
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:9: ( (l= literal ) ) (b= binop e= expr )*
            	{
            		// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:9: ( (l= literal ) )
            		// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:10: (l= literal )
            		{
            			// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:10: (l= literal )
            			// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:11: l= literal
            			{
            				PushFollow(FOLLOW_literal_in_expr65);
            				l = literal();
            				state.followingStackPointer--;


            			}


            		}

            		// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:24: (b= binop e= expr )*
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
            				    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:25: b= binop e= expr
            				    {
            				    	PushFollow(FOLLOW_binop_in_expr73);
            				    	b = binop();
            				    	state.followingStackPointer--;

            				    	PushFollow(FOLLOW_expr_in_expr77);
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

            		 Generator.ExprNumber(int.Parse(((l != null) ? input.ToString((IToken)(l.Start),(IToken)(l.Stop)) : null))); if(b != null){Generator.Operation(b);};

            	}


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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:20:1: binop returns [string value] : ARITH_OP ;
    public string binop() // throws RecognitionException [1]
    {   
        string value = default(string);

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:20:30: ( ARITH_OP )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:20:33: ARITH_OP
            {
            	Match(input,ARITH_OP,FOLLOW_ARITH_OP_in_binop97); 
            	value =  "Addition";

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
    // $ANTLR end "binop"

    public class literal_return : ParserRuleReturnScope
    {
        public int value;
    };

    // $ANTLR start "literal"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:25:1: literal returns [int value] : int_literal ;
    public DecafParser.literal_return literal() // throws RecognitionException [1]
    {   
        DecafParser.literal_return retval = new DecafParser.literal_return();
        retval.Start = input.LT(1);

        DecafParser.int_literal_return int_literal1 = default(DecafParser.int_literal_return);


        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:25:28: ( int_literal )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:25:31: int_literal
            {
            	PushFollow(FOLLOW_int_literal_in_literal122);
            	int_literal1 = int_literal();
            	state.followingStackPointer--;

            	 retval.value =  int.Parse(((int_literal1 != null) ? input.ToString((IToken)(int_literal1.Start),(IToken)(int_literal1.Stop)) : null));

            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "literal"

    public class int_literal_return : ParserRuleReturnScope
    {
    };

    // $ANTLR start "int_literal"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:27:1: int_literal : decimal_literal ;
    public DecafParser.int_literal_return int_literal() // throws RecognitionException [1]
    {   
        DecafParser.int_literal_return retval = new DecafParser.int_literal_return();
        retval.Start = input.LT(1);

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:27:13: ( decimal_literal )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:27:16: decimal_literal
            {
            	PushFollow(FOLLOW_decimal_literal_in_int_literal133);
            	decimal_literal();
            	state.followingStackPointer--;


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "int_literal"


    // $ANTLR start "decimal_literal"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:29:1: decimal_literal returns [int value] : ( DIGIT )+ ;
    public int decimal_literal() // throws RecognitionException [1]
    {   
        int value = default(int);

        IToken DIGIT2 = null;

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
            			    	DIGIT2=(IToken)Match(input,DIGIT,FOLLOW_DIGIT_in_decimal_literal147); 

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

            	value =  int.Parse(((DIGIT2 != null) ? DIGIT2.Text : null));

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

 

    public static readonly BitSet FOLLOW_expr_in_prog47 = new BitSet(new ulong[]{0x0000000000000022UL});
    public static readonly BitSet FOLLOW_literal_in_expr65 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_binop_in_expr73 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_expr_in_expr77 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_ARITH_OP_in_binop97 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_literal_in_literal122 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_decimal_literal_in_int_literal133 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DIGIT_in_decimal_literal147 = new BitSet(new ulong[]{0x0000000000000022UL});

}
}