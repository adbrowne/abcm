// $ANTLR 3.1.2 C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g 2009-04-09 16:52:09

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
		"MULT_OP", 
		"LBRAC", 
		"RBRAC", 
		"DIGIT", 
		"STRING_LITERAL", 
		"CHAR_LITERAL"
    };

    public const int MULT_OP = 5;
    public const int STRING_LITERAL = 9;
    public const int CHAR_LITERAL = 10;
    public const int ARITH_OP = 4;
    public const int RBRAC = 7;
    public const int DIGIT = 8;
    public const int EOF = -1;
    public const int LBRAC = 6;

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

            	    if ( (LA1_0 == LBRAC || LA1_0 == DIGIT) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:16:11: e= expr
            			    {
            			    	Generator.BeginExpression();
            			    	PushFollow(FOLLOW_expr_in_prog49);
            			    	e = expr();
            			    	state.followingStackPointer--;

            			    	 GenerateExpression(e); Generator.EndExpression(); 

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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:1: expr returns [ExprStack stack] : (m= multExpr (b= ARITH_OP e= expr )* ) ;
    public ExprStack expr() // throws RecognitionException [1]
    {   
        ExprStack stack = default(ExprStack);

        IToken b = null;
        ExprStack m = default(ExprStack);

        ExprStack e = default(ExprStack);


        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:31: ( (m= multExpr (b= ARITH_OP e= expr )* ) )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:33: (m= multExpr (b= ARITH_OP e= expr )* )
            {
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:33: (m= multExpr (b= ARITH_OP e= expr )* )
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:34: m= multExpr (b= ARITH_OP e= expr )*
            	{
            		PushFollow(FOLLOW_multExpr_in_expr68);
            		m = multExpr();
            		state.followingStackPointer--;

            		// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:45: (b= ARITH_OP e= expr )*
            		do 
            		{
            		    int alt2 = 2;
            		    int LA2_0 = input.LA(1);

            		    if ( (LA2_0 == ARITH_OP) )
            		    {
            		        alt2 = 1;
            		    }


            		    switch (alt2) 
            			{
            				case 1 :
            				    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:18:46: b= ARITH_OP e= expr
            				    {
            				    	b=(IToken)Match(input,ARITH_OP,FOLLOW_ARITH_OP_in_expr73); 
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
            					stack =  new ExprStack {new OperationExprItem("Addition")};
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


    // $ANTLR start "binop"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:30:1: binop returns [string value] : ( ARITH_OP | MULT_OP );
    public string binop() // throws RecognitionException [1]
    {   
        string value = default(string);

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:30:30: ( ARITH_OP | MULT_OP )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( (LA3_0 == ARITH_OP) )
            {
                alt3 = 1;
            }
            else if ( (LA3_0 == MULT_OP) )
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
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:30:33: ARITH_OP
                    {
                    	Match(input,ARITH_OP,FOLLOW_ARITH_OP_in_binop97); 
                    	value =  "Addition";

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:30:67: MULT_OP
                    {
                    	Match(input,MULT_OP,FOLLOW_MULT_OP_in_binop103); 
                    	value =  "Multiplication";

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
    // $ANTLR end "binop"


    // $ANTLR start "multExpr"
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:32:1: multExpr returns [ExprStack stack] : (l= atom (b= MULT_OP e= multExpr )* ) ;
    public ExprStack multExpr() // throws RecognitionException [1]
    {   
        ExprStack stack = default(ExprStack);

        IToken b = null;
        ExprStack l = default(ExprStack);

        ExprStack e = default(ExprStack);


        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:32:35: ( (l= atom (b= MULT_OP e= multExpr )* ) )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:32:39: (l= atom (b= MULT_OP e= multExpr )* )
            {
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:32:39: (l= atom (b= MULT_OP e= multExpr )* )
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:32:40: l= atom (b= MULT_OP e= multExpr )*
            	{
            		PushFollow(FOLLOW_atom_in_multExpr121);
            		l = atom();
            		state.followingStackPointer--;

            		// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:32:47: (b= MULT_OP e= multExpr )*
            		do 
            		{
            		    int alt4 = 2;
            		    int LA4_0 = input.LA(1);

            		    if ( (LA4_0 == MULT_OP) )
            		    {
            		        alt4 = 1;
            		    }


            		    switch (alt4) 
            			{
            				case 1 :
            				    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:32:48: b= MULT_OP e= multExpr
            				    {
            				    	b=(IToken)Match(input,MULT_OP,FOLLOW_MULT_OP_in_multExpr126); 
            				    	PushFollow(FOLLOW_multExpr_in_multExpr130);
            				    	e = multExpr();
            				    	state.followingStackPointer--;


            				    }
            				    break;

            				default:
            				    goto loop4;
            		    }
            		} while (true);

            		loop4:
            			;	// Stops C# compiler whining that label 'loop4' has no statements

            		 
            		    
            		    	if(b == null){
            				stack =  l;
            			}
            			else{
            				stack =  new ExprStack {new OperationExprItem("Multiplication")};
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:51:1: literal returns [ExprStack stack] : ( int_literal ) ;
    public ExprStack literal() // throws RecognitionException [1]
    {   
        ExprStack stack = default(ExprStack);

        DecafParser.int_literal_return int_literal1 = default(DecafParser.int_literal_return);


        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:51:34: ( ( int_literal ) )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:51:37: ( int_literal )
            {
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:51:37: ( int_literal )
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:51:38: int_literal
            	{
            		PushFollow(FOLLOW_int_literal_in_literal179);
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:53:1: atom returns [ExprStack stack] : (l= literal | ( LBRAC )+ (e= expr )+ RBRAC );
    public ExprStack atom() // throws RecognitionException [1]
    {   
        ExprStack stack = default(ExprStack);

        ExprStack l = default(ExprStack);

        ExprStack e = default(ExprStack);


        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:53:31: (l= literal | ( LBRAC )+ (e= expr )+ RBRAC )
            int alt7 = 2;
            int LA7_0 = input.LA(1);

            if ( (LA7_0 == DIGIT) )
            {
                alt7 = 1;
            }
            else if ( (LA7_0 == LBRAC) )
            {
                alt7 = 2;
            }
            else 
            {
                NoViableAltException nvae_d7s0 =
                    new NoViableAltException("", 7, 0, input);

                throw nvae_d7s0;
            }
            switch (alt7) 
            {
                case 1 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:53:33: l= literal
                    {
                    	PushFollow(FOLLOW_literal_in_atom197);
                    	l = literal();
                    	state.followingStackPointer--;

                    	stack =  l;

                    }
                    break;
                case 2 :
                    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:53:66: ( LBRAC )+ (e= expr )+ RBRAC
                    {
                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:53:66: ( LBRAC )+
                    	int cnt5 = 0;
                    	do 
                    	{
                    	    int alt5 = 2;
                    	    int LA5_0 = input.LA(1);

                    	    if ( (LA5_0 == LBRAC) )
                    	    {
                    	        alt5 = 1;
                    	    }


                    	    switch (alt5) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:53:66: LBRAC
                    			    {
                    			    	Match(input,LBRAC,FOLLOW_LBRAC_in_atom203); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt5 >= 1 ) goto loop5;
                    		            EarlyExitException eee5 =
                    		                new EarlyExitException(5, input);
                    		            throw eee5;
                    	    }
                    	    cnt5++;
                    	} while (true);

                    	loop5:
                    		;	// Stops C# compiler whinging that label 'loop5' has no statements

                    	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:53:75: (e= expr )+
                    	int cnt6 = 0;
                    	do 
                    	{
                    	    int alt6 = 2;
                    	    int LA6_0 = input.LA(1);

                    	    if ( (LA6_0 == LBRAC || LA6_0 == DIGIT) )
                    	    {
                    	        alt6 = 1;
                    	    }


                    	    switch (alt6) 
                    		{
                    			case 1 :
                    			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:53:75: e= expr
                    			    {
                    			    	PushFollow(FOLLOW_expr_in_atom209);
                    			    	e = expr();
                    			    	state.followingStackPointer--;


                    			    }
                    			    break;

                    			default:
                    			    if ( cnt6 >= 1 ) goto loop6;
                    		            EarlyExitException eee6 =
                    		                new EarlyExitException(6, input);
                    		            throw eee6;
                    	    }
                    	    cnt6++;
                    	} while (true);

                    	loop6:
                    		;	// Stops C# compiler whinging that label 'loop6' has no statements

                    	Match(input,RBRAC,FOLLOW_RBRAC_in_atom213); 
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:55:1: int_literal : decimal_literal ;
    public DecafParser.int_literal_return int_literal() // throws RecognitionException [1]
    {   
        DecafParser.int_literal_return retval = new DecafParser.int_literal_return();
        retval.Start = input.LT(1);

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:55:13: ( decimal_literal )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:55:16: decimal_literal
            {
            	PushFollow(FOLLOW_decimal_literal_in_int_literal224);
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
    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:60:1: decimal_literal returns [int value] : ( DIGIT )+ ;
    public int decimal_literal() // throws RecognitionException [1]
    {   
        int value = default(int);

        IToken DIGIT2 = null;

        try 
    	{
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:61:2: ( ( DIGIT )+ )
            // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:61:4: ( DIGIT )+
            {
            	// C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:61:4: ( DIGIT )+
            	int cnt8 = 0;
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == DIGIT) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\data\\code\\abcm\\Decaf\\Decaf\\Decaf.g:61:4: DIGIT
            			    {
            			    	DIGIT2=(IToken)Match(input,DIGIT,FOLLOW_DIGIT_in_decimal_literal256); 

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

            	value =  int.Parse(((DIGIT2 != null) ? DIGIT2.Text : null));

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

 

    public static readonly BitSet FOLLOW_expr_in_prog49 = new BitSet(new ulong[]{0x0000000000000142UL});
    public static readonly BitSet FOLLOW_multExpr_in_expr68 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_ARITH_OP_in_expr73 = new BitSet(new ulong[]{0x0000000000000150UL});
    public static readonly BitSet FOLLOW_expr_in_expr77 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_ARITH_OP_in_binop97 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MULT_OP_in_binop103 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr121 = new BitSet(new ulong[]{0x0000000000000022UL});
    public static readonly BitSet FOLLOW_MULT_OP_in_multExpr126 = new BitSet(new ulong[]{0x0000000000000160UL});
    public static readonly BitSet FOLLOW_multExpr_in_multExpr130 = new BitSet(new ulong[]{0x0000000000000022UL});
    public static readonly BitSet FOLLOW_int_literal_in_literal179 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_atom197 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRAC_in_atom203 = new BitSet(new ulong[]{0x00000000000001C0UL});
    public static readonly BitSet FOLLOW_expr_in_atom209 = new BitSet(new ulong[]{0x00000000000001C0UL});
    public static readonly BitSet FOLLOW_RBRAC_in_atom213 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_decimal_literal_in_int_literal224 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DIGIT_in_decimal_literal256 = new BitSet(new ulong[]{0x0000000000000102UL});

}
}