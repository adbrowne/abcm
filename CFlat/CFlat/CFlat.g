grammar CFlat;

options
{
    language=CSharp2;
    output=AST;
    ASTLabelType=CommonTree;
    backtrack=true;
}

tokens {
    METHOD;
    CALL;
    PARAM;
}

@lexer::namespace {
    CFlat
}

@parser::namespace {
    CFlat
}

prog: 'public' CLASS ID '{' method* '}' -> ^(CLASS ID method*)
    ;

method	: 'public' t=ID name=ID '(' (param (',' param)*)? ')' '{' stat* '}' -> ^(METHOD $t $name param* stat*);

param	:	 t=ID n=ID -> ^(PARAM $t $n);
	
stat:   expr EOS-> expr
	|
	declaration_stmt EOS!
	|
	assignment_stmt EOS!
	|
	RETURN expr EOS -> ^(RETURN expr)
	|
	IF LBRAC expr RBRAC '{' stat* '}' -> ^(IF expr stat*)
	|
	WHILE LBRAC expr RBRAC '{' stat* '}' -> ^(WHILE expr stat*)
	|
	FOR LBRAC declaration_stmt EOS expr EOS assignment_stmt RBRAC '{' stat* '}' 
		-> ^(FOR declaration_stmt expr assignment_stmt stat*)
	;
	
declaration_stmt
	:	t=ID name=ID EQUALS expr -> ^(EQUALS ^($t $name) expr);

assignment_stmt
	:	name=ID EQUALS expr -> ^(EQUALS $name expr);
	
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
	ID '(' expr* ')' -> ^(CALL ID expr*)
	|
	ID
	;

CLASS	:	'class';

RETURN 	:	'return';

IF	: 	'if';

WHILE	:	'while';

FOR	: 	'for';

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

WS  :   (' '|'\t'|'\r'|'\n')+ { Skip(); }
    ;
