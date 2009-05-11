grammar Decaf;

options
{
    language=CSharp2;
    output=AST;
    ASTLabelType=CommonTree;
}

@lexer::namespace {
    Decaf
}

@parser::namespace {
    Decaf
}

prog: ( stat )
    ;

stat:   expr;

expr:   multExpr (('+'^|'-'^) multExpr)*
    ;

multExpr
    :   atom (('*'|'/'|'%')^ atom)*
    ;

atom:   MINUS_OP INT
	|
	INT
	|
	LBRAC + expr + RBRAC -> expr
	|
	STRING_LITERAL
	|
	CHAR_LITERAL
	|
	BOOL_LITERAL
	|
	ID
	;

//expr: (multExpr (arithop^ expr  )*)
//	|
//       method_call;

//arithop:	 ARITH_OP | MINUS_OP;

//multop: MULT_OP	| DIV_OP | REM_OP;

//multExpr:   (atom (multop^ multExpr)*); 

ARITH_OP 
	:	 '+';

MINUS_OP:	 '-';

MULT_OP :	 '*';
DIV_OP 	:	 '/';
REM_OP 	:	'%';

//literal:	 (int_literal)
//	|
//		BOOL_LITERAL
//	|
//		CHAR_LITERAL 
//	;  

//atom: 
//	literal
//	| 
//	LBRAC + expr + RBRAC
//	|
//	STRING_LITERAL
//	|
//	id=ID
//	;

//method_call:
//	CALLOUT LBRAC STRING_LITERAL (',' callout_arg )* RBRAC
//	;
	
//callout_arg: expr;
	
//int_literal :	 decimal_literal;


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
