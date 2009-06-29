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

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;


using Antlr.Runtime.Tree;

public partial class CFlatParser : Parser
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
    public const int MULT_OP = 24;
    public const int CLASS = 7;
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
    public const int WS = 30;
    public const int STRING_LITERAL = 20;
    public const int T__33 = 33;
    public const int T__34 = 34;
    public const int CHAR_LITERAL = 21;
    public const int REL_OP = 17;
    public const int RBRAC = 13;
    public const int EOS = 9;
    public const int RETURN = 10;
    public const int MINUS_OP = 18;
    public const int CALL = 5;
    public const int METHOD = 4;
    public const int CALLOUT = 27;

    // delegates
    // delegators



        public CFlatParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public CFlatParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return CFlatParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g"; }
    }


    public class prog_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "prog"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:25:1: prog : 'public' CLASS ID '{' ( method )* '}' -> ^( CLASS ID ( method )* ) ;
    public CFlatParser.prog_return prog() // throws RecognitionException [1]
    {   
        CFlatParser.prog_return retval = new CFlatParser.prog_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal1 = null;
        IToken CLASS2 = null;
        IToken ID3 = null;
        IToken char_literal4 = null;
        IToken char_literal6 = null;
        CFlatParser.method_return method5 = default(CFlatParser.method_return);


        CommonTree string_literal1_tree=null;
        CommonTree CLASS2_tree=null;
        CommonTree ID3_tree=null;
        CommonTree char_literal4_tree=null;
        CommonTree char_literal6_tree=null;
        RewriteRuleTokenStream stream_CLASS = new RewriteRuleTokenStream(adaptor,"token CLASS");
        RewriteRuleTokenStream stream_32 = new RewriteRuleTokenStream(adaptor,"token 32");
        RewriteRuleTokenStream stream_31 = new RewriteRuleTokenStream(adaptor,"token 31");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_33 = new RewriteRuleTokenStream(adaptor,"token 33");
        RewriteRuleSubtreeStream stream_method = new RewriteRuleSubtreeStream(adaptor,"rule method");
        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:25:5: ( 'public' CLASS ID '{' ( method )* '}' -> ^( CLASS ID ( method )* ) )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:25:7: 'public' CLASS ID '{' ( method )* '}'
            {
            	string_literal1=(IToken)Match(input,31,FOLLOW_31_in_prog94); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_31.Add(string_literal1);

            	CLASS2=(IToken)Match(input,CLASS,FOLLOW_CLASS_in_prog96); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_CLASS.Add(CLASS2);

            	ID3=(IToken)Match(input,ID,FOLLOW_ID_in_prog98); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID3);

            	char_literal4=(IToken)Match(input,32,FOLLOW_32_in_prog100); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_32.Add(char_literal4);

            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:25:29: ( method )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == 31) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:0:0: method
            			    {
            			    	PushFollow(FOLLOW_method_in_prog102);
            			    	method5 = method();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_method.Add(method5.Tree);

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	char_literal6=(IToken)Match(input,33,FOLLOW_33_in_prog105); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_33.Add(char_literal6);



            	// AST REWRITE
            	// elements:          ID, method, CLASS
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 25:41: -> ^( CLASS ID ( method )* )
            	{
            	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:25:44: ^( CLASS ID ( method )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_CLASS.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_ID.NextNode());
            	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:25:55: ( method )*
            	    while ( stream_method.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_method.NextTree());

            	    }
            	    stream_method.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "prog"

    public class method_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "method"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:28:1: method : 'public' t= ID name= ID '(' ( param ( ',' param )* )? ')' '{' ( stat )* '}' -> ^( METHOD $t $name ( param )* ( stat )* ) ;
    public CFlatParser.method_return method() // throws RecognitionException [1]
    {   
        CFlatParser.method_return retval = new CFlatParser.method_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken t = null;
        IToken name = null;
        IToken string_literal7 = null;
        IToken char_literal8 = null;
        IToken char_literal10 = null;
        IToken char_literal12 = null;
        IToken char_literal13 = null;
        IToken char_literal15 = null;
        CFlatParser.param_return param9 = default(CFlatParser.param_return);

        CFlatParser.param_return param11 = default(CFlatParser.param_return);

        CFlatParser.stat_return stat14 = default(CFlatParser.stat_return);


        CommonTree t_tree=null;
        CommonTree name_tree=null;
        CommonTree string_literal7_tree=null;
        CommonTree char_literal8_tree=null;
        CommonTree char_literal10_tree=null;
        CommonTree char_literal12_tree=null;
        CommonTree char_literal13_tree=null;
        CommonTree char_literal15_tree=null;
        RewriteRuleTokenStream stream_32 = new RewriteRuleTokenStream(adaptor,"token 32");
        RewriteRuleTokenStream stream_31 = new RewriteRuleTokenStream(adaptor,"token 31");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_33 = new RewriteRuleTokenStream(adaptor,"token 33");
        RewriteRuleTokenStream stream_RBRAC = new RewriteRuleTokenStream(adaptor,"token RBRAC");
        RewriteRuleTokenStream stream_34 = new RewriteRuleTokenStream(adaptor,"token 34");
        RewriteRuleTokenStream stream_LBRAC = new RewriteRuleTokenStream(adaptor,"token LBRAC");
        RewriteRuleSubtreeStream stream_param = new RewriteRuleSubtreeStream(adaptor,"rule param");
        RewriteRuleSubtreeStream stream_stat = new RewriteRuleSubtreeStream(adaptor,"rule stat");
        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:28:8: ( 'public' t= ID name= ID '(' ( param ( ',' param )* )? ')' '{' ( stat )* '}' -> ^( METHOD $t $name ( param )* ( stat )* ) )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:28:10: 'public' t= ID name= ID '(' ( param ( ',' param )* )? ')' '{' ( stat )* '}'
            {
            	string_literal7=(IToken)Match(input,31,FOLLOW_31_in_method129); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_31.Add(string_literal7);

            	t=(IToken)Match(input,ID,FOLLOW_ID_in_method133); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(t);

            	name=(IToken)Match(input,ID,FOLLOW_ID_in_method137); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(name);

            	char_literal8=(IToken)Match(input,LBRAC,FOLLOW_LBRAC_in_method139); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LBRAC.Add(char_literal8);

            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:28:36: ( param ( ',' param )* )?
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == ID) )
            	{
            	    alt3 = 1;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:28:37: param ( ',' param )*
            	        {
            	        	PushFollow(FOLLOW_param_in_method142);
            	        	param9 = param();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_param.Add(param9.Tree);
            	        	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:28:43: ( ',' param )*
            	        	do 
            	        	{
            	        	    int alt2 = 2;
            	        	    int LA2_0 = input.LA(1);

            	        	    if ( (LA2_0 == 34) )
            	        	    {
            	        	        alt2 = 1;
            	        	    }


            	        	    switch (alt2) 
            	        		{
            	        			case 1 :
            	        			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:28:44: ',' param
            	        			    {
            	        			    	char_literal10=(IToken)Match(input,34,FOLLOW_34_in_method145); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_34.Add(char_literal10);

            	        			    	PushFollow(FOLLOW_param_in_method147);
            	        			    	param11 = param();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_param.Add(param11.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop2;
            	        	    }
            	        	} while (true);

            	        	loop2:
            	        		;	// Stops C# compiler whining that label 'loop2' has no statements


            	        }
            	        break;

            	}

            	char_literal12=(IToken)Match(input,RBRAC,FOLLOW_RBRAC_in_method153); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RBRAC.Add(char_literal12);

            	char_literal13=(IToken)Match(input,32,FOLLOW_32_in_method155); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_32.Add(char_literal13);

            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:28:66: ( stat )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == ID || (LA4_0 >= RETURN && LA4_0 <= LBRAC) || (LA4_0 >= WHILE && LA4_0 <= FOR) || (LA4_0 >= MINUS_OP && LA4_0 <= BOOL_LITERAL)) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:0:0: stat
            			    {
            			    	PushFollow(FOLLOW_stat_in_method157);
            			    	stat14 = stat();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_stat.Add(stat14.Tree);

            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements

            	char_literal15=(IToken)Match(input,33,FOLLOW_33_in_method160); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_33.Add(char_literal15);



            	// AST REWRITE
            	// elements:          stat, name, param, t
            	// token labels:      t, name
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleTokenStream stream_t = new RewriteRuleTokenStream(adaptor, "token t", t);
            	RewriteRuleTokenStream stream_name = new RewriteRuleTokenStream(adaptor, "token name", name);
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 28:76: -> ^( METHOD $t $name ( param )* ( stat )* )
            	{
            	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:28:79: ^( METHOD $t $name ( param )* ( stat )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(METHOD, "METHOD"), root_1);

            	    adaptor.AddChild(root_1, stream_t.NextNode());
            	    adaptor.AddChild(root_1, stream_name.NextNode());
            	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:28:97: ( param )*
            	    while ( stream_param.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_param.NextTree());

            	    }
            	    stream_param.Reset();
            	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:28:104: ( stat )*
            	    while ( stream_stat.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_stat.NextTree());

            	    }
            	    stream_stat.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "method"

    public class param_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "param"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:30:1: param : t= ID n= ID -> ^( PARAM $t $n) ;
    public CFlatParser.param_return param() // throws RecognitionException [1]
    {   
        CFlatParser.param_return retval = new CFlatParser.param_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken t = null;
        IToken n = null;

        CommonTree t_tree=null;
        CommonTree n_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:30:7: (t= ID n= ID -> ^( PARAM $t $n) )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:30:10: t= ID n= ID
            {
            	t=(IToken)Match(input,ID,FOLLOW_ID_in_param189); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(t);

            	n=(IToken)Match(input,ID,FOLLOW_ID_in_param193); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(n);



            	// AST REWRITE
            	// elements:          n, t
            	// token labels:      t, n
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleTokenStream stream_t = new RewriteRuleTokenStream(adaptor, "token t", t);
            	RewriteRuleTokenStream stream_n = new RewriteRuleTokenStream(adaptor, "token n", n);
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 30:20: -> ^( PARAM $t $n)
            	{
            	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:30:23: ^( PARAM $t $n)
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PARAM, "PARAM"), root_1);

            	    adaptor.AddChild(root_1, stream_t.NextNode());
            	    adaptor.AddChild(root_1, stream_n.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "param"

    public class stat_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "stat"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:32:1: stat : ( expr EOS -> expr | declaration_stmt EOS | assignment_stmt EOS | RETURN expr EOS -> ^( RETURN expr ) | IF LBRAC expr RBRAC '{' ( stat )* '}' -> ^( IF expr ( stat )* ) | WHILE LBRAC expr RBRAC '{' ( stat )* '}' -> ^( WHILE expr ( stat )* ) | FOR LBRAC declaration_stmt EOS expr EOS assignment_stmt RBRAC '{' ( stat )* '}' -> ^( FOR declaration_stmt expr assignment_stmt ( stat )* ) );
    public CFlatParser.stat_return stat() // throws RecognitionException [1]
    {   
        CFlatParser.stat_return retval = new CFlatParser.stat_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken EOS17 = null;
        IToken EOS19 = null;
        IToken EOS21 = null;
        IToken RETURN22 = null;
        IToken EOS24 = null;
        IToken IF25 = null;
        IToken LBRAC26 = null;
        IToken RBRAC28 = null;
        IToken char_literal29 = null;
        IToken char_literal31 = null;
        IToken WHILE32 = null;
        IToken LBRAC33 = null;
        IToken RBRAC35 = null;
        IToken char_literal36 = null;
        IToken char_literal38 = null;
        IToken FOR39 = null;
        IToken LBRAC40 = null;
        IToken EOS42 = null;
        IToken EOS44 = null;
        IToken RBRAC46 = null;
        IToken char_literal47 = null;
        IToken char_literal49 = null;
        CFlatParser.expr_return expr16 = default(CFlatParser.expr_return);

        CFlatParser.declaration_stmt_return declaration_stmt18 = default(CFlatParser.declaration_stmt_return);

        CFlatParser.assignment_stmt_return assignment_stmt20 = default(CFlatParser.assignment_stmt_return);

        CFlatParser.expr_return expr23 = default(CFlatParser.expr_return);

        CFlatParser.expr_return expr27 = default(CFlatParser.expr_return);

        CFlatParser.stat_return stat30 = default(CFlatParser.stat_return);

        CFlatParser.expr_return expr34 = default(CFlatParser.expr_return);

        CFlatParser.stat_return stat37 = default(CFlatParser.stat_return);

        CFlatParser.declaration_stmt_return declaration_stmt41 = default(CFlatParser.declaration_stmt_return);

        CFlatParser.expr_return expr43 = default(CFlatParser.expr_return);

        CFlatParser.assignment_stmt_return assignment_stmt45 = default(CFlatParser.assignment_stmt_return);

        CFlatParser.stat_return stat48 = default(CFlatParser.stat_return);


        CommonTree EOS17_tree=null;
        CommonTree EOS19_tree=null;
        CommonTree EOS21_tree=null;
        CommonTree RETURN22_tree=null;
        CommonTree EOS24_tree=null;
        CommonTree IF25_tree=null;
        CommonTree LBRAC26_tree=null;
        CommonTree RBRAC28_tree=null;
        CommonTree char_literal29_tree=null;
        CommonTree char_literal31_tree=null;
        CommonTree WHILE32_tree=null;
        CommonTree LBRAC33_tree=null;
        CommonTree RBRAC35_tree=null;
        CommonTree char_literal36_tree=null;
        CommonTree char_literal38_tree=null;
        CommonTree FOR39_tree=null;
        CommonTree LBRAC40_tree=null;
        CommonTree EOS42_tree=null;
        CommonTree EOS44_tree=null;
        CommonTree RBRAC46_tree=null;
        CommonTree char_literal47_tree=null;
        CommonTree char_literal49_tree=null;
        RewriteRuleTokenStream stream_FOR = new RewriteRuleTokenStream(adaptor,"token FOR");
        RewriteRuleTokenStream stream_32 = new RewriteRuleTokenStream(adaptor,"token 32");
        RewriteRuleTokenStream stream_WHILE = new RewriteRuleTokenStream(adaptor,"token WHILE");
        RewriteRuleTokenStream stream_33 = new RewriteRuleTokenStream(adaptor,"token 33");
        RewriteRuleTokenStream stream_RBRAC = new RewriteRuleTokenStream(adaptor,"token RBRAC");
        RewriteRuleTokenStream stream_LBRAC = new RewriteRuleTokenStream(adaptor,"token LBRAC");
        RewriteRuleTokenStream stream_IF = new RewriteRuleTokenStream(adaptor,"token IF");
        RewriteRuleTokenStream stream_RETURN = new RewriteRuleTokenStream(adaptor,"token RETURN");
        RewriteRuleTokenStream stream_EOS = new RewriteRuleTokenStream(adaptor,"token EOS");
        RewriteRuleSubtreeStream stream_declaration_stmt = new RewriteRuleSubtreeStream(adaptor,"rule declaration_stmt");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        RewriteRuleSubtreeStream stream_assignment_stmt = new RewriteRuleSubtreeStream(adaptor,"rule assignment_stmt");
        RewriteRuleSubtreeStream stream_stat = new RewriteRuleSubtreeStream(adaptor,"rule stat");
        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:32:5: ( expr EOS -> expr | declaration_stmt EOS | assignment_stmt EOS | RETURN expr EOS -> ^( RETURN expr ) | IF LBRAC expr RBRAC '{' ( stat )* '}' -> ^( IF expr ( stat )* ) | WHILE LBRAC expr RBRAC '{' ( stat )* '}' -> ^( WHILE expr ( stat )* ) | FOR LBRAC declaration_stmt EOS expr EOS assignment_stmt RBRAC '{' ( stat )* '}' -> ^( FOR declaration_stmt expr assignment_stmt ( stat )* ) )
            int alt8 = 7;
            switch ( input.LA(1) ) 
            {
            case LBRAC:
            case MINUS_OP:
            case INT:
            case STRING_LITERAL:
            case CHAR_LITERAL:
            case BOOL_LITERAL:
            	{
                alt8 = 1;
                }
                break;
            case ID:
            	{
                switch ( input.LA(2) ) 
                {
                case EOS:
                case LBRAC:
                case REL_OP:
                case MINUS_OP:
                case ARITH_OP:
                case MULT_OP:
                case DIV_OP:
                case REM_OP:
                	{
                    alt8 = 1;
                    }
                    break;
                case ID:
                	{
                    alt8 = 2;
                    }
                    break;
                case EQUALS:
                	{
                    alt8 = 3;
                    }
                    break;
                	default:
                	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                	    NoViableAltException nvae_d8s2 =
                	        new NoViableAltException("", 8, 2, input);

                	    throw nvae_d8s2;
                }

                }
                break;
            case RETURN:
            	{
                alt8 = 4;
                }
                break;
            case IF:
            	{
                alt8 = 5;
                }
                break;
            case WHILE:
            	{
                alt8 = 6;
                }
                break;
            case FOR:
            	{
                alt8 = 7;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d8s0 =
            	        new NoViableAltException("", 8, 0, input);

            	    throw nvae_d8s0;
            }

            switch (alt8) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:32:9: expr EOS
                    {
                    	PushFollow(FOLLOW_expr_in_stat215);
                    	expr16 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expr.Add(expr16.Tree);
                    	EOS17=(IToken)Match(input,EOS,FOLLOW_EOS_in_stat217); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_EOS.Add(EOS17);



                    	// AST REWRITE
                    	// elements:          expr
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 32:17: -> expr
                    	{
                    	    adaptor.AddChild(root_0, stream_expr.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:34:2: declaration_stmt EOS
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_declaration_stmt_in_stat226);
                    	declaration_stmt18 = declaration_stmt();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declaration_stmt18.Tree);
                    	EOS19=(IToken)Match(input,EOS,FOLLOW_EOS_in_stat228); if (state.failed) return retval;

                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:36:2: assignment_stmt EOS
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_assignment_stmt_in_stat235);
                    	assignment_stmt20 = assignment_stmt();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment_stmt20.Tree);
                    	EOS21=(IToken)Match(input,EOS,FOLLOW_EOS_in_stat237); if (state.failed) return retval;

                    }
                    break;
                case 4 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:38:2: RETURN expr EOS
                    {
                    	RETURN22=(IToken)Match(input,RETURN,FOLLOW_RETURN_in_stat244); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RETURN.Add(RETURN22);

                    	PushFollow(FOLLOW_expr_in_stat246);
                    	expr23 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expr.Add(expr23.Tree);
                    	EOS24=(IToken)Match(input,EOS,FOLLOW_EOS_in_stat248); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_EOS.Add(EOS24);



                    	// AST REWRITE
                    	// elements:          expr, RETURN
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 38:18: -> ^( RETURN expr )
                    	{
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:38:21: ^( RETURN expr )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_RETURN.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_expr.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 5 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:40:2: IF LBRAC expr RBRAC '{' ( stat )* '}'
                    {
                    	IF25=(IToken)Match(input,IF,FOLLOW_IF_in_stat262); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_IF.Add(IF25);

                    	LBRAC26=(IToken)Match(input,LBRAC,FOLLOW_LBRAC_in_stat264); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LBRAC.Add(LBRAC26);

                    	PushFollow(FOLLOW_expr_in_stat266);
                    	expr27 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expr.Add(expr27.Tree);
                    	RBRAC28=(IToken)Match(input,RBRAC,FOLLOW_RBRAC_in_stat268); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RBRAC.Add(RBRAC28);

                    	char_literal29=(IToken)Match(input,32,FOLLOW_32_in_stat270); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_32.Add(char_literal29);

                    	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:40:26: ( stat )*
                    	do 
                    	{
                    	    int alt5 = 2;
                    	    int LA5_0 = input.LA(1);

                    	    if ( (LA5_0 == ID || (LA5_0 >= RETURN && LA5_0 <= LBRAC) || (LA5_0 >= WHILE && LA5_0 <= FOR) || (LA5_0 >= MINUS_OP && LA5_0 <= BOOL_LITERAL)) )
                    	    {
                    	        alt5 = 1;
                    	    }


                    	    switch (alt5) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:0:0: stat
                    			    {
                    			    	PushFollow(FOLLOW_stat_in_stat272);
                    			    	stat30 = stat();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_stat.Add(stat30.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop5;
                    	    }
                    	} while (true);

                    	loop5:
                    		;	// Stops C# compiler whining that label 'loop5' has no statements

                    	char_literal31=(IToken)Match(input,33,FOLLOW_33_in_stat275); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_33.Add(char_literal31);



                    	// AST REWRITE
                    	// elements:          stat, expr, IF
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 40:36: -> ^( IF expr ( stat )* )
                    	{
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:40:39: ^( IF expr ( stat )* )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_IF.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_expr.NextTree());
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:40:49: ( stat )*
                    	    while ( stream_stat.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_stat.NextTree());

                    	    }
                    	    stream_stat.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 6 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:42:2: WHILE LBRAC expr RBRAC '{' ( stat )* '}'
                    {
                    	WHILE32=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_stat292); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_WHILE.Add(WHILE32);

                    	LBRAC33=(IToken)Match(input,LBRAC,FOLLOW_LBRAC_in_stat294); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LBRAC.Add(LBRAC33);

                    	PushFollow(FOLLOW_expr_in_stat296);
                    	expr34 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expr.Add(expr34.Tree);
                    	RBRAC35=(IToken)Match(input,RBRAC,FOLLOW_RBRAC_in_stat298); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RBRAC.Add(RBRAC35);

                    	char_literal36=(IToken)Match(input,32,FOLLOW_32_in_stat300); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_32.Add(char_literal36);

                    	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:42:29: ( stat )*
                    	do 
                    	{
                    	    int alt6 = 2;
                    	    int LA6_0 = input.LA(1);

                    	    if ( (LA6_0 == ID || (LA6_0 >= RETURN && LA6_0 <= LBRAC) || (LA6_0 >= WHILE && LA6_0 <= FOR) || (LA6_0 >= MINUS_OP && LA6_0 <= BOOL_LITERAL)) )
                    	    {
                    	        alt6 = 1;
                    	    }


                    	    switch (alt6) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:0:0: stat
                    			    {
                    			    	PushFollow(FOLLOW_stat_in_stat302);
                    			    	stat37 = stat();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_stat.Add(stat37.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop6;
                    	    }
                    	} while (true);

                    	loop6:
                    		;	// Stops C# compiler whining that label 'loop6' has no statements

                    	char_literal38=(IToken)Match(input,33,FOLLOW_33_in_stat305); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_33.Add(char_literal38);



                    	// AST REWRITE
                    	// elements:          expr, WHILE, stat
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 42:39: -> ^( WHILE expr ( stat )* )
                    	{
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:42:42: ^( WHILE expr ( stat )* )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_WHILE.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_expr.NextTree());
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:42:55: ( stat )*
                    	    while ( stream_stat.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_stat.NextTree());

                    	    }
                    	    stream_stat.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 7 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:44:2: FOR LBRAC declaration_stmt EOS expr EOS assignment_stmt RBRAC '{' ( stat )* '}'
                    {
                    	FOR39=(IToken)Match(input,FOR,FOLLOW_FOR_in_stat322); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_FOR.Add(FOR39);

                    	LBRAC40=(IToken)Match(input,LBRAC,FOLLOW_LBRAC_in_stat324); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LBRAC.Add(LBRAC40);

                    	PushFollow(FOLLOW_declaration_stmt_in_stat326);
                    	declaration_stmt41 = declaration_stmt();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_declaration_stmt.Add(declaration_stmt41.Tree);
                    	EOS42=(IToken)Match(input,EOS,FOLLOW_EOS_in_stat328); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_EOS.Add(EOS42);

                    	PushFollow(FOLLOW_expr_in_stat330);
                    	expr43 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expr.Add(expr43.Tree);
                    	EOS44=(IToken)Match(input,EOS,FOLLOW_EOS_in_stat332); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_EOS.Add(EOS44);

                    	PushFollow(FOLLOW_assignment_stmt_in_stat334);
                    	assignment_stmt45 = assignment_stmt();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_assignment_stmt.Add(assignment_stmt45.Tree);
                    	RBRAC46=(IToken)Match(input,RBRAC,FOLLOW_RBRAC_in_stat336); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RBRAC.Add(RBRAC46);

                    	char_literal47=(IToken)Match(input,32,FOLLOW_32_in_stat338); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_32.Add(char_literal47);

                    	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:44:68: ( stat )*
                    	do 
                    	{
                    	    int alt7 = 2;
                    	    int LA7_0 = input.LA(1);

                    	    if ( (LA7_0 == ID || (LA7_0 >= RETURN && LA7_0 <= LBRAC) || (LA7_0 >= WHILE && LA7_0 <= FOR) || (LA7_0 >= MINUS_OP && LA7_0 <= BOOL_LITERAL)) )
                    	    {
                    	        alt7 = 1;
                    	    }


                    	    switch (alt7) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:0:0: stat
                    			    {
                    			    	PushFollow(FOLLOW_stat_in_stat340);
                    			    	stat48 = stat();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_stat.Add(stat48.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop7;
                    	    }
                    	} while (true);

                    	loop7:
                    		;	// Stops C# compiler whining that label 'loop7' has no statements

                    	char_literal49=(IToken)Match(input,33,FOLLOW_33_in_stat343); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_33.Add(char_literal49);



                    	// AST REWRITE
                    	// elements:          stat, FOR, declaration_stmt, expr, assignment_stmt
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 45:3: -> ^( FOR declaration_stmt expr assignment_stmt ( stat )* )
                    	{
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:45:6: ^( FOR declaration_stmt expr assignment_stmt ( stat )* )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_FOR.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_declaration_stmt.NextTree());
                    	    adaptor.AddChild(root_1, stream_expr.NextTree());
                    	    adaptor.AddChild(root_1, stream_assignment_stmt.NextTree());
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:45:50: ( stat )*
                    	    while ( stream_stat.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_stat.NextTree());

                    	    }
                    	    stream_stat.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "stat"

    public class declaration_stmt_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "declaration_stmt"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:48:1: declaration_stmt : t= ID name= ID EQUALS expr -> ^( EQUALS ^( $t $name) expr ) ;
    public CFlatParser.declaration_stmt_return declaration_stmt() // throws RecognitionException [1]
    {   
        CFlatParser.declaration_stmt_return retval = new CFlatParser.declaration_stmt_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken t = null;
        IToken name = null;
        IToken EQUALS50 = null;
        CFlatParser.expr_return expr51 = default(CFlatParser.expr_return);


        CommonTree t_tree=null;
        CommonTree name_tree=null;
        CommonTree EQUALS50_tree=null;
        RewriteRuleTokenStream stream_EQUALS = new RewriteRuleTokenStream(adaptor,"token EQUALS");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:49:2: (t= ID name= ID EQUALS expr -> ^( EQUALS ^( $t $name) expr ) )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:49:4: t= ID name= ID EQUALS expr
            {
            	t=(IToken)Match(input,ID,FOLLOW_ID_in_declaration_stmt375); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(t);

            	name=(IToken)Match(input,ID,FOLLOW_ID_in_declaration_stmt379); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(name);

            	EQUALS50=(IToken)Match(input,EQUALS,FOLLOW_EQUALS_in_declaration_stmt381); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_EQUALS.Add(EQUALS50);

            	PushFollow(FOLLOW_expr_in_declaration_stmt383);
            	expr51 = expr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expr.Add(expr51.Tree);


            	// AST REWRITE
            	// elements:          name, t, expr, EQUALS
            	// token labels:      t, name
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleTokenStream stream_t = new RewriteRuleTokenStream(adaptor, "token t", t);
            	RewriteRuleTokenStream stream_name = new RewriteRuleTokenStream(adaptor, "token name", name);
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 49:29: -> ^( EQUALS ^( $t $name) expr )
            	{
            	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:49:32: ^( EQUALS ^( $t $name) expr )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_EQUALS.NextNode(), root_1);

            	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:49:41: ^( $t $name)
            	    {
            	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	    root_2 = (CommonTree)adaptor.BecomeRoot(stream_t.NextNode(), root_2);

            	    adaptor.AddChild(root_2, stream_name.NextNode());

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    adaptor.AddChild(root_1, stream_expr.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "declaration_stmt"

    public class assignment_stmt_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "assignment_stmt"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:51:1: assignment_stmt : name= ID EQUALS expr -> ^( EQUALS $name expr ) ;
    public CFlatParser.assignment_stmt_return assignment_stmt() // throws RecognitionException [1]
    {   
        CFlatParser.assignment_stmt_return retval = new CFlatParser.assignment_stmt_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken name = null;
        IToken EQUALS52 = null;
        CFlatParser.expr_return expr53 = default(CFlatParser.expr_return);


        CommonTree name_tree=null;
        CommonTree EQUALS52_tree=null;
        RewriteRuleTokenStream stream_EQUALS = new RewriteRuleTokenStream(adaptor,"token EQUALS");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:52:2: (name= ID EQUALS expr -> ^( EQUALS $name expr ) )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:52:4: name= ID EQUALS expr
            {
            	name=(IToken)Match(input,ID,FOLLOW_ID_in_assignment_stmt410); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(name);

            	EQUALS52=(IToken)Match(input,EQUALS,FOLLOW_EQUALS_in_assignment_stmt412); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_EQUALS.Add(EQUALS52);

            	PushFollow(FOLLOW_expr_in_assignment_stmt414);
            	expr53 = expr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expr.Add(expr53.Tree);


            	// AST REWRITE
            	// elements:          EQUALS, expr, name
            	// token labels:      name
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleTokenStream stream_name = new RewriteRuleTokenStream(adaptor, "token name", name);
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 52:24: -> ^( EQUALS $name expr )
            	{
            	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:52:27: ^( EQUALS $name expr )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_EQUALS.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_name.NextNode());
            	    adaptor.AddChild(root_1, stream_expr.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "assignment_stmt"

    public class expr_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "expr"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:54:1: expr : additive_expr ( REL_OP additive_expr )* ;
    public CFlatParser.expr_return expr() // throws RecognitionException [1]
    {   
        CFlatParser.expr_return retval = new CFlatParser.expr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken REL_OP55 = null;
        CFlatParser.additive_expr_return additive_expr54 = default(CFlatParser.additive_expr_return);

        CFlatParser.additive_expr_return additive_expr56 = default(CFlatParser.additive_expr_return);


        CommonTree REL_OP55_tree=null;

        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:54:6: ( additive_expr ( REL_OP additive_expr )* )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:54:8: additive_expr ( REL_OP additive_expr )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additive_expr_in_expr434);
            	additive_expr54 = additive_expr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additive_expr54.Tree);
            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:54:22: ( REL_OP additive_expr )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == REL_OP) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:54:23: REL_OP additive_expr
            			    {
            			    	REL_OP55=(IToken)Match(input,REL_OP,FOLLOW_REL_OP_in_expr437); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{REL_OP55_tree = (CommonTree)adaptor.Create(REL_OP55);
            			    		root_0 = (CommonTree)adaptor.BecomeRoot(REL_OP55_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_additive_expr_in_expr440);
            			    	additive_expr56 = additive_expr();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additive_expr56.Tree);

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expr"

    public class additive_expr_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "additive_expr"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:56:1: additive_expr : multExpr ( ( '+' | '-' ) multExpr )* ;
    public CFlatParser.additive_expr_return additive_expr() // throws RecognitionException [1]
    {   
        CFlatParser.additive_expr_return retval = new CFlatParser.additive_expr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal58 = null;
        IToken char_literal59 = null;
        CFlatParser.multExpr_return multExpr57 = default(CFlatParser.multExpr_return);

        CFlatParser.multExpr_return multExpr60 = default(CFlatParser.multExpr_return);


        CommonTree char_literal58_tree=null;
        CommonTree char_literal59_tree=null;

        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:56:14: ( multExpr ( ( '+' | '-' ) multExpr )* )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:56:18: multExpr ( ( '+' | '-' ) multExpr )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multExpr_in_additive_expr451);
            	multExpr57 = multExpr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multExpr57.Tree);
            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:57:1: ( ( '+' | '-' ) multExpr )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == MINUS_OP) )
            	    {
            	        int LA11_2 = input.LA(2);

            	        if ( (LA11_2 == INT) )
            	        {
            	            int LA11_4 = input.LA(3);

            	            if ( (synpred16_CFlat()) )
            	            {
            	                alt11 = 1;
            	            }


            	        }
            	        else if ( (LA11_2 == ID || LA11_2 == LBRAC || LA11_2 == MINUS_OP || (LA11_2 >= STRING_LITERAL && LA11_2 <= BOOL_LITERAL)) )
            	        {
            	            alt11 = 1;
            	        }


            	    }
            	    else if ( (LA11_0 == ARITH_OP) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:57:2: ( '+' | '-' ) multExpr
            			    {
            			    	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:57:2: ( '+' | '-' )
            			    	int alt10 = 2;
            			    	int LA10_0 = input.LA(1);

            			    	if ( (LA10_0 == ARITH_OP) )
            			    	{
            			    	    alt10 = 1;
            			    	}
            			    	else if ( (LA10_0 == MINUS_OP) )
            			    	{
            			    	    alt10 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    NoViableAltException nvae_d10s0 =
            			    	        new NoViableAltException("", 10, 0, input);

            			    	    throw nvae_d10s0;
            			    	}
            			    	switch (alt10) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:57:3: '+'
            			    	        {
            			    	        	char_literal58=(IToken)Match(input,ARITH_OP,FOLLOW_ARITH_OP_in_additive_expr456); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal58_tree = (CommonTree)adaptor.Create(char_literal58);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal58_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:57:8: '-'
            			    	        {
            			    	        	char_literal59=(IToken)Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_additive_expr459); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal59_tree = (CommonTree)adaptor.Create(char_literal59);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal59_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multExpr_in_additive_expr463);
            			    	multExpr60 = multExpr();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multExpr60.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "additive_expr"

    public class multExpr_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "multExpr"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:60:1: multExpr : atom ( ( '*' | '/' | '%' ) atom )* ;
    public CFlatParser.multExpr_return multExpr() // throws RecognitionException [1]
    {   
        CFlatParser.multExpr_return retval = new CFlatParser.multExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set62 = null;
        CFlatParser.atom_return atom61 = default(CFlatParser.atom_return);

        CFlatParser.atom_return atom63 = default(CFlatParser.atom_return);


        CommonTree set62_tree=null;

        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:61:5: ( atom ( ( '*' | '/' | '%' ) atom )* )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:61:9: atom ( ( '*' | '/' | '%' ) atom )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_atom_in_multExpr484);
            	atom61 = atom();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, atom61.Tree);
            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:61:14: ( ( '*' | '/' | '%' ) atom )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( ((LA12_0 >= MULT_OP && LA12_0 <= REM_OP)) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:61:15: ( '*' | '/' | '%' ) atom
            			    {
            			    	set62=(IToken)input.LT(1);
            			    	set62 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= MULT_OP && input.LA(1) <= REM_OP) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(set62), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_atom_in_multExpr496);
            			    	atom63 = atom();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, atom63.Tree);

            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "multExpr"

    public class atom_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "atom"
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:64:1: atom : ( MINUS_OP INT | INT | LBRAC expr RBRAC -> expr | STRING_LITERAL | CHAR_LITERAL | BOOL_LITERAL | ID '(' ( expr )* ')' -> ^( CALL ID ( expr )* ) | ID );
    public CFlatParser.atom_return atom() // throws RecognitionException [1]
    {   
        CFlatParser.atom_return retval = new CFlatParser.atom_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken MINUS_OP64 = null;
        IToken INT65 = null;
        IToken INT66 = null;
        IToken LBRAC67 = null;
        IToken RBRAC69 = null;
        IToken STRING_LITERAL70 = null;
        IToken CHAR_LITERAL71 = null;
        IToken BOOL_LITERAL72 = null;
        IToken ID73 = null;
        IToken char_literal74 = null;
        IToken char_literal76 = null;
        IToken ID77 = null;
        CFlatParser.expr_return expr68 = default(CFlatParser.expr_return);

        CFlatParser.expr_return expr75 = default(CFlatParser.expr_return);


        CommonTree MINUS_OP64_tree=null;
        CommonTree INT65_tree=null;
        CommonTree INT66_tree=null;
        CommonTree LBRAC67_tree=null;
        CommonTree RBRAC69_tree=null;
        CommonTree STRING_LITERAL70_tree=null;
        CommonTree CHAR_LITERAL71_tree=null;
        CommonTree BOOL_LITERAL72_tree=null;
        CommonTree ID73_tree=null;
        CommonTree char_literal74_tree=null;
        CommonTree char_literal76_tree=null;
        CommonTree ID77_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_RBRAC = new RewriteRuleTokenStream(adaptor,"token RBRAC");
        RewriteRuleTokenStream stream_LBRAC = new RewriteRuleTokenStream(adaptor,"token LBRAC");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:64:5: ( MINUS_OP INT | INT | LBRAC expr RBRAC -> expr | STRING_LITERAL | CHAR_LITERAL | BOOL_LITERAL | ID '(' ( expr )* ')' -> ^( CALL ID ( expr )* ) | ID )
            int alt14 = 8;
            alt14 = dfa14.Predict(input);
            switch (alt14) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:64:9: MINUS_OP INT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	MINUS_OP64=(IToken)Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_atom512); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{MINUS_OP64_tree = (CommonTree)adaptor.Create(MINUS_OP64);
                    		adaptor.AddChild(root_0, MINUS_OP64_tree);
                    	}
                    	INT65=(IToken)Match(input,INT,FOLLOW_INT_in_atom514); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{INT65_tree = (CommonTree)adaptor.Create(INT65);
                    		adaptor.AddChild(root_0, INT65_tree);
                    	}

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:66:2: INT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	INT66=(IToken)Match(input,INT,FOLLOW_INT_in_atom520); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{INT66_tree = (CommonTree)adaptor.Create(INT66);
                    		adaptor.AddChild(root_0, INT66_tree);
                    	}

                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:68:2: LBRAC expr RBRAC
                    {
                    	LBRAC67=(IToken)Match(input,LBRAC,FOLLOW_LBRAC_in_atom526); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LBRAC.Add(LBRAC67);

                    	PushFollow(FOLLOW_expr_in_atom528);
                    	expr68 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expr.Add(expr68.Tree);
                    	RBRAC69=(IToken)Match(input,RBRAC,FOLLOW_RBRAC_in_atom530); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RBRAC.Add(RBRAC69);



                    	// AST REWRITE
                    	// elements:          expr
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 68:19: -> expr
                    	{
                    	    adaptor.AddChild(root_0, stream_expr.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 4 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:70:2: STRING_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	STRING_LITERAL70=(IToken)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_atom540); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{STRING_LITERAL70_tree = (CommonTree)adaptor.Create(STRING_LITERAL70);
                    		adaptor.AddChild(root_0, STRING_LITERAL70_tree);
                    	}

                    }
                    break;
                case 5 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:72:2: CHAR_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	CHAR_LITERAL71=(IToken)Match(input,CHAR_LITERAL,FOLLOW_CHAR_LITERAL_in_atom546); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{CHAR_LITERAL71_tree = (CommonTree)adaptor.Create(CHAR_LITERAL71);
                    		adaptor.AddChild(root_0, CHAR_LITERAL71_tree);
                    	}

                    }
                    break;
                case 6 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:74:2: BOOL_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	BOOL_LITERAL72=(IToken)Match(input,BOOL_LITERAL,FOLLOW_BOOL_LITERAL_in_atom552); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{BOOL_LITERAL72_tree = (CommonTree)adaptor.Create(BOOL_LITERAL72);
                    		adaptor.AddChild(root_0, BOOL_LITERAL72_tree);
                    	}

                    }
                    break;
                case 7 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:76:2: ID '(' ( expr )* ')'
                    {
                    	ID73=(IToken)Match(input,ID,FOLLOW_ID_in_atom558); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_ID.Add(ID73);

                    	char_literal74=(IToken)Match(input,LBRAC,FOLLOW_LBRAC_in_atom560); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LBRAC.Add(char_literal74);

                    	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:76:9: ( expr )*
                    	do 
                    	{
                    	    int alt13 = 2;
                    	    int LA13_0 = input.LA(1);

                    	    if ( (LA13_0 == ID || LA13_0 == LBRAC || (LA13_0 >= MINUS_OP && LA13_0 <= BOOL_LITERAL)) )
                    	    {
                    	        alt13 = 1;
                    	    }


                    	    switch (alt13) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:0:0: expr
                    			    {
                    			    	PushFollow(FOLLOW_expr_in_atom562);
                    			    	expr75 = expr();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_expr.Add(expr75.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop13;
                    	    }
                    	} while (true);

                    	loop13:
                    		;	// Stops C# compiler whining that label 'loop13' has no statements

                    	char_literal76=(IToken)Match(input,RBRAC,FOLLOW_RBRAC_in_atom565); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RBRAC.Add(char_literal76);



                    	// AST REWRITE
                    	// elements:          ID, expr
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 76:19: -> ^( CALL ID ( expr )* )
                    	{
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:76:22: ^( CALL ID ( expr )* )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(CALL, "CALL"), root_1);

                    	    adaptor.AddChild(root_1, stream_ID.NextNode());
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:76:32: ( expr )*
                    	    while ( stream_expr.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_expr.NextTree());

                    	    }
                    	    stream_expr.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 8 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:78:2: ID
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	ID77=(IToken)Match(input,ID,FOLLOW_ID_in_atom582); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ID77_tree = (CommonTree)adaptor.Create(ID77);
                    		adaptor.AddChild(root_0, ID77_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "atom"

    // $ANTLR start "synpred16_CFlat"
    public void synpred16_CFlat_fragment() {
        // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:57:2: ( ( '+' | '-' ) multExpr )
        // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:57:2: ( '+' | '-' ) multExpr
        {
        	if ( input.LA(1) == MINUS_OP || input.LA(1) == ARITH_OP ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}

        	PushFollow(FOLLOW_multExpr_in_synpred16_CFlat463);
        	multExpr();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred16_CFlat"

    // $ANTLR start "synpred27_CFlat"
    public void synpred27_CFlat_fragment() {
        // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:76:2: ( ID '(' ( expr )* ')' )
        // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:76:2: ID '(' ( expr )* ')'
        {
        	Match(input,ID,FOLLOW_ID_in_synpred27_CFlat558); if (state.failed) return ;
        	Match(input,LBRAC,FOLLOW_LBRAC_in_synpred27_CFlat560); if (state.failed) return ;
        	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:76:9: ( expr )*
        	do 
        	{
        	    int alt18 = 2;
        	    int LA18_0 = input.LA(1);

        	    if ( (LA18_0 == ID || LA18_0 == LBRAC || (LA18_0 >= MINUS_OP && LA18_0 <= BOOL_LITERAL)) )
        	    {
        	        alt18 = 1;
        	    }


        	    switch (alt18) 
        		{
        			case 1 :
        			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:0:0: expr
        			    {
        			    	PushFollow(FOLLOW_expr_in_synpred27_CFlat562);
        			    	expr();
        			    	state.followingStackPointer--;
        			    	if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    goto loop18;
        	    }
        	} while (true);

        	loop18:
        		;	// Stops C# compiler whining that label 'loop18' has no statements

        	Match(input,RBRAC,FOLLOW_RBRAC_in_synpred27_CFlat565); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred27_CFlat"

    // Delegated rules

   	public bool synpred27_CFlat() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred27_CFlat_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred16_CFlat() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred16_CFlat_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


   	protected DFA14 dfa14;
	private void InitializeCyclicDFAs()
	{
    	this.dfa14 = new DFA14(this);
	    this.dfa14.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA14_SpecialStateTransition);
	}

    const string DFA14_eotS =
        "\x0a\uffff";
    const string DFA14_eofS =
        "\x0a\uffff";
    const string DFA14_minS =
        "\x01\x08\x06\uffff\x01\x00\x02\uffff";
    const string DFA14_maxS =
        "\x01\x16\x06\uffff\x01\x00\x02\uffff";
    const string DFA14_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\uffff\x01\x07\x01\x08";
    const string DFA14_specialS =
        "\x07\uffff\x01\x00\x02\uffff}>";
    static readonly string[] DFA14_transitionS = {
            "\x01\x07\x03\uffff\x01\x03\x05\uffff\x01\x01\x01\x02\x01\x04"+
            "\x01\x05\x01\x06",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\uffff",
            "",
            ""
    };

    static readonly short[] DFA14_eot = DFA.UnpackEncodedString(DFA14_eotS);
    static readonly short[] DFA14_eof = DFA.UnpackEncodedString(DFA14_eofS);
    static readonly char[] DFA14_min = DFA.UnpackEncodedStringToUnsignedChars(DFA14_minS);
    static readonly char[] DFA14_max = DFA.UnpackEncodedStringToUnsignedChars(DFA14_maxS);
    static readonly short[] DFA14_accept = DFA.UnpackEncodedString(DFA14_acceptS);
    static readonly short[] DFA14_special = DFA.UnpackEncodedString(DFA14_specialS);
    static readonly short[][] DFA14_transition = DFA.UnpackEncodedStringArray(DFA14_transitionS);

    protected class DFA14 : DFA
    {
        public DFA14(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 14;
            this.eot = DFA14_eot;
            this.eof = DFA14_eof;
            this.min = DFA14_min;
            this.max = DFA14_max;
            this.accept = DFA14_accept;
            this.special = DFA14_special;
            this.transition = DFA14_transition;

        }

        override public string Description
        {
            get { return "64:1: atom : ( MINUS_OP INT | INT | LBRAC expr RBRAC -> expr | STRING_LITERAL | CHAR_LITERAL | BOOL_LITERAL | ID '(' ( expr )* ')' -> ^( CALL ID ( expr )* ) | ID );"; }
        }

    }


    protected internal int DFA14_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA14_7 = input.LA(1);

                   	 
                   	int index14_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred27_CFlat()) ) { s = 8; }

                   	else if ( (true) ) { s = 9; }

                   	 
                   	input.Seek(index14_7);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae14 =
            new NoViableAltException(dfa.Description, 14, _s, input);
        dfa.Error(nvae14);
        throw nvae14;
    }
 

    public static readonly BitSet FOLLOW_31_in_prog94 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_CLASS_in_prog96 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ID_in_prog98 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_prog100 = new BitSet(new ulong[]{0x0000000280000000UL});
    public static readonly BitSet FOLLOW_method_in_prog102 = new BitSet(new ulong[]{0x0000000280000000UL});
    public static readonly BitSet FOLLOW_33_in_prog105 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_31_in_method129 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ID_in_method133 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ID_in_method137 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_LBRAC_in_method139 = new BitSet(new ulong[]{0x0000000000002100UL});
    public static readonly BitSet FOLLOW_param_in_method142 = new BitSet(new ulong[]{0x0000000400002000UL});
    public static readonly BitSet FOLLOW_34_in_method145 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_param_in_method147 = new BitSet(new ulong[]{0x0000000400002000UL});
    public static readonly BitSet FOLLOW_RBRAC_in_method153 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_method155 = new BitSet(new ulong[]{0x00000002007CDD00UL});
    public static readonly BitSet FOLLOW_stat_in_method157 = new BitSet(new ulong[]{0x00000002007CDD00UL});
    public static readonly BitSet FOLLOW_33_in_method160 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_param189 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ID_in_param193 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_stat215 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_EOS_in_stat217 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_declaration_stmt_in_stat226 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_EOS_in_stat228 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_stmt_in_stat235 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_EOS_in_stat237 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RETURN_in_stat244 = new BitSet(new ulong[]{0x00000000007C1100UL});
    public static readonly BitSet FOLLOW_expr_in_stat246 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_EOS_in_stat248 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_stat262 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_LBRAC_in_stat264 = new BitSet(new ulong[]{0x00000000007C1100UL});
    public static readonly BitSet FOLLOW_expr_in_stat266 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RBRAC_in_stat268 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_stat270 = new BitSet(new ulong[]{0x00000002007CDD00UL});
    public static readonly BitSet FOLLOW_stat_in_stat272 = new BitSet(new ulong[]{0x00000002007CDD00UL});
    public static readonly BitSet FOLLOW_33_in_stat275 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHILE_in_stat292 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_LBRAC_in_stat294 = new BitSet(new ulong[]{0x00000000007C1100UL});
    public static readonly BitSet FOLLOW_expr_in_stat296 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RBRAC_in_stat298 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_stat300 = new BitSet(new ulong[]{0x00000002007CDD00UL});
    public static readonly BitSet FOLLOW_stat_in_stat302 = new BitSet(new ulong[]{0x00000002007CDD00UL});
    public static readonly BitSet FOLLOW_33_in_stat305 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_stat322 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_LBRAC_in_stat324 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_declaration_stmt_in_stat326 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_EOS_in_stat328 = new BitSet(new ulong[]{0x00000000007C1100UL});
    public static readonly BitSet FOLLOW_expr_in_stat330 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_EOS_in_stat332 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_assignment_stmt_in_stat334 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RBRAC_in_stat336 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_stat338 = new BitSet(new ulong[]{0x00000002007CDD00UL});
    public static readonly BitSet FOLLOW_stat_in_stat340 = new BitSet(new ulong[]{0x00000002007CDD00UL});
    public static readonly BitSet FOLLOW_33_in_stat343 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_declaration_stmt375 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ID_in_declaration_stmt379 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_EQUALS_in_declaration_stmt381 = new BitSet(new ulong[]{0x00000000007C1100UL});
    public static readonly BitSet FOLLOW_expr_in_declaration_stmt383 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_assignment_stmt410 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_EQUALS_in_assignment_stmt412 = new BitSet(new ulong[]{0x00000000007C1100UL});
    public static readonly BitSet FOLLOW_expr_in_assignment_stmt414 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additive_expr_in_expr434 = new BitSet(new ulong[]{0x0000000000020002UL});
    public static readonly BitSet FOLLOW_REL_OP_in_expr437 = new BitSet(new ulong[]{0x00000000007C1100UL});
    public static readonly BitSet FOLLOW_additive_expr_in_expr440 = new BitSet(new ulong[]{0x0000000000020002UL});
    public static readonly BitSet FOLLOW_multExpr_in_additive_expr451 = new BitSet(new ulong[]{0x0000000000840002UL});
    public static readonly BitSet FOLLOW_ARITH_OP_in_additive_expr456 = new BitSet(new ulong[]{0x00000000007C1100UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_additive_expr459 = new BitSet(new ulong[]{0x00000000007C1100UL});
    public static readonly BitSet FOLLOW_multExpr_in_additive_expr463 = new BitSet(new ulong[]{0x0000000000840002UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr484 = new BitSet(new ulong[]{0x0000000007000002UL});
    public static readonly BitSet FOLLOW_set_in_multExpr487 = new BitSet(new ulong[]{0x00000000007C1100UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr496 = new BitSet(new ulong[]{0x0000000007000002UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_atom512 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_INT_in_atom514 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_atom520 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRAC_in_atom526 = new BitSet(new ulong[]{0x00000000007C1100UL});
    public static readonly BitSet FOLLOW_expr_in_atom528 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RBRAC_in_atom530 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_atom540 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_LITERAL_in_atom546 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOL_LITERAL_in_atom552 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_atom558 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_LBRAC_in_atom560 = new BitSet(new ulong[]{0x00000000007C3100UL});
    public static readonly BitSet FOLLOW_expr_in_atom562 = new BitSet(new ulong[]{0x00000000007C3100UL});
    public static readonly BitSet FOLLOW_RBRAC_in_atom565 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_atom582 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_synpred16_CFlat455 = new BitSet(new ulong[]{0x00000000007C1100UL});
    public static readonly BitSet FOLLOW_multExpr_in_synpred16_CFlat463 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_synpred27_CFlat558 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_LBRAC_in_synpred27_CFlat560 = new BitSet(new ulong[]{0x00000000007C3100UL});
    public static readonly BitSet FOLLOW_expr_in_synpred27_CFlat562 = new BitSet(new ulong[]{0x00000000007C3100UL});
    public static readonly BitSet FOLLOW_RBRAC_in_synpred27_CFlat565 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}