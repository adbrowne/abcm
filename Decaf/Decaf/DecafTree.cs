// $ANTLR 3.1.2 C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g 2009-05-20 14:50:09

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
namespace 
    Decaf

{

using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class DecafTree : TreeParser
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



        public DecafTree(ITreeNodeStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public DecafTree(ITreeNodeStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        

    override public string[] TokenNames {
		get { return DecafTree.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g"; }
    }



    // $ANTLR start "prog"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:13:1: prog : ( stat )* ;
    public void prog() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:13:5: ( ( stat )* )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:13:9: ( stat )*
            {
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:13:9: ( stat )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= ID && LA1_0 <= INT) || (LA1_0 >= STRING_LITERAL && LA1_0 <= REM_OP)) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:13:9: stat
            			    {
            			    	PushFollow(FOLLOW_stat_in_prog51);
            			    	stat();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:16:1: stat : (e= expr | ^( EQUALS ^(t= ID name= ID ) expr ) );
    public void stat() // throws RecognitionException [1]
    {   
        CommonTree t = null;
        CommonTree name = null;

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:16:5: (e= expr | ^( EQUALS ^(t= ID name= ID ) expr ) )
            int alt2 = 2;
            int LA2_0 = input.LA(1);

            if ( (LA2_0 == ID || (LA2_0 >= MINUS_OP && LA2_0 <= INT) || (LA2_0 >= STRING_LITERAL && LA2_0 <= REM_OP)) )
            {
                alt2 = 1;
            }
            else if ( (LA2_0 == EQUALS) )
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
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:16:9: e= expr
                    {
                    	CodeGenerator.BeginExpression();
                    	PushFollow(FOLLOW_expr_in_stat74);
                    	expr();
                    	state.followingStackPointer--;

                    	CodeGenerator.EndExpression();

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:18:2: ^( EQUALS ^(t= ID name= ID ) expr )
                    {
                    	Match(input,EQUALS,FOLLOW_EQUALS_in_stat83); 

                    	Match(input, Token.DOWN, null); 
                    	t=(CommonTree)Match(input,ID,FOLLOW_ID_in_stat88); 

                    	Match(input, Token.DOWN, null); 
                    	name=(CommonTree)Match(input,ID,FOLLOW_ID_in_stat92); 

                    	Match(input, Token.UP, null); 
                    	CodeGenerator.DefineVariable(((name != null) ? name.Text : null), ((t != null) ? t.Text : null)); CodeGenerator.BeginExpression();
                    	PushFollow(FOLLOW_expr_in_stat97);
                    	expr();
                    	state.followingStackPointer--;

                    	CodeGenerator.EndExpression(); CodeGenerator.AssignExpression(((name != null) ? name.Text : null)); 

                    	Match(input, Token.UP, null); 

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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:20:1: expr : ( ^( '+' a= expr b= expr ) | ^( '-' a= expr b= expr ) | ^( '*' a= expr b= expr ) | ^( '/' a= expr b= expr ) | ^( '%' a= expr b= expr ) | STRING_LITERAL | CHAR_LITERAL | INT | MINUS_OP INT | ID | BOOL_LITERAL );
    public void expr() // throws RecognitionException [1]
    {   
        CommonTree STRING_LITERAL1 = null;
        CommonTree CHAR_LITERAL2 = null;
        CommonTree INT3 = null;
        CommonTree INT4 = null;
        CommonTree ID5 = null;
        CommonTree BOOL_LITERAL6 = null;

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:21:5: ( ^( '+' a= expr b= expr ) | ^( '-' a= expr b= expr ) | ^( '*' a= expr b= expr ) | ^( '/' a= expr b= expr ) | ^( '%' a= expr b= expr ) | STRING_LITERAL | CHAR_LITERAL | INT | MINUS_OP INT | ID | BOOL_LITERAL )
            int alt3 = 11;
            alt3 = dfa3.Predict(input);
            switch (alt3) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:21:9: ^( '+' a= expr b= expr )
                    {
                    	Match(input,ARITH_OP,FOLLOW_ARITH_OP_in_expr115); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr119);
                    	expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr123);
                    	expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 CodeGenerator.Operation("Addition"); 

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:22:8: ^( '-' a= expr b= expr )
                    {
                    	Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_expr142); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr146);
                    	expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr150);
                    	expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 CodeGenerator.Operation("Subtraction"); 

                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:23:8: ^( '*' a= expr b= expr )
                    {
                    	Match(input,MULT_OP,FOLLOW_MULT_OP_in_expr169); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr173);
                    	expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr177);
                    	expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 CodeGenerator.Operation("Multiplication"); 

                    }
                    break;
                case 4 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:24:8: ^( '/' a= expr b= expr )
                    {
                    	Match(input,DIV_OP,FOLLOW_DIV_OP_in_expr196); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr200);
                    	expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr204);
                    	expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 CodeGenerator.Operation("Division"); 

                    }
                    break;
                case 5 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:25:8: ^( '%' a= expr b= expr )
                    {
                    	Match(input,REM_OP,FOLLOW_REM_OP_in_expr223); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr227);
                    	expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr231);
                    	expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 CodeGenerator.Operation("Remainder"); 

                    }
                    break;
                case 6 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:26:9: STRING_LITERAL
                    {
                    	STRING_LITERAL1=(CommonTree)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_expr250); 
                    	 CodeGenerator.ExprString(((STRING_LITERAL1 != null) ? STRING_LITERAL1.Text : null)); 

                    }
                    break;
                case 7 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:27:7: CHAR_LITERAL
                    {
                    	CHAR_LITERAL2=(CommonTree)Match(input,CHAR_LITERAL,FOLLOW_CHAR_LITERAL_in_expr272); 
                    	 CodeGenerator.ExprChar(char.Parse(((CHAR_LITERAL2 != null) ? CHAR_LITERAL2.Text : null).Replace("'",""))); 

                    }
                    break;
                case 8 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:28:9: INT
                    {
                    	INT3=(CommonTree)Match(input,INT,FOLLOW_INT_in_expr288); 
                    	 CodeGenerator.ExprNumber(int.Parse(((INT3 != null) ? INT3.Text : null))); 

                    }
                    break;
                case 9 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:29:9: MINUS_OP INT
                    {
                    	Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_expr323); 
                    	INT4=(CommonTree)Match(input,INT,FOLLOW_INT_in_expr325); 
                    	 CodeGenerator.ExprNumber(-int.Parse(((INT4 != null) ? INT4.Text : null))); 

                    }
                    break;
                case 10 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:30:7: ID
                    {
                    	ID5=(CommonTree)Match(input,ID,FOLLOW_ID_in_expr349); 
                    	 CodeGenerator.ExprId(((ID5 != null) ? ID5.Text : null)); 

                    }
                    break;
                case 11 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:31:7: BOOL_LITERAL
                    {
                    	BOOL_LITERAL6=(CommonTree)Match(input,BOOL_LITERAL,FOLLOW_BOOL_LITERAL_in_expr364); 
                    	 CodeGenerator.ExprBool(bool.Parse(((BOOL_LITERAL6 != null) ? BOOL_LITERAL6.Text : null))); 

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
    // $ANTLR end "expr"

    // Delegated rules


   	protected DFA3 dfa3;
	private void InitializeCyclicDFAs()
	{
    	this.dfa3 = new DFA3(this);
	}

    const string DFA3_eotS =
        "\x0d\uffff";
    const string DFA3_eofS =
        "\x0d\uffff";
    const string DFA3_minS =
        "\x01\x04\x01\uffff\x01\x02\x0a\uffff";
    const string DFA3_maxS =
        "\x01\x10\x01\uffff\x01\x07\x0a\uffff";
    const string DFA3_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x0a\x01\x0b\x01\x02\x01\x09";
    const string DFA3_specialS =
        "\x0d\uffff}>";
    static readonly string[] DFA3_transitionS = {
            "\x01\x09\x01\uffff\x01\x02\x01\x08\x02\uffff\x01\x06\x01\x07"+
            "\x01\x0a\x01\x01\x01\x03\x01\x04\x01\x05",
            "",
            "\x01\x0b\x04\uffff\x01\x0c",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA3_eot = DFA.UnpackEncodedString(DFA3_eotS);
    static readonly short[] DFA3_eof = DFA.UnpackEncodedString(DFA3_eofS);
    static readonly char[] DFA3_min = DFA.UnpackEncodedStringToUnsignedChars(DFA3_minS);
    static readonly char[] DFA3_max = DFA.UnpackEncodedStringToUnsignedChars(DFA3_maxS);
    static readonly short[] DFA3_accept = DFA.UnpackEncodedString(DFA3_acceptS);
    static readonly short[] DFA3_special = DFA.UnpackEncodedString(DFA3_specialS);
    static readonly short[][] DFA3_transition = DFA.UnpackEncodedStringArray(DFA3_transitionS);

    protected class DFA3 : DFA
    {
        public DFA3(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 3;
            this.eot = DFA3_eot;
            this.eof = DFA3_eof;
            this.min = DFA3_min;
            this.max = DFA3_max;
            this.accept = DFA3_accept;
            this.special = DFA3_special;
            this.transition = DFA3_transition;

        }

        override public string Description
        {
            get { return "20:1: expr : ( ^( '+' a= expr b= expr ) | ^( '-' a= expr b= expr ) | ^( '*' a= expr b= expr ) | ^( '/' a= expr b= expr ) | ^( '%' a= expr b= expr ) | STRING_LITERAL | CHAR_LITERAL | INT | MINUS_OP INT | ID | BOOL_LITERAL );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_stat_in_prog51 = new BitSet(new ulong[]{0x000000000001FCF2UL});
    public static readonly BitSet FOLLOW_expr_in_stat74 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EQUALS_in_stat83 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_stat88 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_stat92 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_expr_in_stat97 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_ARITH_OP_in_expr115 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr119 = new BitSet(new ulong[]{0x000000000001FCD0UL});
    public static readonly BitSet FOLLOW_expr_in_expr123 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_expr142 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr146 = new BitSet(new ulong[]{0x000000000001FCD0UL});
    public static readonly BitSet FOLLOW_expr_in_expr150 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MULT_OP_in_expr169 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr173 = new BitSet(new ulong[]{0x000000000001FCD0UL});
    public static readonly BitSet FOLLOW_expr_in_expr177 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_DIV_OP_in_expr196 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr200 = new BitSet(new ulong[]{0x000000000001FCD0UL});
    public static readonly BitSet FOLLOW_expr_in_expr204 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_REM_OP_in_expr223 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr227 = new BitSet(new ulong[]{0x000000000001FCD0UL});
    public static readonly BitSet FOLLOW_expr_in_expr231 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_expr250 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_LITERAL_in_expr272 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_expr288 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_expr323 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_INT_in_expr325 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_expr349 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOL_LITERAL_in_expr364 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}