// $ANTLR 3.1.2 C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g 2009-04-18 22:57:45

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
		"ALPHA", 
		"ALPHA_NUM", 
		"DIGIT"
    };

    public const int ALPHA_NUM = 16;
    public const int MULT_OP = 6;
    public const int STRING_LITERAL = 13;
    public const int CHAR_LITERAL = 10;
    public const int DIV_OP = 7;
    public const int RBRAC = 12;
    public const int ARITH_OP = 4;
    public const int REM_OP = 8;
    public const int MINUS_OP = 5;
    public const int BOOL_LITERAL = 9;
    public const int DIGIT = 17;
    public const int ID = 14;
    public const int EOF = -1;
    public const int LBRAC = 11;
    public const int ALPHA = 15;

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

            	    if ( (LA1_0 == MINUS_OP || (LA1_0 >= BOOL_LITERAL && LA1_0 <= LBRAC) || (LA1_0 >= STRING_LITERAL && LA1_0 <= ID) || LA1_0 == DIGIT) )
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:1: expr returns [ExprStack stack] : (m= multExpr (b= arithop e= expr )* ) ;
    public ExprStack expr() // throws RecognitionException [1]
    {   
        ExprStack stack = default(ExprStack);

        ExprStack m = default(ExprStack);

        string b = default(string);

        ExprStack e = default(ExprStack);


        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:31: ( (m= multExpr (b= arithop e= expr )* ) )
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:31:1: arithop returns [string value] : ( ARITH_OP | MINUS_OP );
    public string arithop() // throws RecognitionException [1]
    {   
        string value = default(string);

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:31:32: ( ARITH_OP | MINUS_OP )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( (LA3_0 == ARITH_OP) )
            {
                alt3 = 1;
            }
            else if ( (LA3_0 == MINUS_OP) )
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
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:31:35: ARITH_OP
                    {
                    	Match(input,ARITH_OP,FOLLOW_ARITH_OP_in_arithop99); 
                    	value =  "Addition";

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:31:69: MINUS_OP
                    {
                    	Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_arithop105); 
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:33:1: multop returns [string value] : ( MULT_OP | DIV_OP | REM_OP );
    public string multop() // throws RecognitionException [1]
    {   
        string value = default(string);

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:33:31: ( MULT_OP | DIV_OP | REM_OP )
            int alt4 = 3;
            switch ( input.LA(1) ) 
            {
            case MULT_OP:
            	{
                alt4 = 1;
                }
                break;
            case DIV_OP:
            	{
                alt4 = 2;
                }
                break;
            case REM_OP:
            	{
                alt4 = 3;
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
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:33:33: MULT_OP
                    {
                    	Match(input,MULT_OP,FOLLOW_MULT_OP_in_multop118); 
                    	 value =  "Multiplication"; 

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:34:7: DIV_OP
                    {
                    	Match(input,DIV_OP,FOLLOW_DIV_OP_in_multop129); 
                    	value =  "Division";

                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:35:7: REM_OP
                    {
                    	Match(input,REM_OP,FOLLOW_REM_OP_in_multop138); 
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:37:1: multExpr returns [ExprStack stack] : (l= atom (b= multop e= multExpr )* ) ;
    public ExprStack multExpr() // throws RecognitionException [1]
    {   
        ExprStack stack = default(ExprStack);

        ExprStack l = default(ExprStack);

        string b = default(string);

        ExprStack e = default(ExprStack);


        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:37:35: ( (l= atom (b= multop e= multExpr )* ) )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:37:39: (l= atom (b= multop e= multExpr )* )
            {
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:37:39: (l= atom (b= multop e= multExpr )* )
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:37:40: l= atom (b= multop e= multExpr )*
            	{
            		PushFollow(FOLLOW_atom_in_multExpr155);
            		l = atom();
            		state.followingStackPointer--;

            		// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:37:47: (b= multop e= multExpr )*
            		do 
            		{
            		    int alt5 = 2;
            		    switch ( input.LA(1) ) 
            		    {
            		    case MULT_OP:
            		    	{
            		        alt5 = 1;
            		        }
            		        break;
            		    case DIV_OP:
            		    	{
            		        alt5 = 1;
            		        }
            		        break;
            		    case REM_OP:
            		    	{
            		        alt5 = 1;
            		        }
            		        break;

            		    }

            		    switch (alt5) 
            			{
            				case 1 :
            				    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:37:48: b= multop e= multExpr
            				    {
            				    	PushFollow(FOLLOW_multop_in_multExpr160);
            				    	b = multop();
            				    	state.followingStackPointer--;

            				    	PushFollow(FOLLOW_multExpr_in_multExpr164);
            				    	e = multExpr();
            				    	state.followingStackPointer--;


            				    }
            				    break;

            				default:
            				    goto loop5;
            		    }
            		} while (true);

            		loop5:
            			;	// Stops C# compiler whining that label 'loop5' has no statements

            		 
            		    
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:60:1: literal returns [ExprStack stack] : ( ( int_literal ) | b= BOOL_LITERAL | c= CHAR_LITERAL );
    public ExprStack literal() // throws RecognitionException [1]
    {   
        ExprStack stack = default(ExprStack);

        IToken b = null;
        IToken c = null;
        DecafParser.int_literal_return int_literal1 = default(DecafParser.int_literal_return);


        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:60:34: ( ( int_literal ) | b= BOOL_LITERAL | c= CHAR_LITERAL )
            int alt6 = 3;
            switch ( input.LA(1) ) 
            {
            case MINUS_OP:
            case DIGIT:
            	{
                alt6 = 1;
                }
                break;
            case BOOL_LITERAL:
            	{
                alt6 = 2;
                }
                break;
            case CHAR_LITERAL:
            	{
                alt6 = 3;
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
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:60:37: ( int_literal )
                    {
                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:60:37: ( int_literal )
                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:60:38: int_literal
                    	{
                    		PushFollow(FOLLOW_int_literal_in_literal238);
                    		int_literal1 = int_literal();
                    		state.followingStackPointer--;

                    		 stack =  new ExprStack{ new NumericExprItem(int.Parse(((int_literal1 != null) ? input.ToString((IToken)(int_literal1.Start),(IToken)(int_literal1.Stop)) : null)))};

                    	}


                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:62:2: b= BOOL_LITERAL
                    {
                    	b=(IToken)Match(input,BOOL_LITERAL,FOLLOW_BOOL_LITERAL_in_literal249); 
                    	stack =  new ExprStack{ new BoolExprItem(bool.Parse(((b != null) ? b.Text : null)))};

                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:64:2: c= CHAR_LITERAL
                    {
                    	c=(IToken)Match(input,CHAR_LITERAL,FOLLOW_CHAR_LITERAL_in_literal259); 
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:67:1: atom returns [ExprStack stack] : (l= literal | ( LBRAC )+ (e= expr )+ RBRAC | s= STRING_LITERAL | id= ID );
    public ExprStack atom() // throws RecognitionException [1]
    {   
        ExprStack stack = default(ExprStack);

        IToken s = null;
        IToken id = null;
        ExprStack l = default(ExprStack);

        ExprStack e = default(ExprStack);


        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:67:31: (l= literal | ( LBRAC )+ (e= expr )+ RBRAC | s= STRING_LITERAL | id= ID )
            int alt9 = 4;
            switch ( input.LA(1) ) 
            {
            case MINUS_OP:
            case BOOL_LITERAL:
            case CHAR_LITERAL:
            case DIGIT:
            	{
                alt9 = 1;
                }
                break;
            case LBRAC:
            	{
                alt9 = 2;
                }
                break;
            case STRING_LITERAL:
            	{
                alt9 = 3;
                }
                break;
            case ID:
            	{
                alt9 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d9s0 =
            	        new NoViableAltException("", 9, 0, input);

            	    throw nvae_d9s0;
            }

            switch (alt9) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:68:2: l= literal
                    {
                    	PushFollow(FOLLOW_literal_in_atom280);
                    	l = literal();
                    	state.followingStackPointer--;

                    	stack =  l;

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:70:2: ( LBRAC )+ (e= expr )+ RBRAC
                    {
                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:70:2: ( LBRAC )+
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
                    			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:70:2: LBRAC
                    			    {
                    			    	Match(input,LBRAC,FOLLOW_LBRAC_in_atom290); 

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

                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:70:11: (e= expr )+
                    	int cnt8 = 0;
                    	do 
                    	{
                    	    int alt8 = 2;
                    	    int LA8_0 = input.LA(1);

                    	    if ( (LA8_0 == MINUS_OP || (LA8_0 >= BOOL_LITERAL && LA8_0 <= LBRAC) || (LA8_0 >= STRING_LITERAL && LA8_0 <= ID) || LA8_0 == DIGIT) )
                    	    {
                    	        alt8 = 1;
                    	    }


                    	    switch (alt8) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:70:11: e= expr
                    			    {
                    			    	PushFollow(FOLLOW_expr_in_atom296);
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

                    	Match(input,RBRAC,FOLLOW_RBRAC_in_atom300); 
                    	stack =  e;

                    }
                    break;
                case 3 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:72:2: s= STRING_LITERAL
                    {
                    	s=(IToken)Match(input,STRING_LITERAL,FOLLOW_STRING_LITERAL_in_atom310); 

                    			stack =  new ExprStack{ new StringExprItem(((s != null) ? s.Text : null))};
                    		

                    }
                    break;
                case 4 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:76:2: id= ID
                    {
                    	id=(IToken)Match(input,ID,FOLLOW_ID_in_atom319); 

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

    public class int_literal_return : ParserRuleReturnScope
    {
    };

    // $ANTLR start "int_literal"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:81:1: int_literal : decimal_literal ;
    public DecafParser.int_literal_return int_literal() // throws RecognitionException [1]
    {   
        DecafParser.int_literal_return retval = new DecafParser.int_literal_return();
        retval.Start = input.LT(1);

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:81:13: ( decimal_literal )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:81:16: decimal_literal
            {
            	PushFollow(FOLLOW_decimal_literal_in_int_literal331);
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:96:1: decimal_literal returns [int value] : ( '-' ( DIGIT )+ | ( DIGIT )+ );
    public int decimal_literal() // throws RecognitionException [1]
    {   
        int value = default(int);

        IToken DIGIT2 = null;
        IToken DIGIT3 = null;

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:97:2: ( '-' ( DIGIT )+ | ( DIGIT )+ )
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
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:97:4: '-' ( DIGIT )+
                    {
                    	Match(input,MINUS_OP,FOLLOW_MINUS_OP_in_decimal_literal434); 
                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:97:8: ( DIGIT )+
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
                    			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:97:8: DIGIT
                    			    {
                    			    	DIGIT2=(IToken)Match(input,DIGIT,FOLLOW_DIGIT_in_decimal_literal436); 

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
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:98:4: ( DIGIT )+
                    {
                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:98:4: ( DIGIT )+
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
                    			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:98:4: DIGIT
                    			    {
                    			    	DIGIT3=(IToken)Match(input,DIGIT,FOLLOW_DIGIT_in_decimal_literal444); 

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

 

    public static readonly BitSet FOLLOW_expr_in_prog49 = new BitSet(new ulong[]{0x0000000000026E22UL});
    public static readonly BitSet FOLLOW_multExpr_in_expr68 = new BitSet(new ulong[]{0x0000000000000032UL});
    public static readonly BitSet FOLLOW_arithop_in_expr73 = new BitSet(new ulong[]{0x0000000000026E30UL});
    public static readonly BitSet FOLLOW_expr_in_expr77 = new BitSet(new ulong[]{0x0000000000000032UL});
    public static readonly BitSet FOLLOW_ARITH_OP_in_arithop99 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_arithop105 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MULT_OP_in_multop118 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DIV_OP_in_multop129 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_REM_OP_in_multop138 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr155 = new BitSet(new ulong[]{0x00000000000001C2UL});
    public static readonly BitSet FOLLOW_multop_in_multExpr160 = new BitSet(new ulong[]{0x0000000000026FE0UL});
    public static readonly BitSet FOLLOW_multExpr_in_multExpr164 = new BitSet(new ulong[]{0x00000000000001C2UL});
    public static readonly BitSet FOLLOW_int_literal_in_literal238 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOL_LITERAL_in_literal249 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_LITERAL_in_literal259 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_atom280 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRAC_in_atom290 = new BitSet(new ulong[]{0x0000000000027E20UL});
    public static readonly BitSet FOLLOW_expr_in_atom296 = new BitSet(new ulong[]{0x0000000000027E20UL});
    public static readonly BitSet FOLLOW_RBRAC_in_atom300 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_LITERAL_in_atom310 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_atom319 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_decimal_literal_in_int_literal331 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_OP_in_decimal_literal434 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_DIGIT_in_decimal_literal436 = new BitSet(new ulong[]{0x0000000000020002UL});
    public static readonly BitSet FOLLOW_DIGIT_in_decimal_literal444 = new BitSet(new ulong[]{0x0000000000020002UL});

}
}