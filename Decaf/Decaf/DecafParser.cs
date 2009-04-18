// $ANTLR 3.1.2 C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g 2009-04-18 21:11:32

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
		"STRING_LITERAL", 
		"ARITH_OP", 
		"MINUS_OP", 
		"MULT_OP", 
		"DIV_OP", 
		"REM_OP", 
		"LBRAC", 
		"RBRAC", 
		"DIGIT", 
		"CHAR_LITERAL"
    };

    public const int MULT_OP = 7;
    public const int STRING_LITERAL = 4;
    public const int CHAR_LITERAL = 13;
    public const int DIV_OP = 8;
    public const int RBRAC = 11;
    public const int ARITH_OP = 5;
    public const int REM_OP = 9;
    public const int MINUS_OP = 6;
    public const int DIGIT = 12;
    public const int EOF = -1;
    public const int LBRAC = 10;

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

            	    if ( (LA1_0 == STRING_LITERAL || LA1_0 == MINUS_OP || LA1_0 == LBRAC || LA1_0 == DIGIT) )
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:1: expr returns [ExprStack stack] : ( (m= multExpr (b= arithop e= expr )* ) | (s= STRING_LITERAL ) );
    public ExprStack expr() // throws RecognitionException [1]
    {   
        ExprStack stack = default(ExprStack);

        IToken s = null;
        ExprStack m = default(ExprStack);

        string b = default(string);

        ExprStack e = default(ExprStack);


        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:31: ( (m= multExpr (b= arithop e= expr )* ) | (s= STRING_LITERAL ) )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( (LA3_0 == MINUS_OP || LA3_0 == LBRAC || LA3_0 == DIGIT) )
            {
                alt3 = 1;
            }
            else if ( (LA3_0 == STRING_LITERAL) )
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
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:30:2: (s= STRING_LITERAL )
                    {
                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:30:2: (s= STRING_LITERAL )
                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:30:3: s= STRING_LITERAL
                    	{
                    		s=(IToken)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_expr93); 

                    				stack =  new ExprStack{ new StringExprItem(((s != null) ? s.Text : null))};
                    			

                    	}


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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:34:1: arithop returns [string value] : ( ARITH_OP | MINUS_OP );
    public string arithop() // throws RecognitionException [1]
    {   
        string value = default(string);

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:34:32: ( ARITH_OP | MINUS_OP )
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
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:34:35: ARITH_OP
                    {
                    	Match(input,ARITH_OP,FOLLOW_ARITH_OP_in_arithop108); 
                    	value =  "Addition";

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:34:69: MINUS_OP
                    {
                    	Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_arithop114); 
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:36:1: multop returns [string value] : ( MULT_OP | DIV_OP | REM_OP );
    public string multop() // throws RecognitionException [1]
    {   
        string value = default(string);

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:36:31: ( MULT_OP | DIV_OP | REM_OP )
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
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:36:33: MULT_OP
                    {
                    	Match(input,MULT_OP,FOLLOW_MULT_OP_in_multop127); 
                    	 value =  "Multiplication"; 

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:37:7: DIV_OP
                    {
                    	Match(input,DIV_OP,FOLLOW_DIV_OP_in_multop138); 
                    	value =  "Division";

                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:38:7: REM_OP
                    {
                    	Match(input,REM_OP,FOLLOW_REM_OP_in_multop147); 
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:40:1: multExpr returns [ExprStack stack] : (l= atom (b= multop e= multExpr )* ) ;
    public ExprStack multExpr() // throws RecognitionException [1]
    {   
        ExprStack stack = default(ExprStack);

        ExprStack l = default(ExprStack);

        string b = default(string);

        ExprStack e = default(ExprStack);


        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:40:35: ( (l= atom (b= multop e= multExpr )* ) )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:40:39: (l= atom (b= multop e= multExpr )* )
            {
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:40:39: (l= atom (b= multop e= multExpr )* )
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:40:40: l= atom (b= multop e= multExpr )*
            	{
            		PushFollow(FOLLOW_atom_in_multExpr164);
            		l = atom();
            		state.followingStackPointer--;

            		// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:40:47: (b= multop e= multExpr )*
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
            				    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:40:48: b= multop e= multExpr
            				    {
            				    	PushFollow(FOLLOW_multop_in_multExpr169);
            				    	b = multop();
            				    	state.followingStackPointer--;

            				    	PushFollow(FOLLOW_multExpr_in_multExpr173);
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:63:1: literal returns [ExprStack stack] : ( int_literal ) ;
    public ExprStack literal() // throws RecognitionException [1]
    {   
        ExprStack stack = default(ExprStack);

        DecafParser.int_literal_return int_literal1 = default(DecafParser.int_literal_return);


        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:63:34: ( ( int_literal ) )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:63:37: ( int_literal )
            {
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:63:37: ( int_literal )
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:63:38: int_literal
            	{
            		PushFollow(FOLLOW_int_literal_in_literal247);
            		int_literal1 = int_literal();
            		state.followingStackPointer--;

            		 stack =  new ExprStack{ new NumericExprItem(int.Parse(((int_literal1 != null) ? input.ToString((IToken)(int_literal1.Start),(IToken)(int_literal1.Stop)) : null)))};

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
    // $ANTLR end "literal"


    // $ANTLR start "atom"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:65:1: atom returns [ExprStack stack] : (l= literal | ( LBRAC )+ (e= expr )+ RBRAC );
    public ExprStack atom() // throws RecognitionException [1]
    {   
        ExprStack stack = default(ExprStack);

        ExprStack l = default(ExprStack);

        ExprStack e = default(ExprStack);


        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:65:31: (l= literal | ( LBRAC )+ (e= expr )+ RBRAC )
            int alt9 = 2;
            int LA9_0 = input.LA(1);

            if ( (LA9_0 == MINUS_OP || LA9_0 == DIGIT) )
            {
                alt9 = 1;
            }
            else if ( (LA9_0 == LBRAC) )
            {
                alt9 = 2;
            }
            else 
            {
                NoViableAltException nvae_d9s0 =
                    new NoViableAltException("", 9, 0, input);

                throw nvae_d9s0;
            }
            switch (alt9) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:65:33: l= literal
                    {
                    	PushFollow(FOLLOW_literal_in_atom265);
                    	l = literal();
                    	state.followingStackPointer--;

                    	stack =  l;

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:65:66: ( LBRAC )+ (e= expr )+ RBRAC
                    {
                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:65:66: ( LBRAC )+
                    	int cnt7 = 0;
                    	do 
                    	{
                    	    int alt7 = 2;
                    	    int LA7_0 = input.LA(1);

                    	    if ( (LA7_0 == LBRAC) )
                    	    {
                    	        alt7 = 1;
                    	    }


                    	    switch (alt7) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:65:66: LBRAC
                    			    {
                    			    	Match(input,LBRAC,FOLLOW_LBRAC_in_atom271); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt7 >= 1 ) goto loop7;
                    		            EarlyExitException eee7 =
                    		                new EarlyExitException(7, input);
                    		            throw eee7;
                    	    }
                    	    cnt7++;
                    	} while (true);

                    	loop7:
                    		;	// Stops C# compiler whinging that label 'loop7' has no statements

                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:65:75: (e= expr )+
                    	int cnt8 = 0;
                    	do 
                    	{
                    	    int alt8 = 2;
                    	    int LA8_0 = input.LA(1);

                    	    if ( (LA8_0 == STRING_LITERAL || LA8_0 == MINUS_OP || LA8_0 == LBRAC || LA8_0 == DIGIT) )
                    	    {
                    	        alt8 = 1;
                    	    }


                    	    switch (alt8) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:65:75: e= expr
                    			    {
                    			    	PushFollow(FOLLOW_expr_in_atom277);
                    			    	e = expr();
                    			    	state.followingStackPointer--;


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

                    	Match(input,RBRAC,FOLLOW_RBRAC_in_atom281); 
                    	stack =  e;

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

    public class int_literal_return : ParserRuleReturnScope
    {
    };

    // $ANTLR start "int_literal"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:67:1: int_literal : decimal_literal ;
    public DecafParser.int_literal_return int_literal() // throws RecognitionException [1]
    {   
        DecafParser.int_literal_return retval = new DecafParser.int_literal_return();
        retval.Start = input.LT(1);

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:67:13: ( decimal_literal )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:67:16: decimal_literal
            {
            	PushFollow(FOLLOW_decimal_literal_in_int_literal292);
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:72:1: decimal_literal returns [int value] : ( '-' ( DIGIT )+ | ( DIGIT )+ );
    public int decimal_literal() // throws RecognitionException [1]
    {   
        int value = default(int);

        IToken DIGIT2 = null;
        IToken DIGIT3 = null;

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:73:2: ( '-' ( DIGIT )+ | ( DIGIT )+ )
            int alt12 = 2;
            int LA12_0 = input.LA(1);

            if ( (LA12_0 == MINUS_OP) )
            {
                alt12 = 1;
            }
            else if ( (LA12_0 == DIGIT) )
            {
                alt12 = 2;
            }
            else 
            {
                NoViableAltException nvae_d12s0 =
                    new NoViableAltException("", 12, 0, input);

                throw nvae_d12s0;
            }
            switch (alt12) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:73:4: '-' ( DIGIT )+
                    {
                    	Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_decimal_literal324); 
                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:73:8: ( DIGIT )+
                    	int cnt10 = 0;
                    	do 
                    	{
                    	    int alt10 = 2;
                    	    int LA10_0 = input.LA(1);

                    	    if ( (LA10_0 == DIGIT) )
                    	    {
                    	        alt10 = 1;
                    	    }


                    	    switch (alt10) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:73:8: DIGIT
                    			    {
                    			    	DIGIT2=(IToken)Match(input,DIGIT,FOLLOW_DIGIT_in_decimal_literal326); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt10 >= 1 ) goto loop10;
                    		            EarlyExitException eee10 =
                    		                new EarlyExitException(10, input);
                    		            throw eee10;
                    	    }
                    	    cnt10++;
                    	} while (true);

                    	loop10:
                    		;	// Stops C# compiler whinging that label 'loop10' has no statements

                    	value =  -int.Parse(((DIGIT2 != null) ? DIGIT2.Text : null));

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:74:4: ( DIGIT )+
                    {
                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:74:4: ( DIGIT )+
                    	int cnt11 = 0;
                    	do 
                    	{
                    	    int alt11 = 2;
                    	    int LA11_0 = input.LA(1);

                    	    if ( (LA11_0 == DIGIT) )
                    	    {
                    	        alt11 = 1;
                    	    }


                    	    switch (alt11) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:74:4: DIGIT
                    			    {
                    			    	DIGIT3=(IToken)Match(input,DIGIT,FOLLOW_DIGIT_in_decimal_literal334); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt11 >= 1 ) goto loop11;
                    		            EarlyExitException eee11 =
                    		                new EarlyExitException(11, input);
                    		            throw eee11;
                    	    }
                    	    cnt11++;
                    	} while (true);

                    	loop11:
                    		;	// Stops C# compiler whinging that label 'loop11' has no statements

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

 

    public static readonly BitSet FOLLOW_expr_in_prog49 = new BitSet(new ulong[]{0x0000000000001452UL});
    public static readonly BitSet FOLLOW_multExpr_in_expr68 = new BitSet(new ulong[]{0x0000000000000062UL});
    public static readonly BitSet FOLLOW_arithop_in_expr73 = new BitSet(new ulong[]{0x0000000000001470UL});
    public static readonly BitSet FOLLOW_expr_in_expr77 = new BitSet(new ulong[]{0x0000000000000062UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_expr93 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARITH_OP_in_arithop108 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_arithop114 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MULT_OP_in_multop127 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DIV_OP_in_multop138 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_REM_OP_in_multop147 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr164 = new BitSet(new ulong[]{0x0000000000000382UL});
    public static readonly BitSet FOLLOW_multop_in_multExpr169 = new BitSet(new ulong[]{0x0000000000001440UL});
    public static readonly BitSet FOLLOW_multExpr_in_multExpr173 = new BitSet(new ulong[]{0x0000000000000382UL});
    public static readonly BitSet FOLLOW_int_literal_in_literal247 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_atom265 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRAC_in_atom271 = new BitSet(new ulong[]{0x0000000000001C50UL});
    public static readonly BitSet FOLLOW_expr_in_atom277 = new BitSet(new ulong[]{0x0000000000001C50UL});
    public static readonly BitSet FOLLOW_RBRAC_in_atom281 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_decimal_literal_in_int_literal292 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_decimal_literal324 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_DIGIT_in_decimal_literal326 = new BitSet(new ulong[]{0x0000000000001002UL});
    public static readonly BitSet FOLLOW_DIGIT_in_decimal_literal334 = new BitSet(new ulong[]{0x0000000000001002UL});

}
}