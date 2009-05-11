// $ANTLR 3.1.2 C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g 2009-05-12 01:32:03

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
    public const int RBRAC = 7;
    public const int ARITH_OP = 12;
    public const int REM_OP = 15;
    public const int INT = 5;
    public const int MINUS_OP = 4;
    public const int BOOL_LITERAL = 10;
    public const int ID = 11;
    public const int EOF = -1;
    public const int LBRAC = 6;
    public const int ALPHA = 17;
    public const int CALLOUT = 16;

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

            	    if ( ((LA1_0 >= MINUS_OP && LA1_0 <= INT) || (LA1_0 >= STRING_LITERAL && LA1_0 <= REM_OP)) )
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:16:1: stat : e= expr ;
    public void stat() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:16:5: (e= expr )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:16:9: e= expr
            {
            	CodeGenerator.BeginExpression();
            	PushFollow(FOLLOW_expr_in_stat74);
            	expr();
            	state.followingStackPointer--;

            	CodeGenerator.EndExpression();

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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:18:1: expr : ( ^( '+' a= expr b= expr ) | ^( '-' a= expr b= expr ) | ^( '*' a= expr b= expr ) | ^( '/' a= expr b= expr ) | ^( '%' a= expr b= expr ) | STRING_LITERAL | CHAR_LITERAL | INT | MINUS_OP INT | ID | BOOL_LITERAL );
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
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:19:5: ( ^( '+' a= expr b= expr ) | ^( '-' a= expr b= expr ) | ^( '*' a= expr b= expr ) | ^( '/' a= expr b= expr ) | ^( '%' a= expr b= expr ) | STRING_LITERAL | CHAR_LITERAL | INT | MINUS_OP INT | ID | BOOL_LITERAL )
            int alt2 = 11;
            alt2 = dfa2.Predict(input);
            switch (alt2) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:19:9: ^( '+' a= expr b= expr )
                    {
                    	Match(input,ARITH_OP,FOLLOW_ARITH_OP_in_expr91); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr95);
                    	expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr99);
                    	expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 CodeGenerator.Operation("Addition"); 

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:20:8: ^( '-' a= expr b= expr )
                    {
                    	Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_expr118); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr122);
                    	expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr126);
                    	expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 CodeGenerator.Operation("Subtraction"); 

                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:21:8: ^( '*' a= expr b= expr )
                    {
                    	Match(input,MULT_OP,FOLLOW_MULT_OP_in_expr145); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr149);
                    	expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr153);
                    	expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 CodeGenerator.Operation("Multiplication"); 

                    }
                    break;
                case 4 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:22:8: ^( '/' a= expr b= expr )
                    {
                    	Match(input,DIV_OP,FOLLOW_DIV_OP_in_expr172); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr176);
                    	expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr180);
                    	expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 CodeGenerator.Operation("Division"); 

                    }
                    break;
                case 5 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:23:8: ^( '%' a= expr b= expr )
                    {
                    	Match(input,REM_OP,FOLLOW_REM_OP_in_expr199); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr203);
                    	expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr207);
                    	expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 CodeGenerator.Operation("Remainder"); 

                    }
                    break;
                case 6 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:24:9: STRING_LITERAL
                    {
                    	STRING_LITERAL1=(CommonTree)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_expr226); 
                    	 CodeGenerator.ExprString(((STRING_LITERAL1 != null) ? STRING_LITERAL1.Text : null)); 

                    }
                    break;
                case 7 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:25:7: CHAR_LITERAL
                    {
                    	CHAR_LITERAL2=(CommonTree)Match(input,CHAR_LITERAL,FOLLOW_CHAR_LITERAL_in_expr248); 
                    	 CodeGenerator.ExprChar(char.Parse(((CHAR_LITERAL2 != null) ? CHAR_LITERAL2.Text : null).Replace("'",""))); 

                    }
                    break;
                case 8 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:26:9: INT
                    {
                    	INT3=(CommonTree)Match(input,INT,FOLLOW_INT_in_expr264); 
                    	 CodeGenerator.ExprNumber(int.Parse(((INT3 != null) ? INT3.Text : null))); 

                    }
                    break;
                case 9 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:27:9: MINUS_OP INT
                    {
                    	Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_expr299); 
                    	INT4=(CommonTree)Match(input,INT,FOLLOW_INT_in_expr301); 
                    	 CodeGenerator.ExprNumber(-int.Parse(((INT4 != null) ? INT4.Text : null))); 

                    }
                    break;
                case 10 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:28:7: ID
                    {
                    	ID5=(CommonTree)Match(input,ID,FOLLOW_ID_in_expr334); 
                    	 CodeGenerator.ExprId(((ID5 != null) ? ID5.Text : null)); 

                    }
                    break;
                case 11 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:29:7: BOOL_LITERAL
                    {
                    	BOOL_LITERAL6=(CommonTree)Match(input,BOOL_LITERAL,FOLLOW_BOOL_LITERAL_in_expr349); 
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


   	protected DFA2 dfa2;
	private void InitializeCyclicDFAs()
	{
    	this.dfa2 = new DFA2(this);
	}

    const string DFA2_eotS =
        "\x0d\uffff";
    const string DFA2_eofS =
        "\x0d\uffff";
    const string DFA2_minS =
        "\x01\x04\x01\uffff\x01\x02\x0a\uffff";
    const string DFA2_maxS =
        "\x01\x0f\x01\uffff\x01\x05\x0a\uffff";
    const string DFA2_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x0a\x01\x0b\x01\x02\x01\x09";
    const string DFA2_specialS =
        "\x0d\uffff}>";
    static readonly string[] DFA2_transitionS = {
            "\x01\x02\x01\x08\x02\uffff\x01\x06\x01\x07\x01\x0a\x01\x09"+
            "\x01\x01\x01\x03\x01\x04\x01\x05",
            "",
            "\x01\x0b\x02\uffff\x01\x0c",
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

    static readonly short[] DFA2_eot = DFA.UnpackEncodedString(DFA2_eotS);
    static readonly short[] DFA2_eof = DFA.UnpackEncodedString(DFA2_eofS);
    static readonly char[] DFA2_min = DFA.UnpackEncodedStringToUnsignedChars(DFA2_minS);
    static readonly char[] DFA2_max = DFA.UnpackEncodedStringToUnsignedChars(DFA2_maxS);
    static readonly short[] DFA2_accept = DFA.UnpackEncodedString(DFA2_acceptS);
    static readonly short[] DFA2_special = DFA.UnpackEncodedString(DFA2_specialS);
    static readonly short[][] DFA2_transition = DFA.UnpackEncodedStringArray(DFA2_transitionS);

    protected class DFA2 : DFA
    {
        public DFA2(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 2;
            this.eot = DFA2_eot;
            this.eof = DFA2_eof;
            this.min = DFA2_min;
            this.max = DFA2_max;
            this.accept = DFA2_accept;
            this.special = DFA2_special;
            this.transition = DFA2_transition;

        }

        override public string Description
        {
            get { return "18:1: expr : ( ^( '+' a= expr b= expr ) | ^( '-' a= expr b= expr ) | ^( '*' a= expr b= expr ) | ^( '/' a= expr b= expr ) | ^( '%' a= expr b= expr ) | STRING_LITERAL | CHAR_LITERAL | INT | MINUS_OP INT | ID | BOOL_LITERAL );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_stat_in_prog51 = new BitSet(new ulong[]{0x000000000000FF32UL});
    public static readonly BitSet FOLLOW_expr_in_stat74 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARITH_OP_in_expr91 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr95 = new BitSet(new ulong[]{0x000000000000FF38UL});
    public static readonly BitSet FOLLOW_expr_in_expr99 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_expr118 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr122 = new BitSet(new ulong[]{0x000000000000FF38UL});
    public static readonly BitSet FOLLOW_expr_in_expr126 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MULT_OP_in_expr145 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr149 = new BitSet(new ulong[]{0x000000000000FF38UL});
    public static readonly BitSet FOLLOW_expr_in_expr153 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_DIV_OP_in_expr172 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr176 = new BitSet(new ulong[]{0x000000000000FF38UL});
    public static readonly BitSet FOLLOW_expr_in_expr180 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_REM_OP_in_expr199 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr203 = new BitSet(new ulong[]{0x000000000000FF38UL});
    public static readonly BitSet FOLLOW_expr_in_expr207 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_expr226 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_LITERAL_in_expr248 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_expr264 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_expr299 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_INT_in_expr301 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_expr334 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOL_LITERAL_in_expr349 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}