// $ANTLR 3.1.2 C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g 2009-06-09 20:28:30

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
namespace 
    CFlat

{

using CFlat.Tree;


using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class CFlatTree : TreeParser
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
		"RETURN", 
		"IF", 
		"LBRAC", 
		"RBRAC", 
		"MINUS_OP", 
		"INT", 
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
    public const int INT = 14;
    public const int BOOL_LITERAL = 17;
    public const int ID = 6;
    public const int EOF = -1;
    public const int LBRAC = 11;
    public const int ALPHA = 23;
    public const int IF = 10;
    public const int STRING_LITERAL = 15;
    public const int WS = 25;
    public const int CHAR_LITERAL = 16;
    public const int RBRAC = 12;
    public const int RETURN = 9;
    public const int EOS = 7;
    public const int MINUS_OP = 13;
    public const int METHOD = 4;
    public const int CALLOUT = 22;

    // delegates
    // delegators



        public CFlatTree(ITreeNodeStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public CFlatTree(ITreeNodeStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        

    override public string[] TokenNames {
		get { return CFlatTree.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g"; }
    }



    // $ANTLR start "prog"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:24:1: prog returns [Class c] : ^( CLASS name= ID (m= method )* ) ;
    public Class prog() // throws RecognitionException [1]
    {   
        Class c = default(Class);

        CommonTree name = null;
        Method m = default(Method);


        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:24:23: ( ^( CLASS name= ID (m= method )* ) )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:24:25: ^( CLASS name= ID (m= method )* )
            {
            	Match(input,CLASS,FOLLOW_CLASS_in_prog66); 

            	Match(input, Token.DOWN, null); 
            	name=(CommonTree)Match(input,ID,FOLLOW_ID_in_prog70); 
            	c =  TB.Class(((name != null) ? name.Text : null)); 
            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:24:71: (m= method )*
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
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:24:72: m= method
            			    {
            			    	PushFollow(FOLLOW_method_in_prog77);
            			    	m = method();
            			    	state.followingStackPointer--;

            			    	 c.AddMethod(m);

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


            	Match(input, Token.UP, null); 

            }

        }

        catch (RecognitionException) {
        throw;
        }
        finally 
    	{
        }
        return c;
    }
    // $ANTLR end "prog"


    // $ANTLR start "method"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:27:1: method returns [Method m] : ^( METHOD t= ID name= ID (s= stat )* ) ;
    public Method method() // throws RecognitionException [1]
    {   
        Method m = default(Method);

        CommonTree t = null;
        CommonTree name = null;
        Statement s = default(Statement);


        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:27:26: ( ^( METHOD t= ID name= ID (s= stat )* ) )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:27:28: ^( METHOD t= ID name= ID (s= stat )* )
            {
            	Match(input,METHOD,FOLLOW_METHOD_in_method99); 

            	Match(input, Token.DOWN, null); 
            	t=(CommonTree)Match(input,ID,FOLLOW_ID_in_method103); 
            	name=(CommonTree)Match(input,ID,FOLLOW_ID_in_method107); 
            	 m =  TB.Method(((name != null) ? name.Text : null), ((t != null) ? t.Text : null));
            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:27:90: (s= stat )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == ID || (LA2_0 >= EQUALS && LA2_0 <= IF) || (LA2_0 >= MINUS_OP && LA2_0 <= REM_OP)) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:27:91: s= stat
            			    {
            			    	PushFollow(FOLLOW_stat_in_method114);
            			    	s = stat();
            			    	state.followingStackPointer--;

            			    	 m.Statements.Add(s); 

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


            	Match(input, Token.UP, null); 

            }

        }

        catch (RecognitionException) {
        throw;
        }
        finally 
    	{
        }
        return m;
    }
    // $ANTLR end "method"


    // $ANTLR start "stat"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:29:1: stat returns [Statement s] : (e= expr | ^( EQUALS ^(t= ID name= ID ) e= expr ) | ^( RETURN e= expr ) | ^( IF e= expr (st= stat )* ) );
    public Statement stat() // throws RecognitionException [1]
    {   
        Statement s = default(Statement);

        CommonTree t = null;
        CommonTree name = null;
        Expression e = default(Expression);

        Statement st = default(Statement);


        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:29:27: (e= expr | ^( EQUALS ^(t= ID name= ID ) e= expr ) | ^( RETURN e= expr ) | ^( IF e= expr (st= stat )* ) )
            int alt4 = 4;
            switch ( input.LA(1) ) 
            {
            case ID:
            case MINUS_OP:
            case INT:
            case STRING_LITERAL:
            case CHAR_LITERAL:
            case BOOL_LITERAL:
            case ARITH_OP:
            case MULT_OP:
            case DIV_OP:
            case REM_OP:
            	{
                alt4 = 1;
                }
                break;
            case EQUALS:
            	{
                alt4 = 2;
                }
                break;
            case RETURN:
            	{
                alt4 = 3;
                }
                break;
            case IF:
            	{
                alt4 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d4s0 =
            	        new NoViableAltException("", 4, 0, input);

            	    throw nvae_d4s0;
            }

            switch (alt4) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:29:30: e= expr
                    {
                    	PushFollow(FOLLOW_expr_in_stat141);
                    	e = expr();
                    	state.followingStackPointer--;

                    	 s =  TB.Statement(e); 

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:31:2: ^( EQUALS ^(t= ID name= ID ) e= expr )
                    {
                    	Match(input,EQUALS,FOLLOW_EQUALS_in_stat150); 

                    	Match(input, Token.DOWN, null); 
                    	t=(CommonTree)Match(input,ID,FOLLOW_ID_in_stat155); 

                    	Match(input, Token.DOWN, null); 
                    	name=(CommonTree)Match(input,ID,FOLLOW_ID_in_stat159); 

                    	Match(input, Token.UP, null); 
                    	PushFollow(FOLLOW_expr_in_stat164);
                    	e = expr();
                    	state.followingStackPointer--;

                    	s =  TB.DeclarationStatement(((t != null) ? t.Text : null), ((name != null) ? name.Text : null), e); 

                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:33:2: ^( RETURN e= expr )
                    {
                    	Match(input,RETURN,FOLLOW_RETURN_in_stat174); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_stat178);
                    	e = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 s =  TB.ReturnStatement(e); 

                    }
                    break;
                case 4 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:35:2: ^( IF e= expr (st= stat )* )
                    {
                    	Match(input,IF,FOLLOW_IF_in_stat188); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_stat192);
                    	e = expr();
                    	state.followingStackPointer--;

                    	 s =  TB.IfStatement(e); 
                    	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:35:42: (st= stat )*
                    	do 
                    	{
                    	    int alt3 = 2;
                    	    int LA3_0 = input.LA(1);

                    	    if ( (LA3_0 == ID || (LA3_0 >= EQUALS && LA3_0 <= IF) || (LA3_0 >= MINUS_OP && LA3_0 <= REM_OP)) )
                    	    {
                    	        alt3 = 1;
                    	    }


                    	    switch (alt3) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:35:43: st= stat
                    			    {
                    			    	PushFollow(FOLLOW_stat_in_stat199);
                    			    	st = stat();
                    			    	state.followingStackPointer--;

                    			    	 ((IfStatement)s).IfBody.Add(st); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop3;
                    	    }
                    	} while (true);

                    	loop3:
                    		;	// Stops C# compiler whining that label 'loop3' has no statements


                    	Match(input, Token.UP, null); 

                    }
                    break;

            }
        }

        catch (RecognitionException)
        {
        throw;
        }
        finally 
    	{
        }
        return s;
    }
    // $ANTLR end "stat"


    // $ANTLR start "expr"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:37:1: expr returns [Expression e] : ( ^( '+' a= expr b= expr ) | ^( '-' a= expr b= expr ) | ^( '*' a= expr b= expr ) | ^( '/' a= expr b= expr ) | ^( '%' a= expr b= expr ) | STRING_LITERAL | CHAR_LITERAL | INT | MINUS_OP INT | ID | BOOL_LITERAL );
    public Expression expr() // throws RecognitionException [1]
    {   
        Expression e = default(Expression);

        CommonTree STRING_LITERAL1 = null;
        CommonTree CHAR_LITERAL2 = null;
        CommonTree INT3 = null;
        CommonTree INT4 = null;
        CommonTree ID5 = null;
        CommonTree BOOL_LITERAL6 = null;
        Expression a = default(Expression);

        Expression b = default(Expression);


        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:38:5: ( ^( '+' a= expr b= expr ) | ^( '-' a= expr b= expr ) | ^( '*' a= expr b= expr ) | ^( '/' a= expr b= expr ) | ^( '%' a= expr b= expr ) | STRING_LITERAL | CHAR_LITERAL | INT | MINUS_OP INT | ID | BOOL_LITERAL )
            int alt5 = 11;
            alt5 = dfa5.Predict(input);
            switch (alt5) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:38:9: ^( '+' a= expr b= expr )
                    {
                    	Match(input,ARITH_OP,FOLLOW_ARITH_OP_in_expr224); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr228);
                    	a = expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr232);
                    	b = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 e =  TB.AdditionExpression(a, b);

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:39:8: ^( '-' a= expr b= expr )
                    {
                    	Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_expr251); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr255);
                    	a = expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr259);
                    	b = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 e =  TB.SubtractionExpression(a, b);

                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:40:8: ^( '*' a= expr b= expr )
                    {
                    	Match(input,MULT_OP,FOLLOW_MULT_OP_in_expr278); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr282);
                    	a = expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr286);
                    	b = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 e =  TB.MultiplicationExpression(a, b); 

                    }
                    break;
                case 4 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:41:8: ^( '/' a= expr b= expr )
                    {
                    	Match(input,DIV_OP,FOLLOW_DIV_OP_in_expr305); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr309);
                    	a = expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr313);
                    	b = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 e =  TB.DivisionExpression(a, b); 

                    }
                    break;
                case 5 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:42:8: ^( '%' a= expr b= expr )
                    {
                    	Match(input,REM_OP,FOLLOW_REM_OP_in_expr332); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr336);
                    	a = expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr340);
                    	b = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 e =  TB.RemainderExpression(a, b);

                    }
                    break;
                case 6 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:43:9: STRING_LITERAL
                    {
                    	STRING_LITERAL1=(CommonTree)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_expr359); 
                    	 e =  TB.StringExpression(((STRING_LITERAL1 != null) ? STRING_LITERAL1.Text : null));

                    }
                    break;
                case 7 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:44:7: CHAR_LITERAL
                    {
                    	CHAR_LITERAL2=(CommonTree)Match(input,CHAR_LITERAL,FOLLOW_CHAR_LITERAL_in_expr381); 
                    	 e =  TB.CharExpression(((CHAR_LITERAL2 != null) ? CHAR_LITERAL2.Text : null).Replace("'",""));

                    }
                    break;
                case 8 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:45:9: INT
                    {
                    	INT3=(CommonTree)Match(input,INT,FOLLOW_INT_in_expr397); 
                    	 e =  TB.IntegerExpression(((INT3 != null) ? INT3.Text : null));

                    }
                    break;
                case 9 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:46:9: MINUS_OP INT
                    {
                    	Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_expr432); 
                    	INT4=(CommonTree)Match(input,INT,FOLLOW_INT_in_expr434); 
                    	 e =  TB.IntegerExpression("-" + ((INT4 != null) ? INT4.Text : null));

                    }
                    break;
                case 10 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:47:7: ID
                    {
                    	ID5=(CommonTree)Match(input,ID,FOLLOW_ID_in_expr458); 
                    	 e =  TB.IdExpression(((ID5 != null) ? ID5.Text : null));

                    }
                    break;
                case 11 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:48:7: BOOL_LITERAL
                    {
                    	BOOL_LITERAL6=(CommonTree)Match(input,BOOL_LITERAL,FOLLOW_BOOL_LITERAL_in_expr473); 
                    	 e =  TB.BooleanExpression(((BOOL_LITERAL6 != null) ? BOOL_LITERAL6.Text : null));

                    }
                    break;

            }
        }

        catch (RecognitionException) {
        throw;
        }
        finally 
    	{
        }
        return e;
    }
    // $ANTLR end "expr"

    // Delegated rules


   	protected DFA5 dfa5;
	private void InitializeCyclicDFAs()
	{
    	this.dfa5 = new DFA5(this);
	}

    const string DFA5_eotS =
        "\x0d\uffff";
    const string DFA5_eofS =
        "\x0d\uffff";
    const string DFA5_minS =
        "\x01\x06\x01\uffff\x01\x02\x0a\uffff";
    const string DFA5_maxS =
        "\x01\x15\x01\uffff\x01\x0e\x0a\uffff";
    const string DFA5_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x0a\x01\x0b\x01\x02\x01\x09";
    const string DFA5_specialS =
        "\x0d\uffff}>";
    static readonly string[] DFA5_transitionS = {
            "\x01\x09\x06\uffff\x01\x02\x01\x08\x01\x06\x01\x07\x01\x0a"+
            "\x01\x01\x01\x03\x01\x04\x01\x05",
            "",
            "\x01\x0b\x0b\uffff\x01\x0c",
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

    static readonly short[] DFA5_eot = DFA.UnpackEncodedString(DFA5_eotS);
    static readonly short[] DFA5_eof = DFA.UnpackEncodedString(DFA5_eofS);
    static readonly char[] DFA5_min = DFA.UnpackEncodedStringToUnsignedChars(DFA5_minS);
    static readonly char[] DFA5_max = DFA.UnpackEncodedStringToUnsignedChars(DFA5_maxS);
    static readonly short[] DFA5_accept = DFA.UnpackEncodedString(DFA5_acceptS);
    static readonly short[] DFA5_special = DFA.UnpackEncodedString(DFA5_specialS);
    static readonly short[][] DFA5_transition = DFA.UnpackEncodedStringArray(DFA5_transitionS);

    protected class DFA5 : DFA
    {
        public DFA5(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 5;
            this.eot = DFA5_eot;
            this.eof = DFA5_eof;
            this.min = DFA5_min;
            this.max = DFA5_max;
            this.accept = DFA5_accept;
            this.special = DFA5_special;
            this.transition = DFA5_transition;

        }

        override public string Description
        {
            get { return "37:1: expr returns [Expression e] : ( ^( '+' a= expr b= expr ) | ^( '-' a= expr b= expr ) | ^( '*' a= expr b= expr ) | ^( '/' a= expr b= expr ) | ^( '%' a= expr b= expr ) | STRING_LITERAL | CHAR_LITERAL | INT | MINUS_OP INT | ID | BOOL_LITERAL );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_CLASS_in_prog66 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_prog70 = new BitSet(new ulong[]{0x0000000000000018UL});
    public static readonly BitSet FOLLOW_method_in_prog77 = new BitSet(new ulong[]{0x0000000000000018UL});
    public static readonly BitSet FOLLOW_METHOD_in_method99 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_method103 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_ID_in_method107 = new BitSet(new ulong[]{0x00000000003FE748UL});
    public static readonly BitSet FOLLOW_stat_in_method114 = new BitSet(new ulong[]{0x00000000003FE748UL});
    public static readonly BitSet FOLLOW_expr_in_stat141 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EQUALS_in_stat150 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_stat155 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_stat159 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_expr_in_stat164 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_RETURN_in_stat174 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_stat178 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IF_in_stat188 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_stat192 = new BitSet(new ulong[]{0x00000000003FE748UL});
    public static readonly BitSet FOLLOW_stat_in_stat199 = new BitSet(new ulong[]{0x00000000003FE748UL});
    public static readonly BitSet FOLLOW_ARITH_OP_in_expr224 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr228 = new BitSet(new ulong[]{0x00000000003FE040UL});
    public static readonly BitSet FOLLOW_expr_in_expr232 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_expr251 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr255 = new BitSet(new ulong[]{0x00000000003FE040UL});
    public static readonly BitSet FOLLOW_expr_in_expr259 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MULT_OP_in_expr278 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr282 = new BitSet(new ulong[]{0x00000000003FE040UL});
    public static readonly BitSet FOLLOW_expr_in_expr286 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_DIV_OP_in_expr305 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr309 = new BitSet(new ulong[]{0x00000000003FE040UL});
    public static readonly BitSet FOLLOW_expr_in_expr313 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_REM_OP_in_expr332 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr336 = new BitSet(new ulong[]{0x00000000003FE040UL});
    public static readonly BitSet FOLLOW_expr_in_expr340 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_expr359 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_LITERAL_in_expr381 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_expr397 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_expr432 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_INT_in_expr434 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_expr458 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOL_LITERAL_in_expr473 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}