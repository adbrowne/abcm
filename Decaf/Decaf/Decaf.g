grammar Decaf;

options
{
    language=CSharp2;
}

prog:   STRING_LITERAL+ ;

STRING_LITERAL : '\"' .* '\"';
  
CHAR_LITERAL
	:	 '\'' + ('a'..'z'|'A'..'Z'|'0'..'9') '\'';
