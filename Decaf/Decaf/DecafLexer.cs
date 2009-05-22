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


public partial class DecafLexer : Lexer {
    public const int ALPHA_NUM = 24;
    public const int CLASS = 5;
    public const int MULT_OP = 19;
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
    public const int STRING_LITERAL = 13;
    public const int WS = 25;
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

    // $ANTLR start "T__26"
    public void mT__26() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__26;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:11:7: ( 'public' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:11:9: 'public'
            {
            	Match("public"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__26"

    // $ANTLR start "T__27"
    public void mT__27() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__27;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:12:7: ( 'class' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:12:9: 'class'
            {
            	Match("class"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__27"

    // $ANTLR start "T__28"
    public void mT__28() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__28;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:13:7: ( '{' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:13:9: '{'
            {
            	Match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__28"

    // $ANTLR start "T__29"
    public void mT__29() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__29;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:14:7: ( '}' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:14:9: '}'
            {
            	Match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__29"

    // $ANTLR start "T__30"
    public void mT__30() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__30;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:15:7: ( '(){' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:15:9: '(){'
            {
            	Match("(){"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__30"

    // $ANTLR start "START"
    public void mSTART() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = START;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:64:8: ( 'start' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:64:11: 'start'
            {
            	Match("start"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "START"

    // $ANTLR start "END"
    public void mEND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = END;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:65:5: ( 'end' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:65:7: 'end'
            {
            	Match("end"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "END"

    // $ANTLR start "ARITH_OP"
    public void mARITH_OP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ARITH_OP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:68:2: ( '+' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:68:5: '+'
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
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:70:9: ( '-' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:70:12: '-'
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
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:72:9: ( '*' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:72:12: '*'
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
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:73:9: ( '/' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:73:12: '/'
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
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:74:9: ( '%' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:74:11: '%'
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

    // $ANTLR start "EQUALS"
    public void mEQUALS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EQUALS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:76:9: ( '=' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:76:11: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EQUALS"

    // $ANTLR start "EOS"
    public void mEOS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EOS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:78:5: ( ';' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:78:7: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EOS"

    // $ANTLR start "CALLOUT"
    public void mCALLOUT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CALLOUT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:105:9: ( 'callout' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:105:11: 'callout'
            {
            	Match("callout"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CALLOUT"

    // $ANTLR start "BOOL_LITERAL"
    public void mBOOL_LITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BOOL_LITERAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:108:2: ( 'true' | 'false' )
            int alt1 = 2;
            int LA1_0 = input.LA(1);

            if ( (LA1_0 == 't') )
            {
                alt1 = 1;
            }
            else if ( (LA1_0 == 'f') )
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
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:108:4: 'true'
                    {
                    	Match("true"); 


                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:108:13: 'false'
                    {
                    	Match("false"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BOOL_LITERAL"

    // $ANTLR start "LBRAC"
    public void mLBRAC() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LBRAC;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:110:7: ( '(' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:110:10: '('
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
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:111:8: ( ')' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:111:11: ')'
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

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:113:4: ( ALPHA ( ALPHA_NUM )* )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:113:6: ALPHA ( ALPHA_NUM )*
            {
            	mALPHA(); 
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:113:12: ( ALPHA_NUM )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == '.' || (LA2_0 >= '0' && LA2_0 <= '9') || (LA2_0 >= 'A' && LA2_0 <= 'Z') || LA2_0 == '_' || (LA2_0 >= 'a' && LA2_0 <= 'z')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:113:12: ALPHA_NUM
            			    {
            			    	mALPHA_NUM(); 

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ID"

    // $ANTLR start "ALPHA_NUM"
    public void mALPHA_NUM() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:116:2: ( ALPHA | INT )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( (LA3_0 == '.' || (LA3_0 >= 'A' && LA3_0 <= 'Z') || LA3_0 == '_' || (LA3_0 >= 'a' && LA3_0 <= 'z')) )
            {
                alt3 = 1;
            }
            else if ( ((LA3_0 >= '0' && LA3_0 <= '9')) )
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
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:116:5: ALPHA
                    {
                    	mALPHA(); 

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:116:13: INT
                    {
                    	mINT(); 

                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ALPHA_NUM"

    // $ANTLR start "ALPHA"
    public void mALPHA() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:118:17: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '.' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:
            {
            	if ( input.LA(1) == '.' || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "ALPHA"

    // $ANTLR start "INT"
    public void mINT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:120:5: ( ( '0' .. '9' )+ )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:120:9: ( '0' .. '9' )+
            {
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:120:9: ( '0' .. '9' )+
            	int cnt4 = 0;
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( ((LA4_0 >= '0' && LA4_0 <= '9')) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:120:9: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

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


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INT"

    // $ANTLR start "STRING_LITERAL"
    public void mSTRING_LITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STRING_LITERAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:123:16: ( '\\\"' ( . )* '\\\"' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:123:18: '\\\"' ( . )* '\\\"'
            {
            	Match('\"'); 
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:123:23: ( . )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == '\"') )
            	    {
            	        alt5 = 2;
            	    }
            	    else if ( ((LA5_0 >= '\u0000' && LA5_0 <= '!') || (LA5_0 >= '#' && LA5_0 <= '\uFFFF')) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:123:23: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements

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
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:126:2: ( ( '\\'' )+ ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' ) '\\'' )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:126:5: ( '\\'' )+ ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' ) '\\''
            {
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:126:5: ( '\\'' )+
            	int cnt6 = 0;
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( (LA6_0 == '\'') )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:126:5: '\\''
            			    {
            			    	Match('\''); 

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

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:128:5: ( ( ' ' | '\\t' )+ )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:128:9: ( ' ' | '\\t' )+
            {
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:128:9: ( ' ' | '\\t' )+
            	int cnt7 = 0;
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == '\t' || LA7_0 == ' ') )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:
            			    {
            			    	if ( input.LA(1) == '\t' || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


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

            	 Skip(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    override public void mTokens() // throws RecognitionException 
    {
        // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:8: ( T__26 | T__27 | T__28 | T__29 | T__30 | START | END | ARITH_OP | MINUS_OP | MULT_OP | DIV_OP | REM_OP | EQUALS | EOS | CALLOUT | BOOL_LITERAL | LBRAC | RBRAC | ID | INT | STRING_LITERAL | CHAR_LITERAL | WS )
        int alt8 = 23;
        alt8 = dfa8.Predict(input);
        switch (alt8) 
        {
            case 1 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:10: T__26
                {
                	mT__26(); 

                }
                break;
            case 2 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:16: T__27
                {
                	mT__27(); 

                }
                break;
            case 3 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:22: T__28
                {
                	mT__28(); 

                }
                break;
            case 4 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:28: T__29
                {
                	mT__29(); 

                }
                break;
            case 5 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:34: T__30
                {
                	mT__30(); 

                }
                break;
            case 6 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:40: START
                {
                	mSTART(); 

                }
                break;
            case 7 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:46: END
                {
                	mEND(); 

                }
                break;
            case 8 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:50: ARITH_OP
                {
                	mARITH_OP(); 

                }
                break;
            case 9 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:59: MINUS_OP
                {
                	mMINUS_OP(); 

                }
                break;
            case 10 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:68: MULT_OP
                {
                	mMULT_OP(); 

                }
                break;
            case 11 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:76: DIV_OP
                {
                	mDIV_OP(); 

                }
                break;
            case 12 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:83: REM_OP
                {
                	mREM_OP(); 

                }
                break;
            case 13 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:90: EQUALS
                {
                	mEQUALS(); 

                }
                break;
            case 14 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:97: EOS
                {
                	mEOS(); 

                }
                break;
            case 15 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:101: CALLOUT
                {
                	mCALLOUT(); 

                }
                break;
            case 16 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:109: BOOL_LITERAL
                {
                	mBOOL_LITERAL(); 

                }
                break;
            case 17 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:122: LBRAC
                {
                	mLBRAC(); 

                }
                break;
            case 18 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:128: RBRAC
                {
                	mRBRAC(); 

                }
                break;
            case 19 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:134: ID
                {
                	mID(); 

                }
                break;
            case 20 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:137: INT
                {
                	mINT(); 

                }
                break;
            case 21 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:141: STRING_LITERAL
                {
                	mSTRING_LITERAL(); 

                }
                break;
            case 22 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:156: CHAR_LITERAL
                {
                	mCHAR_LITERAL(); 

                }
                break;
            case 23 :
                // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:1:169: WS
                {
                	mWS(); 

                }
                break;

        }

    }


    protected DFA8 dfa8;
	private void InitializeCyclicDFAs()
	{
	    this.dfa8 = new DFA8(this);
	}

    const string DFA8_eotS =
        "\x01\uffff\x02\x12\x02\uffff\x01\x1b\x02\x12\x07\uffff\x02\x12"+
        "\x06\uffff\x03\x12\x02\uffff\x08\x12\x01\x2b\x06\x12\x01\uffff\x01"+
        "\x32\x02\x12\x01\x35\x01\x12\x01\x37\x01\uffff\x01\x32\x01\x38\x01"+
        "\uffff\x01\x12\x02\uffff\x01\x3a\x01\uffff";
    const string DFA8_eofS =
        "\x3b\uffff";
    const string DFA8_minS =
        "\x01\x09\x01\x75\x01\x61\x02\uffff\x01\x29\x01\x74\x01\x6e\x07"+
        "\uffff\x01\x72\x01\x61\x06\uffff\x01\x62\x01\x61\x01\x6c\x02\uffff"+
        "\x01\x61\x01\x64\x01\x75\x02\x6c\x01\x73\x01\x6c\x01\x72\x01\x2e"+
        "\x01\x65\x01\x73\x01\x69\x01\x73\x01\x6f\x01\x74\x01\uffff\x01\x2e"+
        "\x01\x65\x01\x63\x01\x2e\x01\x75\x01\x2e\x01\uffff\x02\x2e\x01\uffff"+
        "\x01\x74\x02\uffff\x01\x2e\x01\uffff";
    const string DFA8_maxS =
        "\x01\x7d\x01\x75\x01\x6c\x02\uffff\x01\x29\x01\x74\x01\x6e\x07"+
        "\uffff\x01\x72\x01\x61\x06\uffff\x01\x62\x01\x61\x01\x6c\x02\uffff"+
        "\x01\x61\x01\x64\x01\x75\x02\x6c\x01\x73\x01\x6c\x01\x72\x01\x7a"+
        "\x01\x65\x01\x73\x01\x69\x01\x73\x01\x6f\x01\x74\x01\uffff\x01\x7a"+
        "\x01\x65\x01\x63\x01\x7a\x01\x75\x01\x7a\x01\uffff\x02\x7a\x01\uffff"+
        "\x01\x74\x02\uffff\x01\x7a\x01\uffff";
    const string DFA8_acceptS =
        "\x03\uffff\x01\x03\x01\x04\x03\uffff\x01\x08\x01\x09\x01\x0a\x01"+
        "\x0b\x01\x0c\x01\x0d\x01\x0e\x02\uffff\x01\x12\x01\x13\x01\x14\x01"+
        "\x15\x01\x16\x01\x17\x03\uffff\x01\x05\x01\x11\x0f\uffff\x01\x07"+
        "\x06\uffff\x01\x10\x02\uffff\x01\x02\x01\uffff\x01\x06\x01\x01\x01"+
        "\uffff\x01\x0f";
    const string DFA8_specialS =
        "\x3b\uffff}>";
    static readonly string[] DFA8_transitionS = {
            "\x01\x16\x16\uffff\x01\x16\x01\uffff\x01\x14\x02\uffff\x01"+
            "\x0c\x01\uffff\x01\x15\x01\x05\x01\x11\x01\x0a\x01\x08\x01\uffff"+
            "\x01\x09\x01\x12\x01\x0b\x0a\x13\x01\uffff\x01\x0e\x01\uffff"+
            "\x01\x0d\x03\uffff\x1a\x12\x04\uffff\x01\x12\x01\uffff\x02\x12"+
            "\x01\x02\x01\x12\x01\x07\x01\x10\x09\x12\x01\x01\x02\x12\x01"+
            "\x06\x01\x0f\x06\x12\x01\x03\x01\uffff\x01\x04",
            "\x01\x17",
            "\x01\x19\x0a\uffff\x01\x18",
            "",
            "",
            "\x01\x1a",
            "\x01\x1c",
            "\x01\x1d",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x1e",
            "\x01\x1f",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x20",
            "\x01\x21",
            "\x01\x22",
            "",
            "",
            "\x01\x23",
            "\x01\x24",
            "\x01\x25",
            "\x01\x26",
            "\x01\x27",
            "\x01\x28",
            "\x01\x29",
            "\x01\x2a",
            "\x01\x12\x01\uffff\x0a\x12\x07\uffff\x1a\x12\x04\uffff\x01"+
            "\x12\x01\uffff\x1a\x12",
            "\x01\x2c",
            "\x01\x2d",
            "\x01\x2e",
            "\x01\x2f",
            "\x01\x30",
            "\x01\x31",
            "",
            "\x01\x12\x01\uffff\x0a\x12\x07\uffff\x1a\x12\x04\uffff\x01"+
            "\x12\x01\uffff\x1a\x12",
            "\x01\x33",
            "\x01\x34",
            "\x01\x12\x01\uffff\x0a\x12\x07\uffff\x1a\x12\x04\uffff\x01"+
            "\x12\x01\uffff\x1a\x12",
            "\x01\x36",
            "\x01\x12\x01\uffff\x0a\x12\x07\uffff\x1a\x12\x04\uffff\x01"+
            "\x12\x01\uffff\x1a\x12",
            "",
            "\x01\x12\x01\uffff\x0a\x12\x07\uffff\x1a\x12\x04\uffff\x01"+
            "\x12\x01\uffff\x1a\x12",
            "\x01\x12\x01\uffff\x0a\x12\x07\uffff\x1a\x12\x04\uffff\x01"+
            "\x12\x01\uffff\x1a\x12",
            "",
            "\x01\x39",
            "",
            "",
            "\x01\x12\x01\uffff\x0a\x12\x07\uffff\x1a\x12\x04\uffff\x01"+
            "\x12\x01\uffff\x1a\x12",
            ""
    };

    static readonly short[] DFA8_eot = DFA.UnpackEncodedString(DFA8_eotS);
    static readonly short[] DFA8_eof = DFA.UnpackEncodedString(DFA8_eofS);
    static readonly char[] DFA8_min = DFA.UnpackEncodedStringToUnsignedChars(DFA8_minS);
    static readonly char[] DFA8_max = DFA.UnpackEncodedStringToUnsignedChars(DFA8_maxS);
    static readonly short[] DFA8_accept = DFA.UnpackEncodedString(DFA8_acceptS);
    static readonly short[] DFA8_special = DFA.UnpackEncodedString(DFA8_specialS);
    static readonly short[][] DFA8_transition = DFA.UnpackEncodedStringArray(DFA8_transitionS);

    protected class DFA8 : DFA
    {
        public DFA8(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 8;
            this.eot = DFA8_eot;
            this.eof = DFA8_eof;
            this.min = DFA8_min;
            this.max = DFA8_max;
            this.accept = DFA8_accept;
            this.special = DFA8_special;
            this.transition = DFA8_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__26 | T__27 | T__28 | T__29 | T__30 | START | END | ARITH_OP | MINUS_OP | MULT_OP | DIV_OP | REM_OP | EQUALS | EOS | CALLOUT | BOOL_LITERAL | LBRAC | RBRAC | ID | INT | STRING_LITERAL | CHAR_LITERAL | WS );"; }
        }

    }

 
    
}
}