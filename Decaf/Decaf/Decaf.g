grammar Decaf;

options
{
    language=CSharp2;
}

prog:   expr+ ;

expr	:	 literal;

literal	:	 int_literal;

int_literal
	:	 decimal_literal;
	
decimal_literal: DIGIT+;
	
DIGIT: '0'..'9';
	 
STRING_LITERAL : '\"' .* '\"';
  
CHAR_LITERAL
	:	 '\'' + ('a'..'z'|'A'..'Z'|'0'..'9') '\'';
