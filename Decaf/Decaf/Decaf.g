grammar Decaf;

options
{
    language=CSharp2;
}

@lexer::namespace {
    Decaf
}

@parser::namespace {
    Decaf
}

prog:   ( {Generator.BeginExpression();} e=expr { GenerateExpression(e); Generator.EndExpression(); })+ ;

expr	returns [ExprStack stack]: (m=multExpr (b=ARITH_OP e=expr  )* { 
		if($b == null){
			$stack = $m.stack;
		}
		else{
			$stack = new ExprStack {new OperationExprItem("Addition")};
			$stack.Prepend($e.stack);
			$stack.Prepend($m.stack);
		}
	
	});

binop	returns [string value] :	 ARITH_OP {$value = "Addition";} | MULT_OP {$value = "Multiplication";};

multExpr returns [ExprStack stack]:   (l=atom (b=MULT_OP e=multExpr)* 
    { 
    
    	if($b == null){
		$stack = $l.stack;
	}
	else{
		$stack = new ExprStack {new OperationExprItem("Multiplication")};
		$stack.Prepend($e.stack);
		$stack.Prepend($l.stack);
	}    
    })
    ; 

ARITH_OP 
	:	 '+';

MULT_OP :	 '*';

literal	returns [ExprStack stack]:	 (int_literal { $stack = new ExprStack{ new NumericExprItem(int.Parse($int_literal.text))};});  

atom returns [ExprStack stack]: l=literal {$stack = $l.stack;} | LBRAC + e=expr + RBRAC {$stack = $e.stack;};

int_literal :	 decimal_literal;

LBRAC	:	 '(';
RBRAC 	:	 ')';
	
decimal_literal returns [int value]
	: DIGIT+ {$value = int.Parse($DIGIT.text);};
	
DIGIT: '0'..'9';
	 
STRING_LITERAL : '\"' .* '\"';
  
CHAR_LITERAL
	:	 '\'' + ('a'..'z'|'A'..'Z'|'0'..'9') '\'';
