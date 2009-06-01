// $ANTLR 3.1.2 C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g 2009-06-01 23:58:38

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
namespace 
    Decaf

{

using Decaf.Tree;


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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:17:1: prog returns [Class c] : ^( CLASS name= ID (m= method )* ) ;
    public Class prog() // throws RecognitionException [1]
    {   
        Class c = default(Class);

        CommonTree name = null;
        Method m = default(Method);


        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:17:23: ( ^( CLASS name= ID (m= method )* ) )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:17:25: ^( CLASS name= ID (m= method )* )
            {
            	Match(input,CLASS,FOLLOW_CLASS_in_prog59); 

            	Match(input, Token.DOWN, null); 
            	name=(CommonTree)Match(input,ID,FOLLOW_ID_in_prog63); 
            	c =  TB.Class(((name != null) ? name.Text : null)); CodeGenerator.StartModule(((name != null) ? name.Text : null));
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:17:109: (m= method )*
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
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:17:110: m= method
            			    {
            			    	PushFollow(FOLLOW_method_in_prog70);
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
        return c;
    }
    // $ANTLR end "prog"


    // $ANTLR start "method"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:20:1: method returns [Method m] : ^( METHOD name= ID (s= stat )* ) ;
    public Method method() // throws RecognitionException [1]
    {   
        Method m = default(Method);

        CommonTree name = null;
        Statement s = default(Statement);


        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:20:26: ( ^( METHOD name= ID (s= stat )* ) )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:20:28: ^( METHOD name= ID (s= stat )* )
            {
            	Match(input,METHOD,FOLLOW_METHOD_in_method94); 

            	Match(input, Token.DOWN, null); 
            	name=(CommonTree)Match(input,ID,FOLLOW_ID_in_method98); 
            	 CodeGenerator.BeginMethod(((name != null) ? name.Text : null)); m =  TB.Method(((name != null) ? name.Text : null));
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:20:115: (s= stat )*
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
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:20:116: s= stat
            			    {
            			    	PushFollow(FOLLOW_stat_in_method105);
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
        return m;
    }
    // $ANTLR end "method"


    // $ANTLR start "stat"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:22:1: stat returns [Statement s] : (e= expr | ^( EQUALS ^(t= ID name= ID ) e= expr ) );
    public Statement stat() // throws RecognitionException [1]
    {   
        Statement s = default(Statement);

        CommonTree t = null;
        CommonTree name = null;
        Expression e = default(Expression);


        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:22:27: (e= expr | ^( EQUALS ^(t= ID name= ID ) e= expr ) )
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
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:22:31: e= expr
                    {
                    	CodeGenerator.BeginExpression();
                    	PushFollow(FOLLOW_expr_in_stat136);
                    	e = expr();
                    	state.followingStackPointer--;

                    	 s =  TB.Statement(e); CodeGenerator.EndExpression();

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:24:2: ^( EQUALS ^(t= ID name= ID ) e= expr )
                    {
                    	Match(input,EQUALS,FOLLOW_EQUALS_in_stat145); 

                    	Match(input, Token.DOWN, null); 
                    	t=(CommonTree)Match(input,ID,FOLLOW_ID_in_stat150); 

                    	Match(input, Token.DOWN, null); 
                    	name=(CommonTree)Match(input,ID,FOLLOW_ID_in_stat154); 

                    	Match(input, Token.UP, null); 
                    	CodeGenerator.DefineVariable(((name != null) ? name.Text : null), ((t != null) ? t.Text : null)); CodeGenerator.BeginExpression();
                    	PushFollow(FOLLOW_expr_in_stat161);
                    	e = expr();
                    	state.followingStackPointer--;

                    	s =  TB.DeclarationStatement(((t != null) ? t.Text : null), ((name != null) ? name.Text : null), e); CodeGenerator.EndExpression(); CodeGenerator.AssignExpression(((name != null) ? name.Text : null)); 

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
        return s;
    }
    // $ANTLR end "stat"


    // $ANTLR start "expr"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:26:1: expr returns [Expression e] : ( ^( '+' a= expr b= expr ) | ^( '-' a= expr b= expr ) | ^( '*' a= expr b= expr ) | ^( '/' a= expr b= expr ) | ^( '%' a= expr b= expr ) | STRING_LITERAL | CHAR_LITERAL | INT | MINUS_OP INT | ID | BOOL_LITERAL );
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
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:27:5: ( ^( '+' a= expr b= expr ) | ^( '-' a= expr b= expr ) | ^( '*' a= expr b= expr ) | ^( '/' a= expr b= expr ) | ^( '%' a= expr b= expr ) | STRING_LITERAL | CHAR_LITERAL | INT | MINUS_OP INT | ID | BOOL_LITERAL )
            int alt4 = 11;
            alt4 = dfa4.Predict(input);
            switch (alt4) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:27:9: ^( '+' a= expr b= expr )
                    {
                    	Match(input,ARITH_OP,FOLLOW_ARITH_OP_in_expr183); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr187);
                    	a = expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr191);
                    	b = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 CodeGenerator.Operation("Addition"); e =  TB.AdditionExpression(a, b);

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:28:8: ^( '-' a= expr b= expr )
                    {
                    	Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_expr210); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr214);
                    	a = expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr218);
                    	b = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 CodeGenerator.Operation("Subtraction"); e =  TB.SubtractionExpression(a, b);

                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:29:8: ^( '*' a= expr b= expr )
                    {
                    	Match(input,MULT_OP,FOLLOW_MULT_OP_in_expr237); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr241);
                    	a = expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr245);
                    	b = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 CodeGenerator.Operation("Multiplication"); e =  TB.MultiplicationExpression(a, b); 

                    }
                    break;
                case 4 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:30:8: ^( '/' a= expr b= expr )
                    {
                    	Match(input,DIV_OP,FOLLOW_DIV_OP_in_expr264); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr268);
                    	a = expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr272);
                    	b = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 CodeGenerator.Operation("Division"); e =  TB.DivisionExpression(a, b); 

                    }
                    break;
                case 5 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:31:8: ^( '%' a= expr b= expr )
                    {
                    	Match(input,REM_OP,FOLLOW_REM_OP_in_expr291); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr295);
                    	a = expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr299);
                    	b = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 CodeGenerator.Operation("Remainder"); e =  TB.RemainderExpression(a, b);

                    }
                    break;
                case 6 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:32:9: STRING_LITERAL
                    {
                    	STRING_LITERAL1=(CommonTree)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_expr318); 
                    	 CodeGenerator.ExprString(((STRING_LITERAL1 != null) ? STRING_LITERAL1.Text : null)); e =  TB.StringExpression(((STRING_LITERAL1 != null) ? STRING_LITERAL1.Text : null));

                    }
                    break;
                case 7 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:33:7: CHAR_LITERAL
                    {
                    	CHAR_LITERAL2=(CommonTree)Match(input,CHAR_LITERAL,FOLLOW_CHAR_LITERAL_in_expr340); 
                    	 CodeGenerator.ExprChar(char.Parse(((CHAR_LITERAL2 != null) ? CHAR_LITERAL2.Text : null).Replace("'","")));  
                    	    				     e =  TB.CharExpression(((CHAR_LITERAL2 != null) ? CHAR_LITERAL2.Text : null).Replace("'",""));

                    }
                    break;
                case 8 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:35:9: INT
                    {
                    	INT3=(CommonTree)Match(input,INT,FOLLOW_INT_in_expr356); 
                    	 CodeGenerator.ExprNumber(int.Parse(((INT3 != null) ? INT3.Text : null))); e =  TB.IntegerExpression(((INT3 != null) ? INT3.Text : null));

                    }
                    break;
                case 9 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:36:9: MINUS_OP INT
                    {
                    	Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_expr391); 
                    	INT4=(CommonTree)Match(input,INT,FOLLOW_INT_in_expr393); 
                    	 CodeGenerator.ExprNumber(-int.Parse(((INT4 != null) ? INT4.Text : null))); e =  TB.IntegerExpression("-" + ((INT4 != null) ? INT4.Text : null));

                    }
                    break;
                case 10 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:37:7: ID
                    {
                    	ID5=(CommonTree)Match(input,ID,FOLLOW_ID_in_expr417); 
                    	 CodeGenerator.ExprId(((ID5 != null) ? ID5.Text : null)); e =  TB.IdExpression(((ID5 != null) ? ID5.Text : null));

                    }
                    break;
                case 11 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\DecafTree.g:38:7: BOOL_LITERAL
                    {
                    	BOOL_LITERAL6=(CommonTree)Match(input,BOOL_LITERAL,FOLLOW_BOOL_LITERAL_in_expr432); 
                    	 CodeGenerator.ExprBool(bool.Parse(((BOOL_LITERAL6 != null) ? BOOL_LITERAL6.Text : null))); e =  TB.BooleanExpression(((BOOL_LITERAL6 != null) ? BOOL_LITERAL6.Text : null));

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
        return e;
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
            get { return "26:1: expr returns [Expression e] : ( ^( '+' a= expr b= expr ) | ^( '-' a= expr b= expr ) | ^( '*' a= expr b= expr ) | ^( '/' a= expr b= expr ) | ^( '%' a= expr b= expr ) | STRING_LITERAL | CHAR_LITERAL | INT | MINUS_OP INT | ID | BOOL_LITERAL );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_CLASS_in_prog59 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_prog63 = new BitSet(new ulong[]{0x0000000000000018UL});
    public static readonly BitSet FOLLOW_method_in_prog70 = new BitSet(new ulong[]{0x0000000000000018UL});
    public static readonly BitSet FOLLOW_METHOD_in_method94 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_method98 = new BitSet(new ulong[]{0x00000000000FE748UL});
    public static readonly BitSet FOLLOW_stat_in_method105 = new BitSet(new ulong[]{0x00000000000FE748UL});
    public static readonly BitSet FOLLOW_expr_in_stat136 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EQUALS_in_stat145 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_stat150 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_stat154 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_expr_in_stat161 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_ARITH_OP_in_expr183 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr187 = new BitSet(new ulong[]{0x00000000000FE640UL});
    public static readonly BitSet FOLLOW_expr_in_expr191 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_expr210 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr214 = new BitSet(new ulong[]{0x00000000000FE640UL});
    public static readonly BitSet FOLLOW_expr_in_expr218 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MULT_OP_in_expr237 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr241 = new BitSet(new ulong[]{0x00000000000FE640UL});
    public static readonly BitSet FOLLOW_expr_in_expr245 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_DIV_OP_in_expr264 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr268 = new BitSet(new ulong[]{0x00000000000FE640UL});
    public static readonly BitSet FOLLOW_expr_in_expr272 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_REM_OP_in_expr291 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr295 = new BitSet(new ulong[]{0x00000000000FE640UL});
    public static readonly BitSet FOLLOW_expr_in_expr299 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_expr318 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_LITERAL_in_expr340 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_expr356 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_expr391 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_INT_in_expr393 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_expr417 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOL_LITERAL_in_expr432 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}