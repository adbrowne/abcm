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

// Alter code generation so catch-clauses get replace with
// this action.
@rulecatch {
catch (RecognitionException) {
throw;
}
}

prog returns [Class c]: ^(CLASS name=ID {$c = TB.Class($name.text); } (m=method{ $c.AddMethod(m);})* )
    ;

method	returns [Method m]: ^(METHOD t=ID name=ID { $m = TB.Method($name.text, $t.text); } (p=param {$m.Arguments.Add(p); })* (s=stat { $m.Statements.Add(s); } )* );    

param returns [Argument a]:
	^(PARAM t=ID n=ID) { $a = TB.Argument($t.text, $n.text); }
	;
stat returns [Statement s]:  e=expr { $s = TB.Statement(e); }
	|
	^(EQUALS ^(t=ID name=ID) e=expr {$s = TB.DeclarationStatement($t.text, $name.text, e); })
	|
	^(EQUALS name=ID e=expr) {$s = TB.AssignmentStatement($name.text, e); }
	|
	^(RETURN e=expr) { $s = TB.ReturnStatement(e); }
	|
	^(IF e=expr { $s = TB.IfStatement(e); } (st=stat { ((IfStatement)$s).IfBody.Add(st); })*) 
	|
	^(WHILE e=expr { $s = TB.WhileStatement(e); } (st=stat { ((WhileStatement)$s).Body.Add(st); })*) 
	;

expr returns [Expression e]
    :   ^('+' a=expr b=expr)       { $e = TB.AdditionExpression(a, b);}
    | 	^('-' a=expr b=expr)       { $e = TB.SubtractionExpression(a, b);}
    | 	^('*' a=expr b=expr)       { $e = TB.MultiplicationExpression(a, b); }
    | 	^('/' a=expr b=expr)       { $e = TB.DivisionExpression(a, b); }
    | 	^('%' a=expr b=expr)       { $e = TB.RemainderExpression(a, b);}
    |	^(REL_OP a=expr b=expr)	   { $e = TB.RelationalExpression($REL_OP.text,a,b);}
    |   STRING_LITERAL             { $e = TB.StringExpression($STRING_LITERAL.text);}
    |	CHAR_LITERAL		   { $e = TB.CharExpression($CHAR_LITERAL.text.Replace("'",""));}
    |   INT                        { $e = TB.IntegerExpression($INT.text);}
    |   MINUS_OP INT               { $e = TB.IntegerExpression("-" + $INT.text);}
    |	ID			   { $e = TB.IdExpression($ID.text);}
    |	BOOL_LITERAL		   { $e = TB.BooleanExpression($BOOL_LITERAL.text);}
    |	^(CALL n=ID)		   { $e = TB.MethodCall($n.text);};
