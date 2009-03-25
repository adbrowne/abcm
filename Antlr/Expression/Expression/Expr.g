grammar Expr;

options
{
    language=CSharp2;
}

@header {
using System.Collections.Generic;
}

@members {
/** Map variable name to Integer object holding value */
private Dictionary<string, int> memory = new Dictionary<string, int>();
}

prog:   stat+ ;
                
stat:   expr NEWLINE {Console.WriteLine($expr.value);}
    |   ID '=' expr NEWLINE
        {memory.Add($ID.text, $expr.value);}
    |   NEWLINE
    ;

expr returns [int value]
    :   e=multExpr {$value = $e.value;}
        (   '+' e=multExpr {$value += $e.value;}
        |   '-' e=multExpr {$value -= $e.value;}
        )*
    ;

multExpr returns [int value]
    :   e=atom {$value = $e.value;} ('*' e=atom {$value *= $e.value;})*
    ; 

atom returns [int value]
    :   INT {$value = int.Parse($INT.text);}
    |   ID
        {
        int v = memory[$ID.text];
        if ( v!=null ) $value = v;
        else Console.WriteLine("undefined variable "+$ID.text);
        }
    |   '(' expr ')' {$value = $expr.value;}
    ;

ID  :   ('a'..'z'|'A'..'Z')+ ;
INT :   '0'..'9'+ ;
NEWLINE:'\r'? '\n' ;
WS  :   (' '|'\t')+ {Skip();} ;
