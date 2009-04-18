// $ANTLR 3.1.2 C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g 2009-04-18 21:11:32

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


public partial class DecafLexer : Lexer {
    public const int MULT_OP = 7;
    public const int STRING_LITERAL = 4;
    public const int CHAR_LITERAL = 13;
    public const int DIV_OP = 8;
    public const int ARITH_OP = 5;
    public const int RBRAC = 11;
    public const int REM_OP = 9;
    public const int MINUS_OP = 6;
    public const int DIGIT = 12;
    public const int EOF = -1;
    public const int LBRAC = 10;

    // delegates
    // delegators

    public DecafLexer() 
    {
		InitializeCyclicDFAs();
    }
    public DecafLexer(ICharStream input)
		: this(input, null) {
    }
    public DecafLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g";} 
    }

    // $ANTLR start "ARITH_OP"
    public void mARITH_OP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ARITH_OP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:55:2: ( '+' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:55:5: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ARITH_OP"

    // $ANTLR start "MINUS_OP"
    public void mMINUS_OP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MINUS_OP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:57:9: ( '-' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:57:12: '-'
            {
            	Match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MINUS_OP"

    // $ANTLR start "MULT_OP"
    public void mMULT_OP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MULT_OP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:59:9: ( '*' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:59:12: '*'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MULT_OP"

    // $ANTLR start "DIV_OP"
    public void mDIV_OP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DIV_OP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:60:9: ( '/' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:60:12: '/'
            {
            	Match('/'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIV_OP"

    // $ANTLR start "REM_OP"
    public void mREM_OP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = REM_OP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:61:9: ( '%' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:61:11: '%'
            {
            	Match('%'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "REM_OP"

    // $ANTLR start "LBRAC"
    public void mLBRAC() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LBRAC;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:69:7: ( '(' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:69:10: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LBRAC"

    // $ANTLR start "RBRAC"
    public void mRBRAC() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RBRAC;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:70:8: ( ')' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:70:11: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RBRAC"

    // $ANTLR start "DIGIT"
    public void mDIGIT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DIGIT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:76:6: ( '0' .. '9' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:76:8: '0' .. '9'
            {
            	MatchRange('0','9'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIGIT"

    // $ANTLR start "STRING_LITERAL"
    public void mSTRING_LITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STRING_LITERAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:78:16: ( '\\\"' ( . )* '\\\"' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:78:18: '\\\"' ( . )* '\\\"'
            {
            	Match('\"'); 
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:78:23: ( . )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == '\"') )
            	    {
            	        alt1 = 2;
            	    }
            	    else if ( ((LA1_0 >= '\u0000' && LA1_0 <= '!') || (LA1_0 >= '#' && LA1_0 <= '\uFFFF')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:78:23: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	Match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STRING_LITERAL"

    // $ANTLR start "CHAR_LITERAL"
    public void mCHAR_LITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CHAR_LITERAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:81:2: ( ( '\\'' )+ ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' ) '\\'' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:81:5: ( '\\'' )+ ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' ) '\\''
            {
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:81:5: ( '\\'' )+
            	int cnt2 = 0;
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == '\'') )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:81:5: '\\''
            			    {
            			    	Match('\''); 

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

            	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	Match('\''); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CHAR_LITERAL"

    override public void mTokens() // throws RecognitionException 
    {
        // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:8: ( ARITH_OP | MINUS_OP | MULT_OP | DIV_OP | REM_OP | LBRAC | RBRAC | DIGIT | STRING_LITERAL | CHAR_LITERAL )
        int alt3 = 10;
        switch ( input.LA(1) ) 
        {
        case '+':
        	{
            alt3 = 1;
            }
            break;
        case '-':
        	{
            alt3 = 2;
            }
            break;
        case '*':
        	{
            alt3 = 3;
            }
            break;
        case '/':
        	{
            alt3 = 4;
            }
            break;
        case '%':
        	{
            alt3 = 5;
            }
            break;
        case '(':
        	{
            alt3 = 6;
            }
            break;
        case ')':
        	{
            alt3 = 7;
            }
            break;
        case '0':
        case '1':
        case '2':
        case '3':
        case '4':
        case '5':
        case '6':
        case '7':
        case '8':
        case '9':
        	{
            alt3 = 8;
            }
            break;
        case '\"':
        	{
            alt3 = 9;
            }
            break;
        case '\'':
        	{
            alt3 = 10;
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
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:10: ARITH_OP
                {
                	mARITH_OP(); 

                }
                break;
            case 2 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:19: MINUS_OP
                {
                	mMINUS_OP(); 

                }
                break;
            case 3 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:28: MULT_OP
                {
                	mMULT_OP(); 

                }
                break;
            case 4 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:36: DIV_OP
                {
                	mDIV_OP(); 

                }
                break;
            case 5 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:43: REM_OP
                {
                	mREM_OP(); 

                }
                break;
            case 6 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:50: LBRAC
                {
                	mLBRAC(); 

                }
                break;
            case 7 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:56: RBRAC
                {
                	mRBRAC(); 

                }
                break;
            case 8 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:62: DIGIT
                {
                	mDIGIT(); 

                }
                break;
            case 9 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:68: STRING_LITERAL
                {
                	mSTRING_LITERAL(); 

                }
                break;
            case 10 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:83: CHAR_LITERAL
                {
                	mCHAR_LITERAL(); 

                }
                break;

        }

    }


	private void InitializeCyclicDFAs()
	{
	}

 
    
}
}