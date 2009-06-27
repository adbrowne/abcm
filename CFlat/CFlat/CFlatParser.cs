// $ANTLR 3.1.2 C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g 2009-06-27 03:01:19

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
		"','", 
		"'()'"
    };

    public const int ALPHA_NUM = 28;
    public const int MULT_OP = 23;
    public const int CLASS = 7;
    public const int WHILE = 15;
    public const int DIV_OP = 24;
    public const int ARITH_OP = 22;
    public const int REM_OP = 25;
    public const int PARAM = 6;
    public const int INT = 18;
    public const int EQUALS = 10;
    public const int BOOL_LITERAL = 21;
    public const int ID = 8;
    public const int EOF = -1;
    public const int LBRAC = 13;
    public const int ALPHA = 27;
    public const int IF = 12;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int WS = 29;
    public const int STRING_LITERAL = 19;
    public const int T__33 = 33;
    public const int T__34 = 34;
    public const int CHAR_LITERAL = 20;
    public const int REL_OP = 16;
    public const int RBRAC = 14;
    public const int EOS = 9;
    public const int RETURN = 11;
    public const int MINUS_OP = 17;
    public const int CALL = 5;
    public const int METHOD = 4;
    public const int CALLOUT = 26;

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
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:24:1: prog : 'public' CLASS ID '{' ( method )* '}' -> ^( CLASS ID ( method )* ) ;
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
        RewriteRuleTokenStream stream_30 = new RewriteRuleTokenStream(adaptor,"token 30");
        RewriteRuleTokenStream stream_32 = new RewriteRuleTokenStream(adaptor,"token 32");
        RewriteRuleTokenStream stream_31 = new RewriteRuleTokenStream(adaptor,"token 31");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleSubtreeStream stream_method = new RewriteRuleSubtreeStream(adaptor,"rule method");
        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:24:5: ( 'public' CLASS ID '{' ( method )* '}' -> ^( CLASS ID ( method )* ) )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:24:7: 'public' CLASS ID '{' ( method )* '}'
            {
            	string_literal1=(IToken)Match(input,30,FOLLOW_30_in_prog85);  
            	stream_30.Add(string_literal1);

            	CLASS2=(IToken)Match(input,CLASS,FOLLOW_CLASS_in_prog87);  
            	stream_CLASS.Add(CLASS2);

            	ID3=(IToken)Match(input,ID,FOLLOW_ID_in_prog89);  
            	stream_ID.Add(ID3);

            	char_literal4=(IToken)Match(input,31,FOLLOW_31_in_prog91);  
            	stream_31.Add(char_literal4);

            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:24:29: ( method )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == 30) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:24:29: method
            			    {
            			    	PushFollow(FOLLOW_method_in_prog93);
            			    	method5 = method();
            			    	state.followingStackPointer--;

            			    	stream_method.Add(method5.Tree);

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	char_literal6=(IToken)Match(input,32,FOLLOW_32_in_prog96);  
            	stream_32.Add(char_literal6);



            	// AST REWRITE
            	// elements:          CLASS, method, ID
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 24:41: -> ^( CLASS ID ( method )* )
            	{
            	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:24:44: ^( CLASS ID ( method )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_CLASS.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_ID.NextNode());
            	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:24:55: ( method )*
            	    while ( stream_method.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_method.NextTree());

            	    }
            	    stream_method.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
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
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:27:1: method : 'public' t= ID name= ID '(' param ( ',' param )* ')' '{' ( stat )* '}' -> ^( METHOD $t $name ( param )* ( stat )* ) ;
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
        RewriteRuleTokenStream stream_30 = new RewriteRuleTokenStream(adaptor,"token 30");
        RewriteRuleTokenStream stream_32 = new RewriteRuleTokenStream(adaptor,"token 32");
        RewriteRuleTokenStream stream_31 = new RewriteRuleTokenStream(adaptor,"token 31");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_33 = new RewriteRuleTokenStream(adaptor,"token 33");
        RewriteRuleTokenStream stream_RBRAC = new RewriteRuleTokenStream(adaptor,"token RBRAC");
        RewriteRuleTokenStream stream_LBRAC = new RewriteRuleTokenStream(adaptor,"token LBRAC");
        RewriteRuleSubtreeStream stream_param = new RewriteRuleSubtreeStream(adaptor,"rule param");
        RewriteRuleSubtreeStream stream_stat = new RewriteRuleSubtreeStream(adaptor,"rule stat");
        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:27:8: ( 'public' t= ID name= ID '(' param ( ',' param )* ')' '{' ( stat )* '}' -> ^( METHOD $t $name ( param )* ( stat )* ) )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:27:10: 'public' t= ID name= ID '(' param ( ',' param )* ')' '{' ( stat )* '}'
            {
            	string_literal7=(IToken)Match(input,30,FOLLOW_30_in_method120);  
            	stream_30.Add(string_literal7);

            	t=(IToken)Match(input,ID,FOLLOW_ID_in_method124);  
            	stream_ID.Add(t);

            	name=(IToken)Match(input,ID,FOLLOW_ID_in_method128);  
            	stream_ID.Add(name);

            	char_literal8=(IToken)Match(input,LBRAC,FOLLOW_LBRAC_in_method130);  
            	stream_LBRAC.Add(char_literal8);

            	PushFollow(FOLLOW_param_in_method132);
            	param9 = param();
            	state.followingStackPointer--;

            	stream_param.Add(param9.Tree);
            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:27:42: ( ',' param )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == 33) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:27:43: ',' param
            			    {
            			    	char_literal10=(IToken)Match(input,33,FOLLOW_33_in_method135);  
            			    	stream_33.Add(char_literal10);

            			    	PushFollow(FOLLOW_param_in_method137);
            			    	param11 = param();
            			    	state.followingStackPointer--;

            			    	stream_param.Add(param11.Tree);

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements

            	char_literal12=(IToken)Match(input,RBRAC,FOLLOW_RBRAC_in_method141);  
            	stream_RBRAC.Add(char_literal12);

            	char_literal13=(IToken)Match(input,31,FOLLOW_31_in_method143);  
            	stream_31.Add(char_literal13);

            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:27:63: ( stat )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == ID || (LA3_0 >= RETURN && LA3_0 <= LBRAC) || LA3_0 == WHILE || (LA3_0 >= MINUS_OP && LA3_0 <= BOOL_LITERAL)) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:27:63: stat
            			    {
            			    	PushFollow(FOLLOW_stat_in_method145);
            			    	stat14 = stat();
            			    	state.followingStackPointer--;

            			    	stream_stat.Add(stat14.Tree);

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	char_literal15=(IToken)Match(input,32,FOLLOW_32_in_method148);  
            	stream_32.Add(char_literal15);



            	// AST REWRITE
            	// elements:          param, name, stat, t
            	// token labels:      t, name
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleTokenStream stream_t = new RewriteRuleTokenStream(adaptor, "token t", t);
            	RewriteRuleTokenStream stream_name = new RewriteRuleTokenStream(adaptor, "token name", name);
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 27:73: -> ^( METHOD $t $name ( param )* ( stat )* )
            	{
            	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:27:76: ^( METHOD $t $name ( param )* ( stat )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(METHOD, "METHOD"), root_1);

            	    adaptor.AddChild(root_1, stream_t.NextNode());
            	    adaptor.AddChild(root_1, stream_name.NextNode());
            	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:27:94: ( param )*
            	    while ( stream_param.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_param.NextTree());

            	    }
            	    stream_param.Reset();
            	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:27:101: ( stat )*
            	    while ( stream_stat.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_stat.NextTree());

            	    }
            	    stream_stat.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
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
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:29:1: param : t= ID n= ID -> ^( PARAM $t $n) ;
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
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:29:7: (t= ID n= ID -> ^( PARAM $t $n) )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:29:10: t= ID n= ID
            {
            	t=(IToken)Match(input,ID,FOLLOW_ID_in_param177);  
            	stream_ID.Add(t);

            	n=(IToken)Match(input,ID,FOLLOW_ID_in_param181);  
            	stream_ID.Add(n);



            	// AST REWRITE
            	// elements:          n, t
            	// token labels:      t, n
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleTokenStream stream_t = new RewriteRuleTokenStream(adaptor, "token t", t);
            	RewriteRuleTokenStream stream_n = new RewriteRuleTokenStream(adaptor, "token n", n);
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 29:20: -> ^( PARAM $t $n)
            	{
            	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:29:23: ^( PARAM $t $n)
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PARAM, "PARAM"), root_1);

            	    adaptor.AddChild(root_1, stream_t.NextNode());
            	    adaptor.AddChild(root_1, stream_n.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
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
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:31:1: stat : ( expr EOS -> expr | t= ID name= ID EQUALS expr EOS -> ^( EQUALS ^( $t $name) expr ) | name= ID EQUALS expr EOS -> ^( EQUALS $name expr ) | RETURN expr EOS -> ^( RETURN expr ) | IF LBRAC expr RBRAC '{' ( stat )* '}' -> ^( IF expr ( stat )* ) | WHILE LBRAC expr RBRAC '{' ( stat )* '}' -> ^( WHILE expr ( stat )* ) );
    public CFlatParser.stat_return stat() // throws RecognitionException [1]
    {   
        CFlatParser.stat_return retval = new CFlatParser.stat_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken t = null;
        IToken name = null;
        IToken EOS17 = null;
        IToken EQUALS18 = null;
        IToken EOS20 = null;
        IToken EQUALS21 = null;
        IToken EOS23 = null;
        IToken RETURN24 = null;
        IToken EOS26 = null;
        IToken IF27 = null;
        IToken LBRAC28 = null;
        IToken RBRAC30 = null;
        IToken char_literal31 = null;
        IToken char_literal33 = null;
        IToken WHILE34 = null;
        IToken LBRAC35 = null;
        IToken RBRAC37 = null;
        IToken char_literal38 = null;
        IToken char_literal40 = null;
        CFlatParser.expr_return expr16 = default(CFlatParser.expr_return);

        CFlatParser.expr_return expr19 = default(CFlatParser.expr_return);

        CFlatParser.expr_return expr22 = default(CFlatParser.expr_return);

        CFlatParser.expr_return expr25 = default(CFlatParser.expr_return);

        CFlatParser.expr_return expr29 = default(CFlatParser.expr_return);

        CFlatParser.stat_return stat32 = default(CFlatParser.stat_return);

        CFlatParser.expr_return expr36 = default(CFlatParser.expr_return);

        CFlatParser.stat_return stat39 = default(CFlatParser.stat_return);


        CommonTree t_tree=null;
        CommonTree name_tree=null;
        CommonTree EOS17_tree=null;
        CommonTree EQUALS18_tree=null;
        CommonTree EOS20_tree=null;
        CommonTree EQUALS21_tree=null;
        CommonTree EOS23_tree=null;
        CommonTree RETURN24_tree=null;
        CommonTree EOS26_tree=null;
        CommonTree IF27_tree=null;
        CommonTree LBRAC28_tree=null;
        CommonTree RBRAC30_tree=null;
        CommonTree char_literal31_tree=null;
        CommonTree char_literal33_tree=null;
        CommonTree WHILE34_tree=null;
        CommonTree LBRAC35_tree=null;
        CommonTree RBRAC37_tree=null;
        CommonTree char_literal38_tree=null;
        CommonTree char_literal40_tree=null;
        RewriteRuleTokenStream stream_EQUALS = new RewriteRuleTokenStream(adaptor,"token EQUALS");
        RewriteRuleTokenStream stream_32 = new RewriteRuleTokenStream(adaptor,"token 32");
        RewriteRuleTokenStream stream_WHILE = new RewriteRuleTokenStream(adaptor,"token WHILE");
        RewriteRuleTokenStream stream_31 = new RewriteRuleTokenStream(adaptor,"token 31");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_RBRAC = new RewriteRuleTokenStream(adaptor,"token RBRAC");
        RewriteRuleTokenStream stream_LBRAC = new RewriteRuleTokenStream(adaptor,"token LBRAC");
        RewriteRuleTokenStream stream_IF = new RewriteRuleTokenStream(adaptor,"token IF");
        RewriteRuleTokenStream stream_RETURN = new RewriteRuleTokenStream(adaptor,"token RETURN");
        RewriteRuleTokenStream stream_EOS = new RewriteRuleTokenStream(adaptor,"token EOS");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        RewriteRuleSubtreeStream stream_stat = new RewriteRuleSubtreeStream(adaptor,"rule stat");
        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:31:5: ( expr EOS -> expr | t= ID name= ID EQUALS expr EOS -> ^( EQUALS ^( $t $name) expr ) | name= ID EQUALS expr EOS -> ^( EQUALS $name expr ) | RETURN expr EOS -> ^( RETURN expr ) | IF LBRAC expr RBRAC '{' ( stat )* '}' -> ^( IF expr ( stat )* ) | WHILE LBRAC expr RBRAC '{' ( stat )* '}' -> ^( WHILE expr ( stat )* ) )
            int alt6 = 6;
            switch ( input.LA(1) ) 
            {
            case LBRAC:
            case MINUS_OP:
            case INT:
            case STRING_LITERAL:
            case CHAR_LITERAL:
            case BOOL_LITERAL:
            	{
                alt6 = 1;
                }
                break;
            case ID:
            	{
                switch ( input.LA(2) ) 
                {
                case EOS:
                case REL_OP:
                case MINUS_OP:
                case ARITH_OP:
                case MULT_OP:
                case DIV_OP:
                case REM_OP:
                case 34:
                	{
                    alt6 = 1;
                    }
                    break;
                case ID:
                	{
                    alt6 = 2;
                    }
                    break;
                case EQUALS:
                	{
                    alt6 = 3;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d6s2 =
                	        new NoViableAltException("", 6, 2, input);

                	    throw nvae_d6s2;
                }

                }
                break;
            case RETURN:
            	{
                alt6 = 4;
                }
                break;
            case IF:
            	{
                alt6 = 5;
                }
                break;
            case WHILE:
            	{
                alt6 = 6;
                }
                break;
            	default:
            	    NoViableAltException nvae_d6s0 =
            	        new NoViableAltException("", 6, 0, input);

            	    throw nvae_d6s0;
            }

            switch (alt6) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:31:9: expr EOS
                    {
                    	PushFollow(FOLLOW_expr_in_stat203);
                    	expr16 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr16.Tree);
                    	EOS17=(IToken)Match(input,EOS,FOLLOW_EOS_in_stat205);  
                    	stream_EOS.Add(EOS17);



                    	// AST REWRITE
                    	// elements:          expr
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 31:17: -> expr
                    	{
                    	    adaptor.AddChild(root_0, stream_expr.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:33:2: t= ID name= ID EQUALS expr EOS
                    {
                    	t=(IToken)Match(input,ID,FOLLOW_ID_in_stat216);  
                    	stream_ID.Add(t);

                    	name=(IToken)Match(input,ID,FOLLOW_ID_in_stat220);  
                    	stream_ID.Add(name);

                    	EQUALS18=(IToken)Match(input,EQUALS,FOLLOW_EQUALS_in_stat222);  
                    	stream_EQUALS.Add(EQUALS18);

                    	PushFollow(FOLLOW_expr_in_stat224);
                    	expr19 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr19.Tree);
                    	EOS20=(IToken)Match(input,EOS,FOLLOW_EOS_in_stat226);  
                    	stream_EOS.Add(EOS20);



                    	// AST REWRITE
                    	// elements:          t, expr, EQUALS, name
                    	// token labels:      t, name
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleTokenStream stream_t = new RewriteRuleTokenStream(adaptor, "token t", t);
                    	RewriteRuleTokenStream stream_name = new RewriteRuleTokenStream(adaptor, "token name", name);
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 33:31: -> ^( EQUALS ^( $t $name) expr )
                    	{
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:33:34: ^( EQUALS ^( $t $name) expr )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_EQUALS.NextNode(), root_1);

                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:33:43: ^( $t $name)
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

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:35:2: name= ID EQUALS expr EOS
                    {
                    	name=(IToken)Match(input,ID,FOLLOW_ID_in_stat250);  
                    	stream_ID.Add(name);

                    	EQUALS21=(IToken)Match(input,EQUALS,FOLLOW_EQUALS_in_stat252);  
                    	stream_EQUALS.Add(EQUALS21);

                    	PushFollow(FOLLOW_expr_in_stat254);
                    	expr22 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr22.Tree);
                    	EOS23=(IToken)Match(input,EOS,FOLLOW_EOS_in_stat256);  
                    	stream_EOS.Add(EOS23);



                    	// AST REWRITE
                    	// elements:          expr, EQUALS, name
                    	// token labels:      name
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleTokenStream stream_name = new RewriteRuleTokenStream(adaptor, "token name", name);
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 35:26: -> ^( EQUALS $name expr )
                    	{
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:35:29: ^( EQUALS $name expr )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_EQUALS.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_name.NextNode());
                    	    adaptor.AddChild(root_1, stream_expr.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 4 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:37:2: RETURN expr EOS
                    {
                    	RETURN24=(IToken)Match(input,RETURN,FOLLOW_RETURN_in_stat273);  
                    	stream_RETURN.Add(RETURN24);

                    	PushFollow(FOLLOW_expr_in_stat275);
                    	expr25 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr25.Tree);
                    	EOS26=(IToken)Match(input,EOS,FOLLOW_EOS_in_stat277);  
                    	stream_EOS.Add(EOS26);



                    	// AST REWRITE
                    	// elements:          RETURN, expr
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 37:18: -> ^( RETURN expr )
                    	{
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:37:21: ^( RETURN expr )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_RETURN.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_expr.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 5 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:39:2: IF LBRAC expr RBRAC '{' ( stat )* '}'
                    {
                    	IF27=(IToken)Match(input,IF,FOLLOW_IF_in_stat291);  
                    	stream_IF.Add(IF27);

                    	LBRAC28=(IToken)Match(input,LBRAC,FOLLOW_LBRAC_in_stat293);  
                    	stream_LBRAC.Add(LBRAC28);

                    	PushFollow(FOLLOW_expr_in_stat295);
                    	expr29 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr29.Tree);
                    	RBRAC30=(IToken)Match(input,RBRAC,FOLLOW_RBRAC_in_stat297);  
                    	stream_RBRAC.Add(RBRAC30);

                    	char_literal31=(IToken)Match(input,31,FOLLOW_31_in_stat299);  
                    	stream_31.Add(char_literal31);

                    	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:39:26: ( stat )*
                    	do 
                    	{
                    	    int alt4 = 2;
                    	    int LA4_0 = input.LA(1);

                    	    if ( (LA4_0 == ID || (LA4_0 >= RETURN && LA4_0 <= LBRAC) || LA4_0 == WHILE || (LA4_0 >= MINUS_OP && LA4_0 <= BOOL_LITERAL)) )
                    	    {
                    	        alt4 = 1;
                    	    }


                    	    switch (alt4) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:39:26: stat
                    			    {
                    			    	PushFollow(FOLLOW_stat_in_stat301);
                    			    	stat32 = stat();
                    			    	state.followingStackPointer--;

                    			    	stream_stat.Add(stat32.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop4;
                    	    }
                    	} while (true);

                    	loop4:
                    		;	// Stops C# compiler whining that label 'loop4' has no statements

                    	char_literal33=(IToken)Match(input,32,FOLLOW_32_in_stat304);  
                    	stream_32.Add(char_literal33);



                    	// AST REWRITE
                    	// elements:          expr, stat, IF
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 39:36: -> ^( IF expr ( stat )* )
                    	{
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:39:39: ^( IF expr ( stat )* )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_IF.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_expr.NextTree());
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:39:49: ( stat )*
                    	    while ( stream_stat.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_stat.NextTree());

                    	    }
                    	    stream_stat.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 6 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:41:2: WHILE LBRAC expr RBRAC '{' ( stat )* '}'
                    {
                    	WHILE34=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_stat321);  
                    	stream_WHILE.Add(WHILE34);

                    	LBRAC35=(IToken)Match(input,LBRAC,FOLLOW_LBRAC_in_stat323);  
                    	stream_LBRAC.Add(LBRAC35);

                    	PushFollow(FOLLOW_expr_in_stat325);
                    	expr36 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr36.Tree);
                    	RBRAC37=(IToken)Match(input,RBRAC,FOLLOW_RBRAC_in_stat327);  
                    	stream_RBRAC.Add(RBRAC37);

                    	char_literal38=(IToken)Match(input,31,FOLLOW_31_in_stat329);  
                    	stream_31.Add(char_literal38);

                    	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:41:29: ( stat )*
                    	do 
                    	{
                    	    int alt5 = 2;
                    	    int LA5_0 = input.LA(1);

                    	    if ( (LA5_0 == ID || (LA5_0 >= RETURN && LA5_0 <= LBRAC) || LA5_0 == WHILE || (LA5_0 >= MINUS_OP && LA5_0 <= BOOL_LITERAL)) )
                    	    {
                    	        alt5 = 1;
                    	    }


                    	    switch (alt5) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:41:29: stat
                    			    {
                    			    	PushFollow(FOLLOW_stat_in_stat331);
                    			    	stat39 = stat();
                    			    	state.followingStackPointer--;

                    			    	stream_stat.Add(stat39.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop5;
                    	    }
                    	} while (true);

                    	loop5:
                    		;	// Stops C# compiler whining that label 'loop5' has no statements

                    	char_literal40=(IToken)Match(input,32,FOLLOW_32_in_stat334);  
                    	stream_32.Add(char_literal40);



                    	// AST REWRITE
                    	// elements:          WHILE, stat, expr
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 41:39: -> ^( WHILE expr ( stat )* )
                    	{
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:41:42: ^( WHILE expr ( stat )* )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_WHILE.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_expr.NextTree());
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:41:55: ( stat )*
                    	    while ( stream_stat.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_stat.NextTree());

                    	    }
                    	    stream_stat.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
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
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:44:1: expr : additive_expr ( REL_OP additive_expr )* ;
    public CFlatParser.expr_return expr() // throws RecognitionException [1]
    {   
        CFlatParser.expr_return retval = new CFlatParser.expr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken REL_OP42 = null;
        CFlatParser.additive_expr_return additive_expr41 = default(CFlatParser.additive_expr_return);

        CFlatParser.additive_expr_return additive_expr43 = default(CFlatParser.additive_expr_return);


        CommonTree REL_OP42_tree=null;

        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:44:6: ( additive_expr ( REL_OP additive_expr )* )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:44:8: additive_expr ( REL_OP additive_expr )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additive_expr_in_expr356);
            	additive_expr41 = additive_expr();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, additive_expr41.Tree);
            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:44:22: ( REL_OP additive_expr )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == REL_OP) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:44:23: REL_OP additive_expr
            			    {
            			    	REL_OP42=(IToken)Match(input,REL_OP,FOLLOW_REL_OP_in_expr359); 
            			    		REL_OP42_tree = (CommonTree)adaptor.Create(REL_OP42);
            			    		root_0 = (CommonTree)adaptor.BecomeRoot(REL_OP42_tree, root_0);

            			    	PushFollow(FOLLOW_additive_expr_in_expr362);
            			    	additive_expr43 = additive_expr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, additive_expr43.Tree);

            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
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
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:46:1: additive_expr : multExpr ( ( '+' | '-' ) multExpr )* ;
    public CFlatParser.additive_expr_return additive_expr() // throws RecognitionException [1]
    {   
        CFlatParser.additive_expr_return retval = new CFlatParser.additive_expr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal45 = null;
        IToken char_literal46 = null;
        CFlatParser.multExpr_return multExpr44 = default(CFlatParser.multExpr_return);

        CFlatParser.multExpr_return multExpr47 = default(CFlatParser.multExpr_return);


        CommonTree char_literal45_tree=null;
        CommonTree char_literal46_tree=null;

        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:46:14: ( multExpr ( ( '+' | '-' ) multExpr )* )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:46:18: multExpr ( ( '+' | '-' ) multExpr )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multExpr_in_additive_expr373);
            	multExpr44 = multExpr();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, multExpr44.Tree);
            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:47:1: ( ( '+' | '-' ) multExpr )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == MINUS_OP || LA9_0 == ARITH_OP) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:47:2: ( '+' | '-' ) multExpr
            			    {
            			    	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:47:2: ( '+' | '-' )
            			    	int alt8 = 2;
            			    	int LA8_0 = input.LA(1);

            			    	if ( (LA8_0 == ARITH_OP) )
            			    	{
            			    	    alt8 = 1;
            			    	}
            			    	else if ( (LA8_0 == MINUS_OP) )
            			    	{
            			    	    alt8 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d8s0 =
            			    	        new NoViableAltException("", 8, 0, input);

            			    	    throw nvae_d8s0;
            			    	}
            			    	switch (alt8) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:47:3: '+'
            			    	        {
            			    	        	char_literal45=(IToken)Match(input,ARITH_OP,FOLLOW_ARITH_OP_in_additive_expr378); 
            			    	        		char_literal45_tree = (CommonTree)adaptor.Create(char_literal45);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal45_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:47:8: '-'
            			    	        {
            			    	        	char_literal46=(IToken)Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_additive_expr381); 
            			    	        		char_literal46_tree = (CommonTree)adaptor.Create(char_literal46);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal46_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multExpr_in_additive_expr385);
            			    	multExpr47 = multExpr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, multExpr47.Tree);

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

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
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
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:50:1: multExpr : atom ( ( '*' | '/' | '%' ) atom )* ;
    public CFlatParser.multExpr_return multExpr() // throws RecognitionException [1]
    {   
        CFlatParser.multExpr_return retval = new CFlatParser.multExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set49 = null;
        CFlatParser.atom_return atom48 = default(CFlatParser.atom_return);

        CFlatParser.atom_return atom50 = default(CFlatParser.atom_return);


        CommonTree set49_tree=null;

        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:51:5: ( atom ( ( '*' | '/' | '%' ) atom )* )
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:51:9: atom ( ( '*' | '/' | '%' ) atom )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_atom_in_multExpr406);
            	atom48 = atom();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, atom48.Tree);
            	// C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:51:14: ( ( '*' | '/' | '%' ) atom )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= MULT_OP && LA10_0 <= REM_OP)) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:51:15: ( '*' | '/' | '%' ) atom
            			    {
            			    	set49=(IToken)input.LT(1);
            			    	set49 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= MULT_OP && input.LA(1) <= REM_OP) ) 
            			    	{
            			    	    input.Consume();
            			    	    root_0 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(set49), root_0);
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_atom_in_multExpr418);
            			    	atom50 = atom();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, atom50.Tree);

            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
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
    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:54:1: atom : ( MINUS_OP INT | INT | LBRAC expr RBRAC -> expr | STRING_LITERAL | CHAR_LITERAL | BOOL_LITERAL | ID '()' -> ^( CALL ID ) | ID );
    public CFlatParser.atom_return atom() // throws RecognitionException [1]
    {   
        CFlatParser.atom_return retval = new CFlatParser.atom_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken MINUS_OP51 = null;
        IToken INT52 = null;
        IToken INT53 = null;
        IToken LBRAC54 = null;
        IToken RBRAC56 = null;
        IToken STRING_LITERAL57 = null;
        IToken CHAR_LITERAL58 = null;
        IToken BOOL_LITERAL59 = null;
        IToken ID60 = null;
        IToken string_literal61 = null;
        IToken ID62 = null;
        CFlatParser.expr_return expr55 = default(CFlatParser.expr_return);


        CommonTree MINUS_OP51_tree=null;
        CommonTree INT52_tree=null;
        CommonTree INT53_tree=null;
        CommonTree LBRAC54_tree=null;
        CommonTree RBRAC56_tree=null;
        CommonTree STRING_LITERAL57_tree=null;
        CommonTree CHAR_LITERAL58_tree=null;
        CommonTree BOOL_LITERAL59_tree=null;
        CommonTree ID60_tree=null;
        CommonTree string_literal61_tree=null;
        CommonTree ID62_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_34 = new RewriteRuleTokenStream(adaptor,"token 34");
        RewriteRuleTokenStream stream_RBRAC = new RewriteRuleTokenStream(adaptor,"token RBRAC");
        RewriteRuleTokenStream stream_LBRAC = new RewriteRuleTokenStream(adaptor,"token LBRAC");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        try 
    	{
            // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:54:5: ( MINUS_OP INT | INT | LBRAC expr RBRAC -> expr | STRING_LITERAL | CHAR_LITERAL | BOOL_LITERAL | ID '()' -> ^( CALL ID ) | ID )
            int alt11 = 8;
            alt11 = dfa11.Predict(input);
            switch (alt11) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:54:9: MINUS_OP INT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	MINUS_OP51=(IToken)Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_atom434); 
                    		MINUS_OP51_tree = (CommonTree)adaptor.Create(MINUS_OP51);
                    		adaptor.AddChild(root_0, MINUS_OP51_tree);

                    	INT52=(IToken)Match(input,INT,FOLLOW_INT_in_atom436); 
                    		INT52_tree = (CommonTree)adaptor.Create(INT52);
                    		adaptor.AddChild(root_0, INT52_tree);


                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:56:2: INT
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	INT53=(IToken)Match(input,INT,FOLLOW_INT_in_atom442); 
                    		INT53_tree = (CommonTree)adaptor.Create(INT53);
                    		adaptor.AddChild(root_0, INT53_tree);


                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:58:2: LBRAC expr RBRAC
                    {
                    	LBRAC54=(IToken)Match(input,LBRAC,FOLLOW_LBRAC_in_atom448);  
                    	stream_LBRAC.Add(LBRAC54);

                    	PushFollow(FOLLOW_expr_in_atom450);
                    	expr55 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr55.Tree);
                    	RBRAC56=(IToken)Match(input,RBRAC,FOLLOW_RBRAC_in_atom452);  
                    	stream_RBRAC.Add(RBRAC56);



                    	// AST REWRITE
                    	// elements:          expr
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 58:19: -> expr
                    	{
                    	    adaptor.AddChild(root_0, stream_expr.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 4 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:60:2: STRING_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	STRING_LITERAL57=(IToken)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_atom462); 
                    		STRING_LITERAL57_tree = (CommonTree)adaptor.Create(STRING_LITERAL57);
                    		adaptor.AddChild(root_0, STRING_LITERAL57_tree);


                    }
                    break;
                case 5 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:62:2: CHAR_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	CHAR_LITERAL58=(IToken)Match(input,CHAR_LITERAL,FOLLOW_CHAR_LITERAL_in_atom468); 
                    		CHAR_LITERAL58_tree = (CommonTree)adaptor.Create(CHAR_LITERAL58);
                    		adaptor.AddChild(root_0, CHAR_LITERAL58_tree);


                    }
                    break;
                case 6 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:64:2: BOOL_LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	BOOL_LITERAL59=(IToken)Match(input,BOOL_LITERAL,FOLLOW_BOOL_LITERAL_in_atom474); 
                    		BOOL_LITERAL59_tree = (CommonTree)adaptor.Create(BOOL_LITERAL59);
                    		adaptor.AddChild(root_0, BOOL_LITERAL59_tree);


                    }
                    break;
                case 7 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:66:2: ID '()'
                    {
                    	ID60=(IToken)Match(input,ID,FOLLOW_ID_in_atom480);  
                    	stream_ID.Add(ID60);

                    	string_literal61=(IToken)Match(input,34,FOLLOW_34_in_atom482);  
                    	stream_34.Add(string_literal61);



                    	// AST REWRITE
                    	// elements:          ID
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 66:10: -> ^( CALL ID )
                    	{
                    	    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:66:13: ^( CALL ID )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(CALL, "CALL"), root_1);

                    	    adaptor.AddChild(root_1, stream_ID.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 8 :
                    // C:\\data\\code\\abcm\\CFlat\\CFlat\\CFlat.g:68:2: ID
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	ID62=(IToken)Match(input,ID,FOLLOW_ID_in_atom496); 
                    		ID62_tree = (CommonTree)adaptor.Create(ID62);
                    		adaptor.AddChild(root_0, ID62_tree);


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
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

    // Delegated rules


   	protected DFA11 dfa11;
	private void InitializeCyclicDFAs()
	{
    	this.dfa11 = new DFA11(this);
	}

    const string DFA11_eotS =
        "\x0a\uffff";
    const string DFA11_eofS =
        "\x0a\uffff";
    const string DFA11_minS =
        "\x01\x08\x06\uffff\x01\x09\x02\uffff";
    const string DFA11_maxS =
        "\x01\x15\x06\uffff\x01\x22\x02\uffff";
    const string DFA11_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\uffff\x01\x07\x01\x08";
    const string DFA11_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA11_transitionS = {
            "\x01\x07\x04\uffff\x01\x03\x03\uffff\x01\x01\x01\x02\x01\x04"+
            "\x01\x05\x01\x06",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x09\x04\uffff\x01\x09\x01\uffff\x02\x09\x04\uffff\x04"+
            "\x09\x08\uffff\x01\x08",
            "",
            ""
    };

    static readonly short[] DFA11_eot = DFA.UnpackEncodedString(DFA11_eotS);
    static readonly short[] DFA11_eof = DFA.UnpackEncodedString(DFA11_eofS);
    static readonly char[] DFA11_min = DFA.UnpackEncodedStringToUnsignedChars(DFA11_minS);
    static readonly char[] DFA11_max = DFA.UnpackEncodedStringToUnsignedChars(DFA11_maxS);
    static readonly short[] DFA11_accept = DFA.UnpackEncodedString(DFA11_acceptS);
    static readonly short[] DFA11_special = DFA.UnpackEncodedString(DFA11_specialS);
    static readonly short[][] DFA11_transition = DFA.UnpackEncodedStringArray(DFA11_transitionS);

    protected class DFA11 : DFA
    {
        public DFA11(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 11;
            this.eot = DFA11_eot;
            this.eof = DFA11_eof;
            this.min = DFA11_min;
            this.max = DFA11_max;
            this.accept = DFA11_accept;
            this.special = DFA11_special;
            this.transition = DFA11_transition;

        }

        override public string Description
        {
            get { return "54:1: atom : ( MINUS_OP INT | INT | LBRAC expr RBRAC -> expr | STRING_LITERAL | CHAR_LITERAL | BOOL_LITERAL | ID '()' -> ^( CALL ID ) | ID );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_30_in_prog85 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_CLASS_in_prog87 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ID_in_prog89 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_prog91 = new BitSet(new ulong[]{0x0000000140000000UL});
    public static readonly BitSet FOLLOW_method_in_prog93 = new BitSet(new ulong[]{0x0000000140000000UL});
    public static readonly BitSet FOLLOW_32_in_prog96 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_30_in_method120 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ID_in_method124 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ID_in_method128 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LBRAC_in_method130 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_param_in_method132 = new BitSet(new ulong[]{0x0000000200004000UL});
    public static readonly BitSet FOLLOW_33_in_method135 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_param_in_method137 = new BitSet(new ulong[]{0x0000000200004000UL});
    public static readonly BitSet FOLLOW_RBRAC_in_method141 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_method143 = new BitSet(new ulong[]{0x00000001003EB900UL});
    public static readonly BitSet FOLLOW_stat_in_method145 = new BitSet(new ulong[]{0x00000001003EB900UL});
    public static readonly BitSet FOLLOW_32_in_method148 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_param177 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ID_in_param181 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_stat203 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_EOS_in_stat205 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_stat216 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ID_in_stat220 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_EQUALS_in_stat222 = new BitSet(new ulong[]{0x00000000003E2100UL});
    public static readonly BitSet FOLLOW_expr_in_stat224 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_EOS_in_stat226 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_stat250 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_EQUALS_in_stat252 = new BitSet(new ulong[]{0x00000000003E2100UL});
    public static readonly BitSet FOLLOW_expr_in_stat254 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_EOS_in_stat256 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RETURN_in_stat273 = new BitSet(new ulong[]{0x00000000003E2100UL});
    public static readonly BitSet FOLLOW_expr_in_stat275 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_EOS_in_stat277 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_stat291 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LBRAC_in_stat293 = new BitSet(new ulong[]{0x00000000003E2100UL});
    public static readonly BitSet FOLLOW_expr_in_stat295 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_RBRAC_in_stat297 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_stat299 = new BitSet(new ulong[]{0x00000001003EB900UL});
    public static readonly BitSet FOLLOW_stat_in_stat301 = new BitSet(new ulong[]{0x00000001003EB900UL});
    public static readonly BitSet FOLLOW_32_in_stat304 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHILE_in_stat321 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LBRAC_in_stat323 = new BitSet(new ulong[]{0x00000000003E2100UL});
    public static readonly BitSet FOLLOW_expr_in_stat325 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_RBRAC_in_stat327 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_stat329 = new BitSet(new ulong[]{0x00000001003EB900UL});
    public static readonly BitSet FOLLOW_stat_in_stat331 = new BitSet(new ulong[]{0x00000001003EB900UL});
    public static readonly BitSet FOLLOW_32_in_stat334 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additive_expr_in_expr356 = new BitSet(new ulong[]{0x0000000000010002UL});
    public static readonly BitSet FOLLOW_REL_OP_in_expr359 = new BitSet(new ulong[]{0x00000000003E2100UL});
    public static readonly BitSet FOLLOW_additive_expr_in_expr362 = new BitSet(new ulong[]{0x0000000000010002UL});
    public static readonly BitSet FOLLOW_multExpr_in_additive_expr373 = new BitSet(new ulong[]{0x0000000000420002UL});
    public static readonly BitSet FOLLOW_ARITH_OP_in_additive_expr378 = new BitSet(new ulong[]{0x00000000003E2100UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_additive_expr381 = new BitSet(new ulong[]{0x00000000003E2100UL});
    public static readonly BitSet FOLLOW_multExpr_in_additive_expr385 = new BitSet(new ulong[]{0x0000000000420002UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr406 = new BitSet(new ulong[]{0x0000000003800002UL});
    public static readonly BitSet FOLLOW_set_in_multExpr409 = new BitSet(new ulong[]{0x00000000003E2100UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr418 = new BitSet(new ulong[]{0x0000000003800002UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_atom434 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_INT_in_atom436 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_atom442 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRAC_in_atom448 = new BitSet(new ulong[]{0x00000000003E2100UL});
    public static readonly BitSet FOLLOW_expr_in_atom450 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_RBRAC_in_atom452 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_atom462 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_LITERAL_in_atom468 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOL_LITERAL_in_atom474 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_atom480 = new BitSet(new ulong[]{0x0000000400000000UL});
    public static readonly BitSet FOLLOW_34_in_atom482 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_atom496 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}