// $ANTLR 3.1.2 C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g 2009-05-22 12:58:04

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
		"METHOD", 
		"CLASS", 
		"ID", 
		"EOS", 
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
		"CALLOUT", 
		"ALPHA", 
		"ALPHA_NUM", 
		"WS", 
		"'public'", 
		"'{'", 
		"'}'", 
		"'(){'"
    };

    public const int ALPHA_NUM = 22;
    public const int CLASS = 5;
    public const int MULT_OP = 17;
    public const int T__27 = 27;
    public const int T__26 = 26;
    public const int T__25 = 25;
    public const int DIV_OP = 18;
    public const int T__24 = 24;
    public const int ARITH_OP = 16;
    public const int REM_OP = 19;
    public const int EQUALS = 8;
    public const int INT = 10;
    public const int BOOL_LITERAL = 15;
    public const int ID = 6;
    public const int EOF = -1;
    public const int LBRAC = 11;
    public const int ALPHA = 21;
    public const int STRING_LITERAL = 13;
    public const int WS = 23;
    public const int CHAR_LITERAL = 14;
    public const int RBRAC = 12;
    public const int EOS = 7;
    public const int MINUS_OP = 9;
    public const int METHOD = 4;
    public const int CALLOUT = 20;

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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:13:1: prog : ^( CLASS name= ID ( method )* ) ;
    public void prog() // throws RecognitionException [1]
    {   
        CommonTree name = null;

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:13:5: ( ^( CLASS name= ID ( method )* ) )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:13:7: ^( CLASS name= ID ( method )* )
            {
            	Match(input,CLASS,FOLLOW_CLASS_in_prog50); 

            	Match(input, Token.DOWN, null); 
            	name=(CommonTree)Match(input,ID,FOLLOW_ID_in_prog54); 
            	CodeGenerator.StartModule(((name != null) ? name.Text : null));
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:13:64: ( method )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == METHOD) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:13:64: method
            			    {
            			    	PushFollow(FOLLOW_method_in_prog58);
            			    	method();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	CodeGenerator.EndModule();

            	Match(input, Token.UP, null); 

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


    // $ANTLR start "method"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:16:1: method : ^( METHOD name= ID ( stat )* ) ;
    public void method() // throws RecognitionException [1]
    {   
        CommonTree name = null;

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:16:8: ( ^( METHOD name= ID ( stat )* ) )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:16:10: ^( METHOD name= ID ( stat )* )
            {
            	Match(input,METHOD,FOLLOW_METHOD_in_method80); 

            	Match(input, Token.DOWN, null); 
            	name=(CommonTree)Match(input,ID,FOLLOW_ID_in_method84); 
            	 CodeGenerator.BeginMethod(((name != null) ? name.Text : null));
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:16:69: ( stat )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == ID || (LA2_0 >= EQUALS && LA2_0 <= INT) || (LA2_0 >= STRING_LITERAL && LA2_0 <= REM_OP)) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:16:69: stat
            			    {
            			    	PushFollow(FOLLOW_stat_in_method88);
            			    	stat();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements

            	CodeGenerator.EndMethod();

            	Match(input, Token.UP, null); 

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
    // $ANTLR end "method"


    // $ANTLR start "stat"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:18:1: stat : (e= expr | ^( EQUALS ^(t= ID name= ID ) expr ) );
    public void stat() // throws RecognitionException [1]
    {   
        CommonTree t = null;
        CommonTree name = null;

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:18:5: (e= expr | ^( EQUALS ^(t= ID name= ID ) expr ) )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( (LA3_0 == ID || (LA3_0 >= MINUS_OP && LA3_0 <= INT) || (LA3_0 >= STRING_LITERAL && LA3_0 <= REM_OP)) )
            {
                alt3 = 1;
            }
            else if ( (LA3_0 == EQUALS) )
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
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:18:9: e= expr
                    {
                    	CodeGenerator.BeginExpression();
                    	PushFollow(FOLLOW_expr_in_stat107);
                    	expr();
                    	state.followingStackPointer--;

                    	CodeGenerator.EndExpression();

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:20:2: ^( EQUALS ^(t= ID name= ID ) expr )
                    {
                    	Match(input,EQUALS,FOLLOW_EQUALS_in_stat116); 

                    	Match(input, Token.DOWN, null); 
                    	t=(CommonTree)Match(input,ID,FOLLOW_ID_in_stat121); 

                    	Match(input, Token.DOWN, null); 
                    	name=(CommonTree)Match(input,ID,FOLLOW_ID_in_stat125); 

                    	Match(input, Token.UP, null); 
                    	CodeGenerator.DefineVariable(((name != null) ? name.Text : null), ((t != null) ? t.Text : null)); CodeGenerator.BeginExpression();
                    	PushFollow(FOLLOW_expr_in_stat130);
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:22:1: expr : ( ^( '+' a= expr b= expr ) | ^( '-' a= expr b= expr ) | ^( '*' a= expr b= expr ) | ^( '/' a= expr b= expr ) | ^( '%' a= expr b= expr ) | STRING_LITERAL | CHAR_LITERAL | INT | MINUS_OP INT | ID | BOOL_LITERAL );
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
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:23:5: ( ^( '+' a= expr b= expr ) | ^( '-' a= expr b= expr ) | ^( '*' a= expr b= expr ) | ^( '/' a= expr b= expr ) | ^( '%' a= expr b= expr ) | STRING_LITERAL | CHAR_LITERAL | INT | MINUS_OP INT | ID | BOOL_LITERAL )
            int alt4 = 11;
            alt4 = dfa4.Predict(input);
            switch (alt4) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:23:9: ^( '+' a= expr b= expr )
                    {
                    	Match(input,ARITH_OP,FOLLOW_ARITH_OP_in_expr148); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr152);
                    	expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr156);
                    	expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 CodeGenerator.Operation("Addition"); 

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:24:8: ^( '-' a= expr b= expr )
                    {
                    	Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_expr175); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr179);
                    	expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr183);
                    	expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 CodeGenerator.Operation("Subtraction"); 

                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:25:8: ^( '*' a= expr b= expr )
                    {
                    	Match(input,MULT_OP,FOLLOW_MULT_OP_in_expr202); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr206);
                    	expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr210);
                    	expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 CodeGenerator.Operation("Multiplication"); 

                    }
                    break;
                case 4 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:26:8: ^( '/' a= expr b= expr )
                    {
                    	Match(input,DIV_OP,FOLLOW_DIV_OP_in_expr229); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr233);
                    	expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr237);
                    	expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 CodeGenerator.Operation("Division"); 

                    }
                    break;
                case 5 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:27:8: ^( '%' a= expr b= expr )
                    {
                    	Match(input,REM_OP,FOLLOW_REM_OP_in_expr256); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr260);
                    	expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr264);
                    	expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 CodeGenerator.Operation("Remainder"); 

                    }
                    break;
                case 6 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:28:9: STRING_LITERAL
                    {
                    	STRING_LITERAL1=(CommonTree)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_expr283); 
                    	 CodeGenerator.ExprString(((STRING_LITERAL1 != null) ? STRING_LITERAL1.Text : null)); 

                    }
                    break;
                case 7 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:29:7: CHAR_LITERAL
                    {
                    	CHAR_LITERAL2=(CommonTree)Match(input,CHAR_LITERAL,FOLLOW_CHAR_LITERAL_in_expr305); 
                    	 CodeGenerator.ExprChar(char.Parse(((CHAR_LITERAL2 != null) ? CHAR_LITERAL2.Text : null).Replace("'",""))); 

                    }
                    break;
                case 8 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:30:9: INT
                    {
                    	INT3=(CommonTree)Match(input,INT,FOLLOW_INT_in_expr321); 
                    	 CodeGenerator.ExprNumber(int.Parse(((INT3 != null) ? INT3.Text : null))); 

                    }
                    break;
                case 9 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:31:9: MINUS_OP INT
                    {
                    	Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_expr356); 
                    	INT4=(CommonTree)Match(input,INT,FOLLOW_INT_in_expr358); 
                    	 CodeGenerator.ExprNumber(-int.Parse(((INT4 != null) ? INT4.Text : null))); 

                    }
                    break;
                case 10 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:32:7: ID
                    {
                    	ID5=(CommonTree)Match(input,ID,FOLLOW_ID_in_expr382); 
                    	 CodeGenerator.ExprId(((ID5 != null) ? ID5.Text : null)); 

                    }
                    break;
                case 11 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:33:7: BOOL_LITERAL
                    {
                    	BOOL_LITERAL6=(CommonTree)Match(input,BOOL_LITERAL,FOLLOW_BOOL_LITERAL_in_expr397); 
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


   	protected DFA4 dfa4;
	private void InitializeCyclicDFAs()
	{
    	this.dfa4 = new DFA4(this);
	}

    const string DFA4_eotS =
        "\x0d\uffff";
    const string DFA4_eofS =
        "\x0d\uffff";
    const string DFA4_minS =
        "\x01\x06\x01\uffff\x01\x02\x0a\uffff";
    const string DFA4_maxS =
        "\x01\x13\x01\uffff\x01\x0a\x0a\uffff";
    const string DFA4_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x0a\x01\x0b\x01\x02\x01\x09";
    const string DFA4_specialS =
        "\x0d\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x01\x09\x02\uffff\x01\x02\x01\x08\x02\uffff\x01\x06\x01\x07"+
            "\x01\x0a\x01\x01\x01\x03\x01\x04\x01\x05",
            "",
            "\x01\x0b\x07\uffff\x01\x0c",
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

    static readonly short[] DFA4_eot = DFA.UnpackEncodedString(DFA4_eotS);
    static readonly short[] DFA4_eof = DFA.UnpackEncodedString(DFA4_eofS);
    static readonly char[] DFA4_min = DFA.UnpackEncodedStringToUnsignedChars(DFA4_minS);
    static readonly char[] DFA4_max = DFA.UnpackEncodedStringToUnsignedChars(DFA4_maxS);
    static readonly short[] DFA4_accept = DFA.UnpackEncodedString(DFA4_acceptS);
    static readonly short[] DFA4_special = DFA.UnpackEncodedString(DFA4_specialS);
    static readonly short[][] DFA4_transition = DFA.UnpackEncodedStringArray(DFA4_transitionS);

    protected class DFA4 : DFA
    {
        public DFA4(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 4;
            this.eot = DFA4_eot;
            this.eof = DFA4_eof;
            this.min = DFA4_min;
            this.max = DFA4_max;
            this.accept = DFA4_accept;
            this.special = DFA4_special;
            this.transition = DFA4_transition;

        }

        override public string Description
        {
            get { return "22:1: expr : ( ^( '+' a= expr b= expr ) | ^( '-' a= expr b= expr ) | ^( '*' a= expr b= expr ) | ^( '/' a= expr b= expr ) | ^( '%' a= expr b= expr ) | STRING_LITERAL | CHAR_LITERAL | INT | MINUS_OP INT | ID | BOOL_LITERAL );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_CLASS_in_prog50 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_prog54 = new BitSet(new ulong[]{0x0000000000000018UL});
    public static readonly BitSet FOLLOW_method_in_prog58 = new BitSet(new ulong[]{0x0000000000000018UL});
    public static readonly BitSet FOLLOW_METHOD_in_method80 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_method84 = new BitSet(new ulong[]{0x00000000000FE748UL});
    public static readonly BitSet FOLLOW_stat_in_method88 = new BitSet(new ulong[]{0x00000000000FE748UL});
    public static readonly BitSet FOLLOW_expr_in_stat107 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EQUALS_in_stat116 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_stat121 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_stat125 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_expr_in_stat130 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_ARITH_OP_in_expr148 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr152 = new BitSet(new ulong[]{0x00000000000FE640UL});
    public static readonly BitSet FOLLOW_expr_in_expr156 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_expr175 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr179 = new BitSet(new ulong[]{0x00000000000FE640UL});
    public static readonly BitSet FOLLOW_expr_in_expr183 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MULT_OP_in_expr202 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr206 = new BitSet(new ulong[]{0x00000000000FE640UL});
    public static readonly BitSet FOLLOW_expr_in_expr210 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_DIV_OP_in_expr229 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr233 = new BitSet(new ulong[]{0x00000000000FE640UL});
    public static readonly BitSet FOLLOW_expr_in_expr237 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_REM_OP_in_expr256 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr260 = new BitSet(new ulong[]{0x00000000000FE640UL});
    public static readonly BitSet FOLLOW_expr_in_expr264 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_expr283 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_LITERAL_in_expr305 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_expr321 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_expr356 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_INT_in_expr358 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_expr382 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOL_LITERAL_in_expr397 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}