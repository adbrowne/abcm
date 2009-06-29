// $ANTLR 3.1.2 C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g 2009-06-29 14:38:10

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
namespace 
    CFlat

{

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class CFlatLexer : Lexer {
    public const int ALPHA_NUM = 29;
    public const int CLASS = 7;
    public const int MULT_OP = 24;
    public const int WHILE = 14;
    public const int DIV_OP = 25;
    public const int ARITH_OP = 23;
    public const int REM_OP = 26;
    public const int FOR = 15;
    public const int PARAM = 6;
    public const int INT = 19;
    public const int EQUALS = 16;
    public const int BOOL_LITERAL = 22;
    public const int ID = 8;
    public const int EOF = -1;
    public const int LBRAC = 12;
    public const int ALPHA = 28;
    public const int IF = 11;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int T__33 = 33;
    public const int STRING_LITERAL = 20;
    public const int WS = 30;
    public const int T__34 = 34;
    public const int CHAR_LITERAL = 21;
    public const int REL_OP = 17;
    public const int RBRAC = 13;
    public const int RETURN = 10;
    public const int EOS = 9;
    public const int MINUS_OP = 18;
    public const int CALL = 5;
    public const int METHOD = 4;
    public const int CALLOUT = 27;

    // delegates
    // delegators

    public CFlatLexer() 
    {
		InitializeCyclicDFAs();
    }
    public CFlatLexer(ICharStream input)
		: this(input, null) {
    }
    public CFlatLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g";} 
    }

    // $ANTLR start "T__31"
    public void mT__31() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__31;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:11:7: ( 'public' )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:11:9: 'public'
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
    // $ANTLR end "T__31"

    // $ANTLR start "T__32"
    public void mT__32() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__32;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:12:7: ( '{' )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:12:9: '{'
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
    // $ANTLR end "T__32"

    // $ANTLR start "T__33"
    public void mT__33() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__33;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:13:7: ( '}' )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:13:9: '}'
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
    // $ANTLR end "T__33"

    // $ANTLR start "T__34"
    public void mT__34() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__34;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:14:7: ( ',' )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:14:9: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__34"

    // $ANTLR start "CLASS"
    public void mCLASS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CLASS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:81:7: ( 'class' )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:81:9: 'class'
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
    // $ANTLR end "CLASS"

    // $ANTLR start "RETURN"
    public void mRETURN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RETURN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:83:9: ( 'return' )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:83:11: 'return'
            {
            	Match("return"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RETURN"

    // $ANTLR start "IF"
    public void mIF() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IF;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:85:4: ( 'if' )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:85:7: 'if'
            {
            	Match("if"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IF"

    // $ANTLR start "WHILE"
    public void mWHILE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WHILE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:87:7: ( 'while' )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:87:9: 'while'
            {
            	Match("while"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WHILE"

    // $ANTLR start "FOR"
    public void mFOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FOR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:89:5: ( 'for' )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:89:8: 'for'
            {
            	Match("for"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FOR"

    // $ANTLR start "ARITH_OP"
    public void mARITH_OP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ARITH_OP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:92:2: ( '+' )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:92:5: '+'
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
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:94:9: ( '-' )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:94:12: '-'
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
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:96:9: ( '*' )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:96:12: '*'
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
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:97:9: ( '/' )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:97:12: '/'
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
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:98:9: ( '%' )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:98:11: '%'
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

    // $ANTLR start "REL_OP"
    public void mREL_OP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = REL_OP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:100:8: ( '<' | '>' )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:
            {
            	if ( input.LA(1) == '<' || input.LA(1) == '>' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "REL_OP"

    // $ANTLR start "EQUALS"
    public void mEQUALS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EQUALS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:102:9: ( '=' )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:102:11: '='
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
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:104:5: ( ';' )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:104:7: ';'
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
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:106:9: ( 'callout' )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:106:11: 'callout'
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
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:109:2: ( 'true' | 'false' )
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
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:109:4: 'true'
                    {
                    	Match("true"); 


                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:109:13: 'false'
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
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:111:7: ( '(' )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:111:10: '('
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
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:112:8: ( ')' )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:112:11: ')'
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
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:114:4: ( ALPHA ( ALPHA_NUM )* )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:114:6: ALPHA ( ALPHA_NUM )*
            {
            	mALPHA(); 
            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:114:12: ( ALPHA_NUM )*
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
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:114:12: ALPHA_NUM
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
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:117:2: ( ALPHA | INT )
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
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:117:5: ALPHA
                    {
                    	mALPHA(); 

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:117:13: INT
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
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:119:17: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '.' )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:
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
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:121:5: ( ( '0' .. '9' )+ )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:121:9: ( '0' .. '9' )+
            {
            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:121:9: ( '0' .. '9' )+
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
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:121:9: '0' .. '9'
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
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:124:16: ( '\\\"' ( . )* '\\\"' )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:124:18: '\\\"' ( . )* '\\\"'
            {
            	Match('\"'); 
            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:124:23: ( . )*
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
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:124:23: .
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
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:127:2: ( ( '\\'' )+ ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' ) '\\'' )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:127:5: ( '\\'' )+ ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' ) '\\''
            {
            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:127:5: ( '\\'' )+
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
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:127:5: '\\''
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
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:129:5: ( ( ' ' | '\\t' | '\\r' | '\\n' )+ )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:129:9: ( ' ' | '\\t' | '\\r' | '\\n' )+
            {
            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:129:9: ( ' ' | '\\t' | '\\r' | '\\n' )+
            	int cnt7 = 0;
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( ((LA7_0 >= '\t' && LA7_0 <= '\n') || LA7_0 == '\r' || LA7_0 == ' ') )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
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
        // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:8: ( T__31 | T__32 | T__33 | T__34 | CLASS | RETURN | IF | WHILE | FOR | ARITH_OP | MINUS_OP | MULT_OP | DIV_OP | REM_OP | REL_OP | EQUALS | EOS | CALLOUT | BOOL_LITERAL | LBRAC | RBRAC | ID | INT | STRING_LITERAL | CHAR_LITERAL | WS )
        int alt8 = 26;
        alt8 = dfa8.Predict(input);
        switch (alt8) 
        {
            case 1 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:10: T__31
                {
                	mT__31(); 

                }
                break;
            case 2 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:16: T__32
                {
                	mT__32(); 

                }
                break;
            case 3 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:22: T__33
                {
                	mT__33(); 

                }
                break;
            case 4 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:28: T__34
                {
                	mT__34(); 

                }
                break;
            case 5 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:34: CLASS
                {
                	mCLASS(); 

                }
                break;
            case 6 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:40: RETURN
                {
                	mRETURN(); 

                }
                break;
            case 7 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:47: IF
                {
                	mIF(); 

                }
                break;
            case 8 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:50: WHILE
                {
                	mWHILE(); 

                }
                break;
            case 9 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:56: FOR
                {
                	mFOR(); 

                }
                break;
            case 10 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:60: ARITH_OP
                {
                	mARITH_OP(); 

                }
                break;
            case 11 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:69: MINUS_OP
                {
                	mMINUS_OP(); 

                }
                break;
            case 12 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:78: MULT_OP
                {
                	mMULT_OP(); 

                }
                break;
            case 13 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:86: DIV_OP
                {
                	mDIV_OP(); 

                }
                break;
            case 14 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:93: REM_OP
                {
                	mREM_OP(); 

                }
                break;
            case 15 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:100: REL_OP
                {
                	mREL_OP(); 

                }
                break;
            case 16 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:107: EQUALS
                {
                	mEQUALS(); 

                }
                break;
            case 17 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:114: EOS
                {
                	mEOS(); 

                }
                break;
            case 18 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:118: CALLOUT
                {
                	mCALLOUT(); 

                }
                break;
            case 19 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:126: BOOL_LITERAL
                {
                	mBOOL_LITERAL(); 

                }
                break;
            case 20 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:139: LBRAC
                {
                	mLBRAC(); 

                }
                break;
            case 21 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:145: RBRAC
                {
                	mRBRAC(); 

                }
                break;
            case 22 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:151: ID
                {
                	mID(); 

                }
                break;
            case 23 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:154: INT
                {
                	mINT(); 

                }
                break;
            case 24 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:158: STRING_LITERAL
                {
                	mSTRING_LITERAL(); 

                }
                break;
            case 25 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:173: CHAR_LITERAL
                {
                	mCHAR_LITERAL(); 

                }
                break;
            case 26 :
                // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:1:186: WS
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
        "\x01\uffff\x01\x15\x03\uffff\x05\x15\x08\uffff\x01\x15\x07\uffff"+
        "\x04\x15\x01\x27\x08\x15\x01\uffff\x01\x15\x01\x31\x07\x15\x01\uffff"+
        "\x01\x15\x01\x3a\x01\x15\x01\x3c\x02\x15\x01\x3f\x01\x3a\x01\uffff"+
        "\x01\x40\x01\uffff\x01\x15\x01\x42\x02\uffff\x01\x43\x02\uffff";
    const string DFA8_eofS =
        "\x44\uffff";
    const string DFA8_minS =
        "\x01\x09\x01\x75\x03\uffff\x01\x61\x01\x65\x01\x66\x01\x68\x01"+
        "\x61\x08\uffff\x01\x72\x07\uffff\x01\x62\x01\x61\x01\x6c\x01\x74"+
        "\x01\x2e\x01\x69\x01\x72\x01\x6c\x01\x75\x01\x6c\x01\x73\x01\x6c"+
        "\x01\x75\x01\uffff\x01\x6c\x01\x2e\x01\x73\x01\x65\x01\x69\x01\x73"+
        "\x01\x6f\x01\x72\x01\x65\x01\uffff\x01\x65\x01\x2e\x01\x63\x01\x2e"+
        "\x01\x75\x01\x6e\x02\x2e\x01\uffff\x01\x2e\x01\uffff\x01\x74\x01"+
        "\x2e\x02\uffff\x01\x2e\x02\uffff";
    const string DFA8_maxS =
        "\x01\x7d\x01\x75\x03\uffff\x01\x6c\x01\x65\x01\x66\x01\x68\x01"+
        "\x6f\x08\uffff\x01\x72\x07\uffff\x01\x62\x01\x61\x01\x6c\x01\x74"+
        "\x01\x7a\x01\x69\x01\x72\x01\x6c\x01\x75\x01\x6c\x01\x73\x01\x6c"+
        "\x01\x75\x01\uffff\x01\x6c\x01\x7a\x01\x73\x01\x65\x01\x69\x01\x73"+
        "\x01\x6f\x01\x72\x01\x65\x01\uffff\x01\x65\x01\x7a\x01\x63\x01\x7a"+
        "\x01\x75\x01\x6e\x02\x7a\x01\uffff\x01\x7a\x01\uffff\x01\x74\x01"+
        "\x7a\x02\uffff\x01\x7a\x02\uffff";
    const string DFA8_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x05\uffff\x01\x0a\x01\x0b\x01"+
        "\x0c\x01\x0d\x01\x0e\x01\x0f\x01\x10\x01\x11\x01\uffff\x01\x14\x01"+
        "\x15\x01\x16\x01\x17\x01\x18\x01\x19\x01\x1a\x0d\uffff\x01\x07\x09"+
        "\uffff\x01\x09\x08\uffff\x01\x13\x01\uffff\x01\x05\x02\uffff\x01"+
        "\x08\x01\x01\x01\uffff\x01\x06\x01\x12";
    const string DFA8_specialS =
        "\x44\uffff}>";
    static readonly string[] DFA8_transitionS = {
            "\x02\x19\x02\uffff\x01\x19\x12\uffff\x01\x19\x01\uffff\x01"+
            "\x17\x02\uffff\x01\x0e\x01\uffff\x01\x18\x01\x13\x01\x14\x01"+
            "\x0c\x01\x0a\x01\x04\x01\x0b\x01\x15\x01\x0d\x0a\x16\x01\uffff"+
            "\x01\x11\x01\x0f\x01\x10\x01\x0f\x02\uffff\x1a\x15\x04\uffff"+
            "\x01\x15\x01\uffff\x02\x15\x01\x05\x02\x15\x01\x09\x02\x15\x01"+
            "\x07\x06\x15\x01\x01\x01\x15\x01\x06\x01\x15\x01\x12\x02\x15"+
            "\x01\x08\x03\x15\x01\x02\x01\uffff\x01\x03",
            "\x01\x1a",
            "",
            "",
            "",
            "\x01\x1c\x0a\uffff\x01\x1b",
            "\x01\x1d",
            "\x01\x1e",
            "\x01\x1f",
            "\x01\x21\x0d\uffff\x01\x20",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x22",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x23",
            "\x01\x24",
            "\x01\x25",
            "\x01\x26",
            "\x01\x15\x01\uffff\x0a\x15\x07\uffff\x1a\x15\x04\uffff\x01"+
            "\x15\x01\uffff\x1a\x15",
            "\x01\x28",
            "\x01\x29",
            "\x01\x2a",
            "\x01\x2b",
            "\x01\x2c",
            "\x01\x2d",
            "\x01\x2e",
            "\x01\x2f",
            "",
            "\x01\x30",
            "\x01\x15\x01\uffff\x0a\x15\x07\uffff\x1a\x15\x04\uffff\x01"+
            "\x15\x01\uffff\x1a\x15",
            "\x01\x32",
            "\x01\x33",
            "\x01\x34",
            "\x01\x35",
            "\x01\x36",
            "\x01\x37",
            "\x01\x38",
            "",
            "\x01\x39",
            "\x01\x15\x01\uffff\x0a\x15\x07\uffff\x1a\x15\x04\uffff\x01"+
            "\x15\x01\uffff\x1a\x15",
            "\x01\x3b",
            "\x01\x15\x01\uffff\x0a\x15\x07\uffff\x1a\x15\x04\uffff\x01"+
            "\x15\x01\uffff\x1a\x15",
            "\x01\x3d",
            "\x01\x3e",
            "\x01\x15\x01\uffff\x0a\x15\x07\uffff\x1a\x15\x04\uffff\x01"+
            "\x15\x01\uffff\x1a\x15",
            "\x01\x15\x01\uffff\x0a\x15\x07\uffff\x1a\x15\x04\uffff\x01"+
            "\x15\x01\uffff\x1a\x15",
            "",
            "\x01\x15\x01\uffff\x0a\x15\x07\uffff\x1a\x15\x04\uffff\x01"+
            "\x15\x01\uffff\x1a\x15",
            "",
            "\x01\x41",
            "\x01\x15\x01\uffff\x0a\x15\x07\uffff\x1a\x15\x04\uffff\x01"+
            "\x15\x01\uffff\x1a\x15",
            "",
            "",
            "\x01\x15\x01\uffff\x0a\x15\x07\uffff\x1a\x15\x04\uffff\x01"+
            "\x15\x01\uffff\x1a\x15",
            "",
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
            get { return "1:1: Tokens : ( T__31 | T__32 | T__33 | T__34 | CLASS | RETURN | IF | WHILE | FOR | ARITH_OP | MINUS_OP | MULT_OP | DIV_OP | REM_OP | REL_OP | EQUALS | EOS | CALLOUT | BOOL_LITERAL | LBRAC | RBRAC | ID | INT | STRING_LITERAL | CHAR_LITERAL | WS );"; }
        }

    }

 
    
}
}