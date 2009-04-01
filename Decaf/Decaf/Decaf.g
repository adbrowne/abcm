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

prog:   expr+ ;

expr	:	 (literal) (binop expr)*;

binop	:	 ARITH_OP{ Generator.Operator($ARITH_OP.text);};

ARITH_OP 
	:	 '+';

literal	:	 int_literal;

int_literal :	 decimal_literal { Generator.OutputDigit($decimal_literal.value);};
	
decimal_literal returns [int value]
	: DIGIT+ {$value = int.Parse($DIGIT.text);};
	
DIGIT: '0'..'9';
	 
STRING_LITERAL : '\"' .* '\"';
  
CHAR_LITERAL
	:	 '\'' + ('a'..'z'|'A'..'Z'|'0'..'9') '\'';
