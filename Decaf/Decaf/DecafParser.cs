// $ANTLR 3.1.2 C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g 2009-04-01 21:26:48

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
		"STRING_LITERAL", 
		"CHAR_LITERAL"
    };

    public const int STRING_LITERAL = 4;
    public const int CHAR_LITERAL = 5;
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:8:1: prog : ( STRING_LITERAL )+ ;
    public void prog() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:8:5: ( ( STRING_LITERAL )+ )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:8:9: ( STRING_LITERAL )+
            {
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:8:9: ( STRING_LITERAL )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == STRING_LITERAL) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:8:9: STRING_LITERAL
            			    {
            			    	Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_prog25); 

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

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_STRING_LITERAL_in_prog25 = new BitSet(new ulong[]{0x0000000000000012UL});

}
