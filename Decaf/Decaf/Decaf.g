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

prog:   ( {CodeGenerator.BeginExpression();} e=expr { GenerateExpression(e); CodeGenerator.EndExpression(); })+ ;

expr	returns [ExprStack stack]: (m=multExpr (b=arithop e=expr  )* { 
		if($b.value == null){
			$stack = $m.stack;
		}
		else{
			$stack = new ExprStack {new OperationExprItem($b.value)};
			$stack.Prepend($e.stack);
			$stack.Prepend($m.stack);
		}
	
	})
	;

arithop	returns [string value] :	 ARITH_OP {$value = "Addition";} | MINUS_OP{$value = "Subtraction";};

multop	returns [string value] : MULT_OP { $value = "Multiplication"; } 
				| DIV_OP{$value = "Division";}
				| REM_OP{$value = "Remainder";};

multExpr returns [ExprStack stack]:   (l=atom (b=multop e=multExpr)* 
    { 
    
    	if($b.value == null){
		$stack = $l.stack;
	}
	else{
		$stack = new ExprStack {new OperationExprItem($b.value)};
		$stack.Prepend($e.stack);
		$stack.Prepend($l.stack);
	}    
    })
    ; 

ARITH_OP 
	:	 '+';

MINUS_OP:	 '-';

MULT_OP :	 '*';
DIV_OP 	:	 '/';
REM_OP 	:	'%';

literal	returns [ExprStack stack]:	 (int_literal { $stack = new ExprStack{ new NumericExprItem(int.Parse($int_literal.text))};})
	|
	b=BOOL_LITERAL {$stack = new ExprStack{ new BoolExprItem(bool.Parse($b.text))};}
	|
	c=CHAR_LITERAL {$stack = new ExprStack{ new CharExprItem(char.Parse($c.text.Replace("'","")))};}
	;  

atom returns [ExprStack stack]: 
	l=literal {$stack = $l.stack;} 
	| 
	LBRAC + e=expr + RBRAC {$stack = $e.stack;}
	|
	s=STRING_LITERAL{
		$stack = new ExprStack{ new StringExprItem($s.text)};
	}
	|
	id=ID{
		$stack = new ExprStack{ new IdExprItem($id.text)};
	}
	;

int_literal :	 decimal_literal;

BOOL_LITERAL
	:	'true' | 'false';
		 
LBRAC	:	 '(';
RBRAC 	:	 ')';

ID	:	ALPHA ALPHA_NUM*;

fragment ALPHA_NUM
	:	 ALPHA | DIGIT;

fragment ALPHA 	:	'a'..'z' | 'A'..'Z' | '_' | '.';
		
decimal_literal returns [int value]
	: '-' DIGIT+ {$value = -int.Parse($DIGIT.text);}
	| DIGIT+ {$value = int.Parse($DIGIT.text);};
	
DIGIT: '0'..'9';
	 
STRING_LITERAL : '\"' .* '\"';
  
CHAR_LITERAL
	:	 '\'' + ('a'..'z'|'A'..'Z'|'0'..'9') '\'';
