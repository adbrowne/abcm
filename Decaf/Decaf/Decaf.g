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

prog:   ( {Generator.BeginExpression();} expr { Generator.EndExpression(); })+ ;

expr	: (((l=literal )) (b=binop e=expr  )* { Generator.ExprNumber(int.Parse($l.text)); if($b.value != null){Generator.Operation($b.value);};});

binop	returns [string value] :	 ARITH_OP {$value = "Addition";};

ARITH_OP 
	:	 '+';

literal	returns [int value]:	 int_literal { $value = int.Parse($int_literal.text);};

int_literal :	 decimal_literal;
	
decimal_literal returns [int value]
	: DIGIT+ {$value = int.Parse($DIGIT.text);};
	
DIGIT: '0'..'9';
	 
STRING_LITERAL : '\"' .* '\"';
  
CHAR_LITERAL
	:	 '\'' + ('a'..'z'|'A'..'Z'|'0'..'9') '\'';
