// $ANTLR 3.1.2 C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g 2009-04-18 23:19:55

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
namespace 
    Decaf

{

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
		"ARITH_OP", 
		"MINUS_OP", 
		"MULT_OP", 
		"DIV_OP", 
		"REM_OP", 
		"BOOL_LITERAL", 
		"CHAR_LITERAL", 
		"LBRAC", 
		"RBRAC", 
		"STRING_LITERAL", 
		"ID", 
		"CALLOUT", 
		"ALPHA", 
		"ALPHA_NUM", 
		"DIGIT", 
		"','"
    };

    public const int ALPHA_NUM = 17;
    public const int MULT_OP = 6;
    public const int DIV_OP = 7;
    public const int ARITH_OP = 4;
    public const int REM_OP = 8;
    public const int BOOL_LITERAL = 9;
    public const int ID = 14;
    public const int EOF = -1;
    public const int LBRAC = 11;
    public const int ALPHA = 16;
    public const int T__19 = 19;
    public const int STRING_LITERAL = 13;
    public const int CHAR_LITERAL = 10;
    public const int RBRAC = 12;
    public const int MINUS_OP = 5;
    public const int DIGIT = 18;
    public const int CALLOUT = 15;

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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:16:1: prog : (e= expr )+ ;
    public void prog() // throws RecognitionException [1]
    {   
        ExprStack e = default(ExprStack);


        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:16:5: ( (e= expr )+ )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:16:9: (e= expr )+
            {
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:16:9: (e= expr )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == MINUS_OP || (LA1_0 >= BOOL_LITERAL && LA1_0 <= LBRAC) || (LA1_0 >= STRING_LITERAL && LA1_0 <= CALLOUT) || LA1_0 == DIGIT) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:16:11: e= expr
            			    {
            			    	CodeGenerator.BeginExpression();
            			    	PushFollow(FOLLOW_expr_in_prog49);
            			    	e = expr();
            			    	state.followingStackPointer--;

            			    	 GenerateExpression(e); CodeGenerator.EndExpression(); 

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


    // $ANTLR start "expr"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:1: expr returns [ExprStack stack] : ( (m= multExpr (b= arithop e= expr )* ) | m= method_call );
    public ExprStack expr() // throws RecognitionException [1]
    {   
        ExprStack stack = default(ExprStack);

        ExprStack m = default(ExprStack);

        string b = default(string);

        ExprStack e = default(ExprStack);


        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:31: ( (m= multExpr (b= arithop e= expr )* ) | m= method_call )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( (LA3_0 == MINUS_OP || (LA3_0 >= BOOL_LITERAL && LA3_0 <= LBRAC) || (LA3_0 >= STRING_LITERAL && LA3_0 <= ID) || LA3_0 == DIGIT) )
            {
                alt3 = 1;
            }
            else if ( (LA3_0 == CALLOUT) )
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
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:33: (m= multExpr (b= arithop e= expr )* )
                    {
                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:33: (m= multExpr (b= arithop e= expr )* )
                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:34: m= multExpr (b= arithop e= expr )*
                    	{
                    		PushFollow(FOLLOW_multExpr_in_expr68);
                    		m = multExpr();
                    		state.followingStackPointer--;

                    		// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:45: (b= arithop e= expr )*
                    		do 
                    		{
                    		    int alt2 = 2;
                    		    int LA2_0 = input.LA(1);

                    		    if ( (LA2_0 == MINUS_OP) )
                    		    {
                    		        alt2 = 1;
                    		    }
                    		    else if ( (LA2_0 == ARITH_OP) )
                    		    {
                    		        alt2 = 1;
                    		    }


                    		    switch (alt2) 
                    			{
                    				case 1 :
                    				    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:46: b= arithop e= expr
                    				    {
                    				    	PushFollow(FOLLOW_arithop_in_expr73);
                    				    	b = arithop();
                    				    	state.followingStackPointer--;

                    				    	PushFollow(FOLLOW_expr_in_expr77);
                    				    	e = expr();
                    				    	state.followingStackPointer--;


                    				    }
                    				    break;

                    				default:
                    				    goto loop2;
                    		    }
                    		} while (true);

                    		loop2:
                    			;	// Stops C# compiler whining that label 'loop2' has no statements

                    		 
                    				if(b == null){
                    					stack =  m;
                    				}
                    				else{
                    					stack =  new ExprStack {new OperationExprItem(b)};
                    					stack.Prepend(e);
                    					stack.Prepend(m);
                    				}
                    			
                    			

                    	}


                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:30:2: m= method_call
                    {
                    	PushFollow(FOLLOW_method_call_in_expr92);
                    	m = method_call();
                    	state.followingStackPointer--;

                    	 stack =  m; 

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
        return stack;
    }
    // $ANTLR end "expr"


    // $ANTLR start "arithop"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:33:1: arithop returns [string value] : ( ARITH_OP | MINUS_OP );
    public string arithop() // throws RecognitionException [1]
    {   
        string value = default(string);

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:33:32: ( ARITH_OP | MINUS_OP )
            int alt4 = 2;
            int LA4_0 = input.LA(1);

            if ( (LA4_0 == ARITH_OP) )
            {
                alt4 = 1;
            }
            else if ( (LA4_0 == MINUS_OP) )
            {
                alt4 = 2;
            }
            else 
            {
                NoViableAltException nvae_d4s0 =
                    new NoViableAltException("", 4, 0, input);

                throw nvae_d4s0;
            }
            switch (alt4) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:33:35: ARITH_OP
                    {
                    	Match(input,ARITH_OP,FOLLOW_ARITH_OP_in_arithop109); 
                    	value =  "Addition";

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:33:69: MINUS_OP
                    {
                    	Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_arithop115); 
                    	value =  "Subtraction";

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
        return value;
    }
    // $ANTLR end "arithop"


    // $ANTLR start "multop"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:35:1: multop returns [string value] : ( MULT_OP | DIV_OP | REM_OP );
    public string multop() // throws RecognitionException [1]
    {   
        string value = default(string);

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:35:31: ( MULT_OP | DIV_OP | REM_OP )
            int alt5 = 3;
            switch ( input.LA(1) ) 
            {
            case MULT_OP:
            	{
                alt5 = 1;
                }
                break;
            case DIV_OP:
            	{
                alt5 = 2;
                }
                break;
            case REM_OP:
            	{
                alt5 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d5s0 =
            	        new NoViableAltException("", 5, 0, input);

            	    throw nvae_d5s0;
            }

            switch (alt5) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:35:33: MULT_OP
                    {
                    	Match(input,MULT_OP,FOLLOW_MULT_OP_in_multop128); 
                    	 value =  "Multiplication"; 

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:36:7: DIV_OP
                    {
                    	Match(input,DIV_OP,FOLLOW_DIV_OP_in_multop139); 
                    	value =  "Division";

                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:37:7: REM_OP
                    {
                    	Match(input,REM_OP,FOLLOW_REM_OP_in_multop148); 
                    	value =  "Remainder";

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
        return value;
    }
    // $ANTLR end "multop"


    // $ANTLR start "multExpr"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:39:1: multExpr returns [ExprStack stack] : (l= atom (b= multop e= multExpr )* ) ;
    public ExprStack multExpr() // throws RecognitionException [1]
    {   
        ExprStack stack = default(ExprStack);

        ExprStack l = default(ExprStack);

        string b = default(string);

        ExprStack e = default(ExprStack);


        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:39:35: ( (l= atom (b= multop e= multExpr )* ) )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:39:39: (l= atom (b= multop e= multExpr )* )
            {
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:39:39: (l= atom (b= multop e= multExpr )* )
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:39:40: l= atom (b= multop e= multExpr )*
            	{
            		PushFollow(FOLLOW_atom_in_multExpr165);
            		l = atom();
            		state.followingStackPointer--;

            		// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:39:47: (b= multop e= multExpr )*
            		do 
            		{
            		    int alt6 = 2;
            		    switch ( input.LA(1) ) 
            		    {
            		    case MULT_OP:
            		    	{
            		        alt6 = 1;
            		        }
            		        break;
            		    case DIV_OP:
            		    	{
            		        alt6 = 1;
            		        }
            		        break;
            		    case REM_OP:
            		    	{
            		        alt6 = 1;
            		        }
            		        break;

            		    }

            		    switch (alt6) 
            			{
            				case 1 :
            				    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:39:48: b= multop e= multExpr
            				    {
            				    	PushFollow(FOLLOW_multop_in_multExpr170);
            				    	b = multop();
            				    	state.followingStackPointer--;

            				    	PushFollow(FOLLOW_multExpr_in_multExpr174);
            				    	e = multExpr();
            				    	state.followingStackPointer--;


            				    }
            				    break;

            				default:
            				    goto loop6;
            		    }
            		} while (true);

            		loop6:
            			;	// Stops C# compiler whining that label 'loop6' has no statements

            		 
            		    
            		    	if(b == null){
            				stack =  l;
            			}
            			else{
            				stack =  new ExprStack {new OperationExprItem(b)};
            				stack.Prepend(e);
            				stack.Prepend(l);
            			}    
            		    

            	}


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
        return stack;
    }
    // $ANTLR end "multExpr"


    // $ANTLR start "literal"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:62:1: literal returns [ExprStack stack] : ( ( int_literal ) | b= BOOL_LITERAL | c= CHAR_LITERAL );
    public ExprStack literal() // throws RecognitionException [1]
    {   
        ExprStack stack = default(ExprStack);

        IToken b = null;
        IToken c = null;
        DecafParser.int_literal_return int_literal1 = default(DecafParser.int_literal_return);


        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:62:34: ( ( int_literal ) | b= BOOL_LITERAL | c= CHAR_LITERAL )
            int alt7 = 3;
            switch ( input.LA(1) ) 
            {
            case MINUS_OP:
            case DIGIT:
            	{
                alt7 = 1;
                }
                break;
            case BOOL_LITERAL:
            	{
                alt7 = 2;
                }
                break;
            case CHAR_LITERAL:
            	{
                alt7 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d7s0 =
            	        new NoViableAltException("", 7, 0, input);

            	    throw nvae_d7s0;
            }

            switch (alt7) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:62:37: ( int_literal )
                    {
                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:62:37: ( int_literal )
                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:62:38: int_literal
                    	{
                    		PushFollow(FOLLOW_int_literal_in_literal248);
                    		int_literal1 = int_literal();
                    		state.followingStackPointer--;

                    		 stack =  new ExprStack{ new NumericExprItem(int.Parse(((int_literal1 != null) ? input.ToString((IToken)(int_literal1.Start),(IToken)(int_literal1.Stop)) : null)))};

                    	}


                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:64:2: b= BOOL_LITERAL
                    {
                    	b=(IToken)Match(input,BOOL_LITERAL,FOLLOW_BOOL_LITERAL_in_literal259); 
                    	stack =  new ExprStack{ new BoolExprItem(bool.Parse(((b != null) ? b.Text : null)))};

                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:66:2: c= CHAR_LITERAL
                    {
                    	c=(IToken)Match(input,CHAR_LITERAL,FOLLOW_CHAR_LITERAL_in_literal269); 
                    	stack =  new ExprStack{ new CharExprItem(char.Parse(((c != null) ? c.Text : null).Replace("'","")))};

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
        return stack;
    }
    // $ANTLR end "literal"


    // $ANTLR start "atom"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:69:1: atom returns [ExprStack stack] : (l= literal | ( LBRAC )+ (e= expr )+ RBRAC | s= STRING_LITERAL | id= ID );
    public ExprStack atom() // throws RecognitionException [1]
    {   
        ExprStack stack = default(ExprStack);

        IToken s = null;
        IToken id = null;
        ExprStack l = default(ExprStack);

        ExprStack e = default(ExprStack);


        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:69:31: (l= literal | ( LBRAC )+ (e= expr )+ RBRAC | s= STRING_LITERAL | id= ID )
            int alt10 = 4;
            switch ( input.LA(1) ) 
            {
            case MINUS_OP:
            case BOOL_LITERAL:
            case CHAR_LITERAL:
            case DIGIT:
            	{
                alt10 = 1;
                }
                break;
            case LBRAC:
            	{
                alt10 = 2;
                }
                break;
            case STRING_LITERAL:
            	{
                alt10 = 3;
                }
                break;
            case ID:
            	{
                alt10 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d10s0 =
            	        new NoViableAltException("", 10, 0, input);

            	    throw nvae_d10s0;
            }

            switch (alt10) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:70:2: l= literal
                    {
                    	PushFollow(FOLLOW_literal_in_atom290);
                    	l = literal();
                    	state.followingStackPointer--;

                    	stack =  l;

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:72:2: ( LBRAC )+ (e= expr )+ RBRAC
                    {
                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:72:2: ( LBRAC )+
                    	int cnt8 = 0;
                    	do 
                    	{
                    	    int alt8 = 2;
                    	    int LA8_0 = input.LA(1);

                    	    if ( (LA8_0 == LBRAC) )
                    	    {
                    	        alt8 = 1;
                    	    }


                    	    switch (alt8) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:72:2: LBRAC
                    			    {
                    			    	Match(input,LBRAC,FOLLOW_LBRAC_in_atom300); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt8 >= 1 ) goto loop8;
                    		            EarlyExitException eee8 =
                    		                new EarlyExitException(8, input);
                    		            throw eee8;
                    	    }
                    	    cnt8++;
                    	} while (true);

                    	loop8:
                    		;	// Stops C# compiler whinging that label 'loop8' has no statements

                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:72:11: (e= expr )+
                    	int cnt9 = 0;
                    	do 
                    	{
                    	    int alt9 = 2;
                    	    int LA9_0 = input.LA(1);

                    	    if ( (LA9_0 == MINUS_OP || (LA9_0 >= BOOL_LITERAL && LA9_0 <= LBRAC) || (LA9_0 >= STRING_LITERAL && LA9_0 <= CALLOUT) || LA9_0 == DIGIT) )
                    	    {
                    	        alt9 = 1;
                    	    }


                    	    switch (alt9) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:72:11: e= expr
                    			    {
                    			    	PushFollow(FOLLOW_expr_in_atom306);
                    			    	e = expr();
                    			    	state.followingStackPointer--;


                    			    }
                    			    break;

                    			default:
                    			    if ( cnt9 >= 1 ) goto loop9;
                    		            EarlyExitException eee9 =
                    		                new EarlyExitException(9, input);
                    		            throw eee9;
                    	    }
                    	    cnt9++;
                    	} while (true);

                    	loop9:
                    		;	// Stops C# compiler whinging that label 'loop9' has no statements

                    	Match(input,RBRAC,FOLLOW_RBRAC_in_atom310); 
                    	stack =  e;

                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:74:2: s= STRING_LITERAL
                    {
                    	s=(IToken)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_atom320); 

                    			stack =  new ExprStack{ new StringExprItem(((s != null) ? s.Text : null))};
                    		

                    }
                    break;
                case 4 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:78:2: id= ID
                    {
                    	id=(IToken)Match(input,ID,FOLLOW_ID_in_atom329); 

                    			stack =  new ExprStack{ new IdExprItem(((id != null) ? id.Text : null))};
                    		

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
        return stack;
    }
    // $ANTLR end "atom"


    // $ANTLR start "method_call"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:83:1: method_call returns [ExprStack stack] : CALLOUT LBRAC m= STRING_LITERAL ( ',' callout_arg )* RBRAC ;
    public ExprStack method_call() // throws RecognitionException [1]
    {   
        ExprStack stack = default(ExprStack);

        IToken m = null;

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:83:38: ( CALLOUT LBRAC m= STRING_LITERAL ( ',' callout_arg )* RBRAC )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:84:4: CALLOUT LBRAC m= STRING_LITERAL ( ',' callout_arg )* RBRAC
            {
            	Match(input,CALLOUT,FOLLOW_CALLOUT_in_method_call346); 
            	Match(input,LBRAC,FOLLOW_LBRAC_in_method_call348); 
            	m=(IToken)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_method_call352); 
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:84:35: ( ',' callout_arg )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == 19) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:84:36: ',' callout_arg
            			    {
            			    	Match(input,19,FOLLOW_19_in_method_call355); 
            			    	PushFollow(FOLLOW_callout_arg_in_method_call357);
            			    	callout_arg();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	Match(input,RBRAC,FOLLOW_RBRAC_in_method_call362); 

            			stack =  new ExprStack{ new MethodCallExprItem(((m != null) ? m.Text : null))};
            		

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
        return stack;
    }
    // $ANTLR end "method_call"


    // $ANTLR start "callout_arg"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:89:1: callout_arg : expr ;
    public void callout_arg() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:90:2: ( expr )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:90:4: expr
            {
            	PushFollow(FOLLOW_expr_in_callout_arg375);
            	expr();
            	state.followingStackPointer--;


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
    // $ANTLR end "callout_arg"

    public class int_literal_return : ParserRuleReturnScope
    {
    };

    // $ANTLR start "int_literal"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:92:1: int_literal : decimal_literal ;
    public DecafParser.int_literal_return int_literal() // throws RecognitionException [1]
    {   
        DecafParser.int_literal_return retval = new DecafParser.int_literal_return();
        retval.Start = input.LT(1);

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:92:13: ( decimal_literal )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:92:16: decimal_literal
            {
            	PushFollow(FOLLOW_decimal_literal_in_int_literal385);
            	decimal_literal();
            	state.followingStackPointer--;


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "int_literal"


    // $ANTLR start "decimal_literal"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:110:1: decimal_literal returns [int value] : ( '-' ( DIGIT )+ | ( DIGIT )+ );
    public int decimal_literal() // throws RecognitionException [1]
    {   
        int value = default(int);

        IToken DIGIT2 = null;
        IToken DIGIT3 = null;

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:111:2: ( '-' ( DIGIT )+ | ( DIGIT )+ )
            int alt14 = 2;
            int LA14_0 = input.LA(1);

            if ( (LA14_0 == MINUS_OP) )
            {
                alt14 = 1;
            }
            else if ( (LA14_0 == DIGIT) )
            {
                alt14 = 2;
            }
            else 
            {
                NoViableAltException nvae_d14s0 =
                    new NoViableAltException("", 14, 0, input);

                throw nvae_d14s0;
            }
            switch (alt14) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:111:4: '-' ( DIGIT )+
                    {
                    	Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_decimal_literal497); 
                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:111:8: ( DIGIT )+
                    	int cnt12 = 0;
                    	do 
                    	{
                    	    int alt12 = 2;
                    	    int LA12_0 = input.LA(1);

                    	    if ( (LA12_0 == DIGIT) )
                    	    {
                    	        alt12 = 1;
                    	    }


                    	    switch (alt12) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:111:8: DIGIT
                    			    {
                    			    	DIGIT2=(IToken)Match(input,DIGIT,FOLLOW_DIGIT_in_decimal_literal499); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt12 >= 1 ) goto loop12;
                    		            EarlyExitException eee12 =
                    		                new EarlyExitException(12, input);
                    		            throw eee12;
                    	    }
                    	    cnt12++;
                    	} while (true);

                    	loop12:
                    		;	// Stops C# compiler whinging that label 'loop12' has no statements

                    	value =  -int.Parse(((DIGIT2 != null) ? DIGIT2.Text : null));

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:112:4: ( DIGIT )+
                    {
                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:112:4: ( DIGIT )+
                    	int cnt13 = 0;
                    	do 
                    	{
                    	    int alt13 = 2;
                    	    int LA13_0 = input.LA(1);

                    	    if ( (LA13_0 == DIGIT) )
                    	    {
                    	        alt13 = 1;
                    	    }


                    	    switch (alt13) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:112:4: DIGIT
                    			    {
                    			    	DIGIT3=(IToken)Match(input,DIGIT,FOLLOW_DIGIT_in_decimal_literal507); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt13 >= 1 ) goto loop13;
                    		            EarlyExitException eee13 =
                    		                new EarlyExitException(13, input);
                    		            throw eee13;
                    	    }
                    	    cnt13++;
                    	} while (true);

                    	loop13:
                    		;	// Stops C# compiler whinging that label 'loop13' has no statements

                    	value =  int.Parse(((DIGIT3 != null) ? DIGIT3.Text : null));

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
        return value;
    }
    // $ANTLR end "decimal_literal"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_expr_in_prog49 = new BitSet(new ulong[]{0x000000000004EE22UL});
    public static readonly BitSet FOLLOW_multExpr_in_expr68 = new BitSet(new ulong[]{0x0000000000000032UL});
    public static readonly BitSet FOLLOW_arithop_in_expr73 = new BitSet(new ulong[]{0x000000000004EE30UL});
    public static readonly BitSet FOLLOW_expr_in_expr77 = new BitSet(new ulong[]{0x0000000000000032UL});
    public static readonly BitSet FOLLOW_method_call_in_expr92 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARITH_OP_in_arithop109 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_arithop115 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MULT_OP_in_multop128 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DIV_OP_in_multop139 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_REM_OP_in_multop148 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr165 = new BitSet(new ulong[]{0x00000000000001C2UL});
    public static readonly BitSet FOLLOW_multop_in_multExpr170 = new BitSet(new ulong[]{0x0000000000046E20UL});
    public static readonly BitSet FOLLOW_multExpr_in_multExpr174 = new BitSet(new ulong[]{0x00000000000001C2UL});
    public static readonly BitSet FOLLOW_int_literal_in_literal248 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOL_LITERAL_in_literal259 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_LITERAL_in_literal269 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_atom290 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRAC_in_atom300 = new BitSet(new ulong[]{0x000000000004FE20UL});
    public static readonly BitSet FOLLOW_expr_in_atom306 = new BitSet(new ulong[]{0x000000000004FE20UL});
    public static readonly BitSet FOLLOW_RBRAC_in_atom310 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_atom320 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_atom329 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CALLOUT_in_method_call346 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LBRAC_in_method_call348 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_method_call352 = new BitSet(new ulong[]{0x0000000000081000UL});
    public static readonly BitSet FOLLOW_19_in_method_call355 = new BitSet(new ulong[]{0x000000000004EE20UL});
    public static readonly BitSet FOLLOW_callout_arg_in_method_call357 = new BitSet(new ulong[]{0x0000000000081000UL});
    public static readonly BitSet FOLLOW_RBRAC_in_method_call362 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_callout_arg375 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_decimal_literal_in_int_literal385 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_decimal_literal497 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_DIGIT_in_decimal_literal499 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_DIGIT_in_decimal_literal507 = new BitSet(new ulong[]{0x0000000000040002UL});

}
}