tree grammar CFlatTree;

options {
    language=CSharp2;
    tokenVocab=CFlat;
    ASTLabelType=CommonTree;
}

@header{
using CFlat.Tree;
}
@namespace {
    CFlat
}


prog returns [Class c]: ^(CLASS name=ID {$c = TB.Class($name.text); } (m=method{ $c.AddMethod(m);})* )
    ;

method	returns [Method m]: ^(METHOD t=ID name=ID { $m = TB.Method($name.text, $t.text);} (s=stat { $m.Statements.Add(s); } )* );    
	 
stat returns [Statement s]:  e=expr { $s = TB.Statement(e); }
	|
	^(EQUALS ^(t=ID name=ID) e=expr {$s = TB.DeclarationStatement($t.text, $name.text, e); })
	|
	^(RETURN e=expr) { $s = TB.ReturnStatement(e); }
	|
	^(IF e=expr { $s = TB.IfStatement(e); } (st=stat { ((IfStatement)$s).IfBody.Add(st); })*) ;

expr returns [Expression e]
    :   ^('+' a=expr b=expr)       { $e = TB.AdditionExpression(a, b);}
    | 	^('-' a=expr b=expr)       { $e = TB.SubtractionExpression(a, b);}
    | 	^('*' a=expr b=expr)       { $e = TB.MultiplicationExpression(a, b); }
    | 	^('/' a=expr b=expr)       { $e = TB.DivisionExpression(a, b); }
    | 	^('%' a=expr b=expr)       { $e = TB.RemainderExpression(a, b);}
    |   STRING_LITERAL             { $e = TB.StringExpression($STRING_LITERAL.text);}
    |	CHAR_LITERAL		   { $e = TB.CharExpression($CHAR_LITERAL.text.Replace("'",""));}
    |   INT                        { $e = TB.IntegerExpression($INT.text);}
    |   MINUS_OP INT               { $e = TB.IntegerExpression("-" + $INT.text);}
    |	ID			   { $e = TB.IdExpression($ID.text);}
    |	BOOL_LITERAL		   { $e = TB.BooleanExpression($BOOL_LITERAL.text);};
