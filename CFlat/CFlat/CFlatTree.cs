// $ANTLR 3.1.2 C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g 2009-06-29 15:41:43

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
		"PARAM", 
		"CLASS", 
		"ID", 
		"EOS", 
		"RETURN", 
		"IF", 
		"LBRAC", 
		"RBRAC", 
		"WHILE", 
		"FOR", 
		"EQUALS", 
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
		"','"
    };

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
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:27:1: method returns [Method m] : ^( METHOD t= ID name= ID (p= param )* (s= stat )* ) ;
    public Method method() // throws RecognitionException [1]
    {   
        Method m = default(Method);

        CommonTree t = null;
        CommonTree name = null;
        Argument p = default(Argument);

        Statement s = default(Statement);


        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:27:26: ( ^( METHOD t= ID name= ID (p= param )* (s= stat )* ) )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:27:28: ^( METHOD t= ID name= ID (p= param )* (s= stat )* )
            {
            	Match(input,METHOD,FOLLOW_METHOD_in_method99); 

            	Match(input, Token.DOWN, null); 
            	t=(CommonTree)Match(input,ID,FOLLOW_ID_in_method103); 
            	name=(CommonTree)Match(input,ID,FOLLOW_ID_in_method107); 
            	 m =  TB.Method(((name != null) ? name.Text : null), ((t != null) ? t.Text : null)); 
            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:27:91: (p= param )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == PARAM) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:27:92: p= param
            			    {
            			    	PushFollow(FOLLOW_param_in_method114);
            			    	p = param();
            			    	state.followingStackPointer--;

            			    	m.Arguments.Add(p); 

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements

            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:27:126: (s= stat )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == CALL || LA3_0 == ID || (LA3_0 >= RETURN && LA3_0 <= IF) || (LA3_0 >= WHILE && LA3_0 <= REM_OP)) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:27:127: s= stat
            			    {
            			    	PushFollow(FOLLOW_stat_in_method123);
            			    	s = stat();
            			    	state.followingStackPointer--;

            			    	 m.Statements.Add(s); 

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


    // $ANTLR start "param"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:29:1: param returns [Argument a] : ^( PARAM t= ID n= ID ) ;
    public Argument param() // throws RecognitionException [1]
    {   
        Argument a = default(Argument);

        CommonTree t = null;
        CommonTree n = null;

        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:29:27: ( ^( PARAM t= ID n= ID ) )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:30:2: ^( PARAM t= ID n= ID )
            {
            	Match(input,PARAM,FOLLOW_PARAM_in_param147); 

            	Match(input, Token.DOWN, null); 
            	t=(CommonTree)Match(input,ID,FOLLOW_ID_in_param151); 
            	n=(CommonTree)Match(input,ID,FOLLOW_ID_in_param155); 

            	Match(input, Token.UP, null); 
            	 a =  TB.Argument(((t != null) ? t.Text : null), ((n != null) ? n.Text : null)); 

            }

        }

        catch (RecognitionException) {
        throw;
        }
        finally 
    	{
        }
        return a;
    }
    // $ANTLR end "param"


    // $ANTLR start "stat"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:32:1: stat returns [Statement s] : (e= expr | ds= declaration_stmt | as_stmt= assignment_stmt | ^( RETURN e= expr ) | ^( IF e= expr (st= stat )* ) | ^( WHILE e= expr (st= stat )* ) | ^( FOR ds= declaration_stmt e= expr as_stmt= assignment_stmt (st= stat )* ) );
    public Statement stat() // throws RecognitionException [1]
    {   
        Statement s = default(Statement);

        Expression e = default(Expression);

        Statement ds = default(Statement);

        AssignmentStatement as_stmt = default(AssignmentStatement);

        Statement st = default(Statement);


        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:32:27: (e= expr | ds= declaration_stmt | as_stmt= assignment_stmt | ^( RETURN e= expr ) | ^( IF e= expr (st= stat )* ) | ^( WHILE e= expr (st= stat )* ) | ^( FOR ds= declaration_stmt e= expr as_stmt= assignment_stmt (st= stat )* ) )
            int alt7 = 7;
            alt7 = dfa7.Predict(input);
            switch (alt7) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:32:30: e= expr
                    {
                    	PushFollow(FOLLOW_expr_in_stat173);
                    	e = expr();
                    	state.followingStackPointer--;

                    	 s =  TB.Statement(e); 

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:34:2: ds= declaration_stmt
                    {
                    	PushFollow(FOLLOW_declaration_stmt_in_stat183);
                    	ds = declaration_stmt();
                    	state.followingStackPointer--;

                    	s =  ds;

                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:36:2: as_stmt= assignment_stmt
                    {
                    	PushFollow(FOLLOW_assignment_stmt_in_stat193);
                    	as_stmt = assignment_stmt();
                    	state.followingStackPointer--;

                    	s =  as_stmt;

                    }
                    break;
                case 4 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:38:2: ^( RETURN e= expr )
                    {
                    	Match(input,RETURN,FOLLOW_RETURN_in_stat202); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_stat206);
                    	e = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 s =  TB.ReturnStatement(e); 

                    }
                    break;
                case 5 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:40:2: ^( IF e= expr (st= stat )* )
                    {
                    	Match(input,IF,FOLLOW_IF_in_stat216); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_stat220);
                    	e = expr();
                    	state.followingStackPointer--;

                    	 s =  TB.IfStatement(e); 
                    	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:40:42: (st= stat )*
                    	do 
                    	{
                    	    int alt4 = 2;
                    	    int LA4_0 = input.LA(1);

                    	    if ( (LA4_0 == CALL || LA4_0 == ID || (LA4_0 >= RETURN && LA4_0 <= IF) || (LA4_0 >= WHILE && LA4_0 <= REM_OP)) )
                    	    {
                    	        alt4 = 1;
                    	    }


                    	    switch (alt4) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:40:43: st= stat
                    			    {
                    			    	PushFollow(FOLLOW_stat_in_stat227);
                    			    	st = stat();
                    			    	state.followingStackPointer--;

                    			    	 ((IfStatement)s).IfBody.Add(st); 

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
                case 6 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:42:2: ^( WHILE e= expr (st= stat )* )
                    {
                    	Match(input,WHILE,FOLLOW_WHILE_in_stat240); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_stat244);
                    	e = expr();
                    	state.followingStackPointer--;

                    	 s =  TB.WhileStatement(e); 
                    	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:42:48: (st= stat )*
                    	do 
                    	{
                    	    int alt5 = 2;
                    	    int LA5_0 = input.LA(1);

                    	    if ( (LA5_0 == CALL || LA5_0 == ID || (LA5_0 >= RETURN && LA5_0 <= IF) || (LA5_0 >= WHILE && LA5_0 <= REM_OP)) )
                    	    {
                    	        alt5 = 1;
                    	    }


                    	    switch (alt5) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:42:49: st= stat
                    			    {
                    			    	PushFollow(FOLLOW_stat_in_stat251);
                    			    	st = stat();
                    			    	state.followingStackPointer--;

                    			    	 ((WhileStatement)s).Body.Add(st); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop5;
                    	    }
                    	} while (true);

                    	loop5:
                    		;	// Stops C# compiler whining that label 'loop5' has no statements


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 7 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:44:2: ^( FOR ds= declaration_stmt e= expr as_stmt= assignment_stmt (st= stat )* )
                    {
                    	Match(input,FOR,FOLLOW_FOR_in_stat264); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_declaration_stmt_in_stat268);
                    	ds = declaration_stmt();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_stat272);
                    	e = expr();
                    	state.followingStackPointer--;

                    	s =  TB.ForStatement(e); ((ForStatement)s).Declaration = (DeclarationStatement)ds;
                    	PushFollow(FOLLOW_assignment_stmt_in_stat284);
                    	as_stmt = assignment_stmt();
                    	state.followingStackPointer--;

                    	((ForStatement)s).Iterator = (AssignmentStatement)as_stmt;
                    	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:47:3: (st= stat )*
                    	do 
                    	{
                    	    int alt6 = 2;
                    	    int LA6_0 = input.LA(1);

                    	    if ( (LA6_0 == CALL || LA6_0 == ID || (LA6_0 >= RETURN && LA6_0 <= IF) || (LA6_0 >= WHILE && LA6_0 <= REM_OP)) )
                    	    {
                    	        alt6 = 1;
                    	    }


                    	    switch (alt6) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:47:4: st= stat
                    			    {
                    			    	PushFollow(FOLLOW_stat_in_stat293);
                    			    	st = stat();
                    			    	state.followingStackPointer--;

                    			    	((ForStatement)s).Body.Add(st);

                    			    }
                    			    break;

                    			default:
                    			    goto loop6;
                    	    }
                    	} while (true);

                    	loop6:
                    		;	// Stops C# compiler whining that label 'loop6' has no statements


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


    // $ANTLR start "declaration_stmt"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:52:1: declaration_stmt returns [Statement s] : ^( EQUALS ^(t= ID name= ID ) e= expr ) ;
    public Statement declaration_stmt() // throws RecognitionException [1]
    {   
        Statement s = default(Statement);

        CommonTree t = null;
        CommonTree name = null;
        Expression e = default(Expression);


        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:53:2: ( ^( EQUALS ^(t= ID name= ID ) e= expr ) )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:53:4: ^( EQUALS ^(t= ID name= ID ) e= expr )
            {
            	Match(input,EQUALS,FOLLOW_EQUALS_in_declaration_stmt318); 

            	Match(input, Token.DOWN, null); 
            	t=(CommonTree)Match(input,ID,FOLLOW_ID_in_declaration_stmt323); 

            	Match(input, Token.DOWN, null); 
            	name=(CommonTree)Match(input,ID,FOLLOW_ID_in_declaration_stmt327); 

            	Match(input, Token.UP, null); 
            	PushFollow(FOLLOW_expr_in_declaration_stmt332);
            	e = expr();
            	state.followingStackPointer--;

            	s =  TB.DeclarationStatement(((t != null) ? t.Text : null), ((name != null) ? name.Text : null), e); 

            	Match(input, Token.UP, null); 

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
    // $ANTLR end "declaration_stmt"


    // $ANTLR start "assignment_stmt"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:55:1: assignment_stmt returns [AssignmentStatement s] : ^( EQUALS name= ID e= expr ) ;
    public AssignmentStatement assignment_stmt() // throws RecognitionException [1]
    {   
        AssignmentStatement s = default(AssignmentStatement);

        CommonTree name = null;
        Expression e = default(Expression);


        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:56:2: ( ^( EQUALS name= ID e= expr ) )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:56:4: ^( EQUALS name= ID e= expr )
            {
            	Match(input,EQUALS,FOLLOW_EQUALS_in_assignment_stmt349); 

            	Match(input, Token.DOWN, null); 
            	name=(CommonTree)Match(input,ID,FOLLOW_ID_in_assignment_stmt353); 
            	PushFollow(FOLLOW_expr_in_assignment_stmt357);
            	e = expr();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	s =  TB.AssignmentStatement(((name != null) ? name.Text : null), e); 

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
    // $ANTLR end "assignment_stmt"


    // $ANTLR start "expr"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:58:1: expr returns [Expression e] : ( ^( '+' a= expr b= expr ) | ^( '-' a= expr b= expr ) | ^( '*' a= expr b= expr ) | ^( '/' a= expr b= expr ) | ^( '%' a= expr b= expr ) | ^( REL_OP a= expr b= expr ) | STRING_LITERAL | CHAR_LITERAL | INT | MINUS_OP INT | ID | BOOL_LITERAL | ^( CALL n= ID (p= expr )* ) );
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

        Expression p = default(Expression);


        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:59:5: ( ^( '+' a= expr b= expr ) | ^( '-' a= expr b= expr ) | ^( '*' a= expr b= expr ) | ^( '/' a= expr b= expr ) | ^( '%' a= expr b= expr ) | ^( REL_OP a= expr b= expr ) | STRING_LITERAL | CHAR_LITERAL | INT | MINUS_OP INT | ID | BOOL_LITERAL | ^( CALL n= ID (p= expr )* ) )
            int alt9 = 13;
            alt9 = dfa9.Predict(input);
            switch (alt9) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:59:9: ^( '+' a= expr b= expr )
                    {
                    	Match(input,ARITH_OP,FOLLOW_ARITH_OP_in_expr380); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr384);
                    	a = expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr388);
                    	b = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 e =  TB.AdditionExpression(a, b);

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:60:8: ^( '-' a= expr b= expr )
                    {
                    	Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_expr407); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr411);
                    	a = expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr415);
                    	b = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 e =  TB.SubtractionExpression(a, b);

                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:61:8: ^( '*' a= expr b= expr )
                    {
                    	Match(input,MULT_OP,FOLLOW_MULT_OP_in_expr434); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr438);
                    	a = expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr442);
                    	b = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 e =  TB.MultiplicationExpression(a, b); 

                    }
                    break;
                case 4 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:62:8: ^( '/' a= expr b= expr )
                    {
                    	Match(input,DIV_OP,FOLLOW_DIV_OP_in_expr461); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr465);
                    	a = expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr469);
                    	b = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 e =  TB.DivisionExpression(a, b); 

                    }
                    break;
                case 5 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:63:8: ^( '%' a= expr b= expr )
                    {
                    	Match(input,REM_OP,FOLLOW_REM_OP_in_expr488); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr492);
                    	a = expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr496);
                    	b = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 e =  TB.RemainderExpression(a, b);

                    }
                    break;
                case 6 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:64:7: ^( REL_OP a= expr b= expr )
                    {
                    	REL_OP1=(CommonTree)Match(input,REL_OP,FOLLOW_REL_OP_in_expr514); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expr_in_expr518);
                    	a = expr();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expr_in_expr522);
                    	b = expr();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 e =  TB.RelationalExpression(((REL_OP1 != null) ? REL_OP1.Text : null),a,b);

                    }
                    break;
                case 7 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:65:9: STRING_LITERAL
                    {
                    	STRING_LITERAL2=(CommonTree)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_expr538); 
                    	 e =  TB.StringExpression(((STRING_LITERAL2 != null) ? STRING_LITERAL2.Text : null));

                    }
                    break;
                case 8 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:66:7: CHAR_LITERAL
                    {
                    	CHAR_LITERAL3=(CommonTree)Match(input,CHAR_LITERAL,FOLLOW_CHAR_LITERAL_in_expr560); 
                    	 e =  TB.CharExpression(((CHAR_LITERAL3 != null) ? CHAR_LITERAL3.Text : null).Replace("'",""));

                    }
                    break;
                case 9 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:67:9: INT
                    {
                    	INT4=(CommonTree)Match(input,INT,FOLLOW_INT_in_expr576); 
                    	 e =  TB.IntegerExpression(((INT4 != null) ? INT4.Text : null));

                    }
                    break;
                case 10 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:68:9: MINUS_OP INT
                    {
                    	Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_expr611); 
                    	INT5=(CommonTree)Match(input,INT,FOLLOW_INT_in_expr613); 
                    	 e =  TB.IntegerExpression("-" + ((INT5 != null) ? INT5.Text : null));

                    }
                    break;
                case 11 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:69:7: ID
                    {
                    	ID6=(CommonTree)Match(input,ID,FOLLOW_ID_in_expr637); 
                    	 e =  TB.IdExpression(((ID6 != null) ? ID6.Text : null));

                    }
                    break;
                case 12 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:70:7: BOOL_LITERAL
                    {
                    	BOOL_LITERAL7=(CommonTree)Match(input,BOOL_LITERAL,FOLLOW_BOOL_LITERAL_in_expr652); 
                    	 e =  TB.BooleanExpression(((BOOL_LITERAL7 != null) ? BOOL_LITERAL7.Text : null));

                    }
                    break;
                case 13 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:71:7: ^( CALL n= ID (p= expr )* )
                    {
                    	Match(input,CALL,FOLLOW_CALL_in_expr667); 

                    	Match(input, Token.DOWN, null); 
                    	n=(CommonTree)Match(input,ID,FOLLOW_ID_in_expr671); 
                    	 e =  TB.MethodCall(((n != null) ? n.Text : null));
                    	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:71:51: (p= expr )*
                    	do 
                    	{
                    	    int alt8 = 2;
                    	    int LA8_0 = input.LA(1);

                    	    if ( (LA8_0 == CALL || LA8_0 == ID || (LA8_0 >= REL_OP && LA8_0 <= REM_OP)) )
                    	    {
                    	        alt8 = 1;
                    	    }


                    	    switch (alt8) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlatTree.g:71:52: p= expr
                    			    {
                    			    	PushFollow(FOLLOW_expr_in_expr678);
                    			    	p = expr();
                    			    	state.followingStackPointer--;

                    			    	((MethodCall)e).Parameters.Add(p);

                    			    }
                    			    break;

                    			default:
                    			    goto loop8;
                    	    }
                    	} while (true);

                    	loop8:
                    		;	// Stops C# compiler whining that label 'loop8' has no statements


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
        return e;
    }
    // $ANTLR end "expr"

    // Delegated rules


   	protected DFA7 dfa7;
   	protected DFA9 dfa9;
	private void InitializeCyclicDFAs()
	{
    	this.dfa7 = new DFA7(this);
    	this.dfa9 = new DFA9(this);


	}

    const string DFA7_eotS =
        "\x0b\uffff";
    const string DFA7_eofS =
        "\x0b\uffff";
    const string DFA7_minS =
        "\x01\x05\x01\uffff\x01\x02\x04\uffff\x01\x08\x01\x02\x02\uffff";
    const string DFA7_maxS =
        "\x01\x1a\x01\uffff\x01\x02\x04\uffff\x01\x08\x01\x1a\x02\uffff";
    const string DFA7_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x04\x01\x05\x01\x06\x01\x07\x02"+
        "\uffff\x01\x02\x01\x03";
    const string DFA7_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA7_transitionS = {
            "\x01\x01\x02\uffff\x01\x01\x01\uffff\x01\x03\x01\x04\x02\uffff"+
            "\x01\x05\x01\x06\x01\x02\x0a\x01",
            "",
            "\x01\x07",
            "",
            "",
            "",
            "",
            "\x01\x08",
            "\x01\x09\x02\uffff\x01\x0a\x02\uffff\x01\x0a\x08\uffff\x0a"+
            "\x0a",
            "",
            ""
    };

    static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
    static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
    static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
    static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
    static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
    static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
    static readonly short[][] DFA7_transition = DFA.UnpackEncodedStringArray(DFA7_transitionS);

    protected class DFA7 : DFA
    {
        public DFA7(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 7;
            this.eot = DFA7_eot;
            this.eof = DFA7_eof;
            this.min = DFA7_min;
            this.max = DFA7_max;
            this.accept = DFA7_accept;
            this.special = DFA7_special;
            this.transition = DFA7_transition;

        }

        override public string Description
        {
            get { return "32:1: stat returns [Statement s] : (e= expr | ds= declaration_stmt | as_stmt= assignment_stmt | ^( RETURN e= expr ) | ^( IF e= expr (st= stat )* ) | ^( WHILE e= expr (st= stat )* ) | ^( FOR ds= declaration_stmt e= expr as_stmt= assignment_stmt (st= stat )* ) );"; }
        }

    }

    const string DFA9_eotS =
        "\x0f\uffff";
    const string DFA9_eofS =
        "\x0f\uffff";
    const string DFA9_minS =
        "\x01\x05\x01\uffff\x01\x02\x0c\uffff";
    const string DFA9_maxS =
        "\x01\x1a\x01\uffff\x01\x13\x0c\uffff";
    const string DFA9_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x09\x01\x0b\x01\x0c\x01\x0d\x01\x02\x01\x0a";
    const string DFA9_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA9_transitionS = {
            "\x01\x0c\x02\uffff\x01\x0a\x08\uffff\x01\x06\x01\x02\x01\x09"+
            "\x01\x07\x01\x08\x01\x0b\x01\x01\x01\x03\x01\x04\x01\x05",
            "",
            "\x01\x0d\x10\uffff\x01\x0e",
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

    static readonly short[] DFA9_eot = DFA.UnpackEncodedString(DFA9_eotS);
    static readonly short[] DFA9_eof = DFA.UnpackEncodedString(DFA9_eofS);
    static readonly char[] DFA9_min = DFA.UnpackEncodedStringToUnsignedChars(DFA9_minS);
    static readonly char[] DFA9_max = DFA.UnpackEncodedStringToUnsignedChars(DFA9_maxS);
    static readonly short[] DFA9_accept = DFA.UnpackEncodedString(DFA9_acceptS);
    static readonly short[] DFA9_special = DFA.UnpackEncodedString(DFA9_specialS);
    static readonly short[][] DFA9_transition = DFA.UnpackEncodedStringArray(DFA9_transitionS);

    protected class DFA9 : DFA
    {
        public DFA9(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 9;
            this.eot = DFA9_eot;
            this.eof = DFA9_eof;
            this.min = DFA9_min;
            this.max = DFA9_max;
            this.accept = DFA9_accept;
            this.special = DFA9_special;
            this.transition = DFA9_transition;

        }

        override public string Description
        {
            get { return "58:1: expr returns [Expression e] : ( ^( '+' a= expr b= expr ) | ^( '-' a= expr b= expr ) | ^( '*' a= expr b= expr ) | ^( '/' a= expr b= expr ) | ^( '%' a= expr b= expr ) | ^( REL_OP a= expr b= expr ) | STRING_LITERAL | CHAR_LITERAL | INT | MINUS_OP INT | ID | BOOL_LITERAL | ^( CALL n= ID (p= expr )* ) );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_CLASS_in_prog66 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_prog70 = new BitSet(new ulong[]{0x0000000000000018UL});
    public static readonly BitSet FOLLOW_method_in_prog77 = new BitSet(new ulong[]{0x0000000000000018UL});
    public static readonly BitSet FOLLOW_METHOD_in_method99 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_method103 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ID_in_method107 = new BitSet(new ulong[]{0x0000000007FFCD68UL});
    public static readonly BitSet FOLLOW_param_in_method114 = new BitSet(new ulong[]{0x0000000007FFCD68UL});
    public static readonly BitSet FOLLOW_stat_in_method123 = new BitSet(new ulong[]{0x0000000007FFCD28UL});
    public static readonly BitSet FOLLOW_PARAM_in_param147 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_param151 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ID_in_param155 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_expr_in_stat173 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_declaration_stmt_in_stat183 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_stmt_in_stat193 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RETURN_in_stat202 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_stat206 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IF_in_stat216 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_stat220 = new BitSet(new ulong[]{0x0000000007FFCD28UL});
    public static readonly BitSet FOLLOW_stat_in_stat227 = new BitSet(new ulong[]{0x0000000007FFCD28UL});
    public static readonly BitSet FOLLOW_WHILE_in_stat240 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_stat244 = new BitSet(new ulong[]{0x0000000007FFCD28UL});
    public static readonly BitSet FOLLOW_stat_in_stat251 = new BitSet(new ulong[]{0x0000000007FFCD28UL});
    public static readonly BitSet FOLLOW_FOR_in_stat264 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_declaration_stmt_in_stat268 = new BitSet(new ulong[]{0x0000000007FE0120UL});
    public static readonly BitSet FOLLOW_expr_in_stat272 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_assignment_stmt_in_stat284 = new BitSet(new ulong[]{0x0000000007FFCD28UL});
    public static readonly BitSet FOLLOW_stat_in_stat293 = new BitSet(new ulong[]{0x0000000007FFCD28UL});
    public static readonly BitSet FOLLOW_EQUALS_in_declaration_stmt318 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_declaration_stmt323 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_declaration_stmt327 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_expr_in_declaration_stmt332 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_EQUALS_in_assignment_stmt349 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_assignment_stmt353 = new BitSet(new ulong[]{0x0000000007FE0120UL});
    public static readonly BitSet FOLLOW_expr_in_assignment_stmt357 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_ARITH_OP_in_expr380 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr384 = new BitSet(new ulong[]{0x0000000007FE0120UL});
    public static readonly BitSet FOLLOW_expr_in_expr388 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_expr407 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr411 = new BitSet(new ulong[]{0x0000000007FE0120UL});
    public static readonly BitSet FOLLOW_expr_in_expr415 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MULT_OP_in_expr434 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr438 = new BitSet(new ulong[]{0x0000000007FE0120UL});
    public static readonly BitSet FOLLOW_expr_in_expr442 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_DIV_OP_in_expr461 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr465 = new BitSet(new ulong[]{0x0000000007FE0120UL});
    public static readonly BitSet FOLLOW_expr_in_expr469 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_REM_OP_in_expr488 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr492 = new BitSet(new ulong[]{0x0000000007FE0120UL});
    public static readonly BitSet FOLLOW_expr_in_expr496 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_REL_OP_in_expr514 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expr_in_expr518 = new BitSet(new ulong[]{0x0000000007FE0120UL});
    public static readonly BitSet FOLLOW_expr_in_expr522 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_expr538 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_LITERAL_in_expr560 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_expr576 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_expr611 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_INT_in_expr613 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_expr637 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOL_LITERAL_in_expr652 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CALL_in_expr667 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_expr671 = new BitSet(new ulong[]{0x0000000007FE0128UL});
    public static readonly BitSet FOLLOW_expr_in_expr678 = new BitSet(new ulong[]{0x0000000007FE0128UL});

}
}