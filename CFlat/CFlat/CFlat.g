grammar CFlat;

options
{
    language=CSharp2;
    output=AST;
    ASTLabelType=CommonTree;
}

tokens {
    METHOD;
}

@lexer::namespace {
    CFlat
}

@parser::namespace {
    CFlat
}

prog: 'public' CLASS ID '{' method* '}' -> ^(CLASS ID method*)
    ;

method	: 'public' t=ID name=ID '(){' stat* '}' -> ^(METHOD $t $name stat*);

stat:   expr EOS-> expr
	|
	t=ID name=ID EQUALS expr EOS -> ^(EQUALS ^($t $name) expr)
	|
	RETURN expr EOS -> ^(RETURN expr)
	|
	IF LBRAC expr RBRAC '{' stat* '}' -> ^(IF expr stat*);

expr	:	additive_expr (REL_OP^ additive_expr)*;

additive_expr:   multExpr 
(('+'^|'-'^) multExpr)*
    ;

multExpr
    :   atom (('*'|'/'|'%')^ atom)*
    ;

atom:   MINUS_OP INT
	|
	INT
	|
	LBRAC expr RBRAC -> expr
	|
	STRING_LITERAL
	|
	CHAR_LITERAL
	|
	BOOL_LITERAL
	|
	ID
	;

CLASS	:	'class';

RETURN 	:	'return';

IF	: 	'if';

ARITH_OP 
	:	 '+';

MINUS_OP:	 '-';

MULT_OP :	 '*';
DIV_OP 	:	 '/';
REM_OP 	:	'%';

REL_OP	:	'<' | '>';

EQUALS 	:	'=';

EOS	:	';';

CALLOUT	:	'callout';

BOOL_LITERAL
	:	'true' | 'false';
		 
LBRAC	:	 '(';
RBRAC 	:	 ')';

ID	:	ALPHA ALPHA_NUM*;

fragment ALPHA_NUM
	:	 ALPHA | INT;

fragment ALPHA 	:	'a'..'z' | 'A'..'Z' | '_' | '.';
	
INT :   '0'..'9'+
    ;
		 
STRING_LITERAL : '\"' .* '\"';
  
CHAR_LITERAL
	:	 '\'' + ('a'..'z'|'A'..'Z'|'0'..'9') '\'';

WS  :   (' '|'\t')+ { Skip(); }
    ;
