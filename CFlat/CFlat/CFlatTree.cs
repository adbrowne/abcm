// $ANTLR 3.1.2 C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g 2009-06-19 18:23:27

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
		"CALL", 
		"CLASS", 
		"ID", 
		"EOS", 
		"EQUALS", 
		"RETURN", 
		"IF", 
		"LBRAC", 
		"RBRAC", 
		"WHILE", 
		"REL_OP", 
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
		"'()'"
    };

    public const int ALPHA_NUM = 27;
    public const int CLASS = 6;
    public const int MULT_OP = 22;
    public const int T__29 = 29;
    public const int WHILE = 14;
    public const int DIV_OP = 23;
    public const int ARITH_OP = 21;
    public const int REM_OP = 24;
    public const int INT = 17;
    public const int EQUALS = 9;
    public const int BOOL_LITERAL = 20;
    public const int ID = 7;
    public const int EOF = -1;
    public const int LBRAC = 12;
    public const int ALPHA = 26;
    public const int IF = 11;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int STRING_LITERAL = 18;
    public const int WS = 28;
    public const int CHAR_LITERAL = 19;
    public const int REL_OP = 15;
    public const int RBRAC = 13;
    public const int RETURN = 10;
    public const int EOS = 8;
    public const int MINUS_OP = 16;
    public const int CALL = 5;
    public const int METHOD = 4;
    public const int CALLOUT = 25;

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

            	    if ( (LA2_0 == CALL || LA2_0 == ID || (LA2_0 >= EQUALS && LA2_0 <= IF) || (LA2_0 >= WHILE && LA2_0 <= REM_OP)) )
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
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:29:1: stat returns [Statement s] : (e= expr | ^( EQUALS ^(t= ID name= ID ) e= expr ) | ^( EQUALS name= ID e= expr ) | ^( RETURN e= expr ) | ^( IF e= expr (st= stat )* ) | ^( WHILE e= expr (st= stat )* ) );
    public Statement stat() // throws RecognitionException [1]
    {   
        Statement s = default(Statement);

        CommonTree t = null;
        CommonTree name = null;
        Expression e = default(Expression);

        Statement st = default(Statement);


        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:29:27: (e= expr | ^( EQUALS ^(t= ID name= ID ) e= expr ) | ^( EQUALS name= ID e= expr ) | ^( RETURN e= expr ) | ^( IF e= expr (st= stat )* ) | ^( WHILE e= expr (st= stat )* ) )
            int alt5 = 6;
            alt5 = dfa5.Predict(input);
            switch (alt5) 
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
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:33:2: ^( EQUALS name= ID e= expr )
                    {
                    	Match(input,EQUALS,FOLLOW_EQUALS_in_stat174); 

                    	Match(input, Token.DOWN, null); 
                    	name=(CommonTree)Match(input,ID,FOLLOW_ID_in_stat178); 
                    	PushFollow(FOLLOW_expr_in_stat182);
                    	e = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	s =  TB.AssignmentStatement(((name != null) ? name.Text : null), e); 

                    }
                    break;
                case 4 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:35:2: ^( RETURN e= expr )
                    {
                    	Match(input,RETURN,FOLLOW_RETURN_in_stat192); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_stat196);
                    	e = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 s =  TB.ReturnStatement(e); 

                    }
                    break;
                case 5 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:37:2: ^( IF e= expr (st= stat )* )
                    {
                    	Match(input,IF,FOLLOW_IF_in_stat206); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_stat210);
                    	e = expr();
                    	state.followingStackPointer--;

                    	 s =  TB.IfStatement(e); 
                    	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:37:42: (st= stat )*
                    	do 
                    	{
                    	    int alt3 = 2;
                    	    int LA3_0 = input.LA(1);

                    	    if ( (LA3_0 == CALL || LA3_0 == ID || (LA3_0 >= EQUALS && LA3_0 <= IF) || (LA3_0 >= WHILE && LA3_0 <= REM_OP)) )
                    	    {
                    	        alt3 = 1;
                    	    }


                    	    switch (alt3) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:37:43: st= stat
                    			    {
                    			    	PushFollow(FOLLOW_stat_in_stat217);
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
                case 6 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:39:2: ^( WHILE e= expr (st= stat )* )
                    {
                    	Match(input,WHILE,FOLLOW_WHILE_in_stat230); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_stat234);
                    	e = expr();
                    	state.followingStackPointer--;

                    	 s =  TB.WhileStatement(e); 
                    	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:39:48: (st= stat )*
                    	do 
                    	{
                    	    int alt4 = 2;
                    	    int LA4_0 = input.LA(1);

                    	    if ( (LA4_0 == CALL || LA4_0 == ID || (LA4_0 >= EQUALS && LA4_0 <= IF) || (LA4_0 >= WHILE && LA4_0 <= REM_OP)) )
                    	    {
                    	        alt4 = 1;
                    	    }


                    	    switch (alt4) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:39:49: st= stat
                    			    {
                    			    	PushFollow(FOLLOW_stat_in_stat241);
                    			    	st = stat();
                    			    	state.followingStackPointer--;

                    			    	 ((WhileStatement)s).Body.Add(st); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop4;
                    	    }
                    	} while (true);

                    	loop4:
                    		;	// Stops C# compiler whining that label 'loop4' has no statements


                    	Match(input, Token.UP, null); 

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
        return s;
    }
    // $ANTLR end "stat"


    // $ANTLR start "expr"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:42:1: expr returns [Expression e] : ( ^( '+' a= expr b= expr ) | ^( '-' a= expr b= expr ) | ^( '*' a= expr b= expr ) | ^( '/' a= expr b= expr ) | ^( '%' a= expr b= expr ) | ^( REL_OP a= expr b= expr ) | STRING_LITERAL | CHAR_LITERAL | INT | MINUS_OP INT | ID | BOOL_LITERAL | ^( CALL n= ID ) );
    public Expression expr() // throws RecognitionException [1]
    {   
        Expression e = default(Expression);

        CommonTree n = null;
        CommonTree REL_OP1 = null;
        CommonTree STRING_LITERAL2 = null;
        CommonTree CHAR_LITERAL3 = null;
        CommonTree INT4 = null;
        CommonTree INT5 = null;
        CommonTree ID6 = null;
        CommonTree BOOL_LITERAL7 = null;
        Expression a = default(Expression);

        Expression b = default(Expression);


        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:43:5: ( ^( '+' a= expr b= expr ) | ^( '-' a= expr b= expr ) | ^( '*' a= expr b= expr ) | ^( '/' a= expr b= expr ) | ^( '%' a= expr b= expr ) | ^( REL_OP a= expr b= expr ) | STRING_LITERAL | CHAR_LITERAL | INT | MINUS_OP INT | ID | BOOL_LITERAL | ^( CALL n= ID ) )
            int alt6 = 13;
            alt6 = dfa6.Predict(input);
            switch (alt6) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:43:9: ^( '+' a= expr b= expr )
                    {
                    	Match(input,ARITH_OP,FOLLOW_ARITH_OP_in_expr268); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr272);
                    	a = expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr276);
                    	b = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 e =  TB.AdditionExpression(a, b);

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:44:8: ^( '-' a= expr b= expr )
                    {
                    	Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_expr295); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr299);
                    	a = expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr303);
                    	b = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 e =  TB.SubtractionExpression(a, b);

                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:45:8: ^( '*' a= expr b= expr )
                    {
                    	Match(input,MULT_OP,FOLLOW_MULT_OP_in_expr322); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr326);
                    	a = expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr330);
                    	b = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 e =  TB.MultiplicationExpression(a, b); 

                    }
                    break;
                case 4 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:46:8: ^( '/' a= expr b= expr )
                    {
                    	Match(input,DIV_OP,FOLLOW_DIV_OP_in_expr349); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr353);
                    	a = expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr357);
                    	b = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 e =  TB.DivisionExpression(a, b); 

                    }
                    break;
                case 5 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:47:8: ^( '%' a= expr b= expr )
                    {
                    	Match(input,REM_OP,FOLLOW_REM_OP_in_expr376); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr380);
                    	a = expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr384);
                    	b = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 e =  TB.RemainderExpression(a, b);

                    }
                    break;
                case 6 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:48:7: ^( REL_OP a= expr b= expr )
                    {
                    	REL_OP1=(CommonTree)Match(input,REL_OP,FOLLOW_REL_OP_in_expr402); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr406);
                    	a = expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr410);
                    	b = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 e =  TB.RelationalExpression(((REL_OP1 != null) ? REL_OP1.Text : null),a,b);

                    }
                    break;
                case 7 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:49:9: STRING_LITERAL
                    {
                    	STRING_LITERAL2=(CommonTree)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_expr426); 
                    	 e =  TB.StringExpression(((STRING_LITERAL2 != null) ? STRING_LITERAL2.Text : null));

                    }
                    break;
                case 8 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:50:7: CHAR_LITERAL
                    {
                    	CHAR_LITERAL3=(CommonTree)Match(input,CHAR_LITERAL,FOLLOW_CHAR_LITERAL_in_expr448); 
                    	 e =  TB.CharExpression(((CHAR_LITERAL3 != null) ? CHAR_LITERAL3.Text : null).Replace("'",""));

                    }
                    break;
                case 9 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:51:9: INT
                    {
                    	INT4=(CommonTree)Match(input,INT,FOLLOW_INT_in_expr464); 
                    	 e =  TB.IntegerExpression(((INT4 != null) ? INT4.Text : null));

                    }
                    break;
                case 10 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:52:9: MINUS_OP INT
                    {
                    	Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_expr499); 
                    	INT5=(CommonTree)Match(input,INT,FOLLOW_INT_in_expr501); 
                    	 e =  TB.IntegerExpression("-" + ((INT5 != null) ? INT5.Text : null));

                    }
                    break;
                case 11 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:53:7: ID
                    {
                    	ID6=(CommonTree)Match(input,ID,FOLLOW_ID_in_expr525); 
                    	 e =  TB.IdExpression(((ID6 != null) ? ID6.Text : null));

                    }
                    break;
                case 12 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:54:7: BOOL_LITERAL
                    {
                    	BOOL_LITERAL7=(CommonTree)Match(input,BOOL_LITERAL,FOLLOW_BOOL_LITERAL_in_expr540); 
                    	 e =  TB.BooleanExpression(((BOOL_LITERAL7 != null) ? BOOL_LITERAL7.Text : null));

                    }
                    break;
                case 13 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:55:7: ^( CALL n= ID )
                    {
                    	Match(input,CALL,FOLLOW_CALL_in_expr555); 

                    	Match(input, Token.DOWN, null); 
                    	n=(CommonTree)Match(input,ID,FOLLOW_ID_in_expr559); 

                    	Match(input, Token.UP, null); 
                    	 e =  TB.MethodCall(((n != null) ? n.Text : null));

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
   	protected DFA6 dfa6;
	private void InitializeCyclicDFAs()
	{
    	this.dfa5 = new DFA5(this);
    	this.dfa6 = new DFA6(this);


	}

    const string DFA5_eotS =
        "\x0a\uffff";
    const string DFA5_eofS =
        "\x0a\uffff";
    const string DFA5_minS =
        "\x01\x05\x01\uffff\x01\x02\x03\uffff\x01\x07\x01\x02\x02\uffff";
    const string DFA5_maxS =
        "\x01\x18\x01\uffff\x01\x02\x03\uffff\x01\x07\x01\x18\x02\uffff";
    const string DFA5_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x04\x01\x05\x01\x06\x02\uffff"+
        "\x01\x02\x01\x03";
    const string DFA5_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA5_transitionS = {
            "\x01\x01\x01\uffff\x01\x01\x01\uffff\x01\x02\x01\x03\x01\x04"+
            "\x02\uffff\x01\x05\x0a\x01",
            "",
            "\x01\x06",
            "",
            "",
            "",
            "\x01\x07",
            "\x01\x08\x02\uffff\x01\x09\x01\uffff\x01\x09\x07\uffff\x0a"+
            "\x09",
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
            get { return "29:1: stat returns [Statement s] : (e= expr | ^( EQUALS ^(t= ID name= ID ) e= expr ) | ^( EQUALS name= ID e= expr ) | ^( RETURN e= expr ) | ^( IF e= expr (st= stat )* ) | ^( WHILE e= expr (st= stat )* ) );"; }
        }

    }

    const string DFA6_eotS =
        "\x0f\uffff";
    const string DFA6_eofS =
        "\x0f\uffff";
    const string DFA6_minS =
        "\x01\x05\x01\uffff\x01\x02\x0c\uffff";
    const string DFA6_maxS =
        "\x01\x18\x01\uffff\x01\x11\x0c\uffff";
    const string DFA6_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x09\x01\x0b\x01\x0c\x01\x0d\x01\x02\x01\x0a";
    const string DFA6_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA6_transitionS = {
            "\x01\x0c\x01\uffff\x01\x0a\x07\uffff\x01\x06\x01\x02\x01\x09"+
            "\x01\x07\x01\x08\x01\x0b\x01\x01\x01\x03\x01\x04\x01\x05",
            "",
            "\x01\x0d\x0e\uffff\x01\x0e",
            "",
            "",
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

    static readonly short[] DFA6_eot = DFA.UnpackEncodedString(DFA6_eotS);
    static readonly short[] DFA6_eof = DFA.UnpackEncodedString(DFA6_eofS);
    static readonly char[] DFA6_min = DFA.UnpackEncodedStringToUnsignedChars(DFA6_minS);
    static readonly char[] DFA6_max = DFA.UnpackEncodedStringToUnsignedChars(DFA6_maxS);
    static readonly short[] DFA6_accept = DFA.UnpackEncodedString(DFA6_acceptS);
    static readonly short[] DFA6_special = DFA.UnpackEncodedString(DFA6_specialS);
    static readonly short[][] DFA6_transition = DFA.UnpackEncodedStringArray(DFA6_transitionS);

    protected class DFA6 : DFA
    {
        public DFA6(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 6;
            this.eot = DFA6_eot;
            this.eof = DFA6_eof;
            this.min = DFA6_min;
            this.max = DFA6_max;
            this.accept = DFA6_accept;
            this.special = DFA6_special;
            this.transition = DFA6_transition;

        }

        override public string Description
        {
            get { return "42:1: expr returns [Expression e] : ( ^( '+' a= expr b= expr ) | ^( '-' a= expr b= expr ) | ^( '*' a= expr b= expr ) | ^( '/' a= expr b= expr ) | ^( '%' a= expr b= expr ) | ^( REL_OP a= expr b= expr ) | STRING_LITERAL | CHAR_LITERAL | INT | MINUS_OP INT | ID | BOOL_LITERAL | ^( CALL n= ID ) );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_CLASS_in_prog66 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_prog70 = new BitSet(new ulong[]{0x0000000000000018UL});
    public static readonly BitSet FOLLOW_method_in_prog77 = new BitSet(new ulong[]{0x0000000000000018UL});
    public static readonly BitSet FOLLOW_METHOD_in_method99 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_method103 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_ID_in_method107 = new BitSet(new ulong[]{0x0000000001FFCEA8UL});
    public static readonly BitSet FOLLOW_stat_in_method114 = new BitSet(new ulong[]{0x0000000001FFCEA8UL});
    public static readonly BitSet FOLLOW_expr_in_stat141 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EQUALS_in_stat150 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_stat155 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_stat159 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_expr_in_stat164 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_EQUALS_in_stat174 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_stat178 = new BitSet(new ulong[]{0x0000000001FF80A0UL});
    public static readonly BitSet FOLLOW_expr_in_stat182 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_RETURN_in_stat192 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_stat196 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IF_in_stat206 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_stat210 = new BitSet(new ulong[]{0x0000000001FFCEA8UL});
    public static readonly BitSet FOLLOW_stat_in_stat217 = new BitSet(new ulong[]{0x0000000001FFCEA8UL});
    public static readonly BitSet FOLLOW_WHILE_in_stat230 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_stat234 = new BitSet(new ulong[]{0x0000000001FFCEA8UL});
    public static readonly BitSet FOLLOW_stat_in_stat241 = new BitSet(new ulong[]{0x0000000001FFCEA8UL});
    public static readonly BitSet FOLLOW_ARITH_OP_in_expr268 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr272 = new BitSet(new ulong[]{0x0000000001FF80A0UL});
    public static readonly BitSet FOLLOW_expr_in_expr276 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_expr295 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr299 = new BitSet(new ulong[]{0x0000000001FF80A0UL});
    public static readonly BitSet FOLLOW_expr_in_expr303 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MULT_OP_in_expr322 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr326 = new BitSet(new ulong[]{0x0000000001FF80A0UL});
    public static readonly BitSet FOLLOW_expr_in_expr330 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_DIV_OP_in_expr349 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr353 = new BitSet(new ulong[]{0x0000000001FF80A0UL});
    public static readonly BitSet FOLLOW_expr_in_expr357 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_REM_OP_in_expr376 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr380 = new BitSet(new ulong[]{0x0000000001FF80A0UL});
    public static readonly BitSet FOLLOW_expr_in_expr384 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_REL_OP_in_expr402 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr406 = new BitSet(new ulong[]{0x0000000001FF80A0UL});
    public static readonly BitSet FOLLOW_expr_in_expr410 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_expr426 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_LITERAL_in_expr448 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_expr464 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_expr499 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_INT_in_expr501 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_expr525 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOL_LITERAL_in_expr540 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CALL_in_expr555 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_expr559 = new BitSet(new ulong[]{0x0000000000000008UL});

}
}