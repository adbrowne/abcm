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
    Decaf
}


prog returns [Class c]: ^(CLASS name=ID {$c = TB.Class($name.text); CodeGenerator.StartModule($name.text);} (m=method{ $c.AddMethod(m);})*  {CodeGenerator.EndModule();})
    ;

method	returns [Method m]: ^(METHOD name=ID { CodeGenerator.BeginMethod($name.text); $m = TB.Method($name.text);} (s=stat { $m.Statements.Add(s); } )* {CodeGenerator.EndMethod();});    
	 
stat returns [Statement s]:   {CodeGenerator.BeginExpression();} e=expr { $s = TB.Statement(e); CodeGenerator.EndExpression();}
	|
	^(EQUALS ^(t=ID name=ID) {CodeGenerator.DefineVariable($name.text, $t.text); CodeGenerator.BeginExpression();} e=expr {$s = TB.DeclarationStatement($t.text, $name.text, e); CodeGenerator.EndExpression(); CodeGenerator.AssignExpression($name.text); });

expr returns [Expression e]
    :   ^('+' a=expr b=expr)       { CodeGenerator.Operation("Addition"); $e = TB.AdditionExpression(a, b);}
    | 	^('-' a=expr b=expr)       { CodeGenerator.Operation("Subtraction"); $e = TB.SubtractionExpression(a, b);}
    | 	^('*' a=expr b=expr)       { CodeGenerator.Operation("Multiplication"); $e = TB.MultiplicationExpression(a, b); }
    | 	^('/' a=expr b=expr)       { CodeGenerator.Operation("Division"); $e = TB.DivisionExpression(a, b); }
    | 	^('%' a=expr b=expr)       { CodeGenerator.Operation("Remainder"); $e = TB.RemainderExpression(a, b);}
    |   STRING_LITERAL             { CodeGenerator.ExprString($STRING_LITERAL.text); $e = TB.StringExpression($STRING_LITERAL.text);}
    |	CHAR_LITERAL		   { CodeGenerator.ExprChar(char.Parse($CHAR_LITERAL.text.Replace("'","")));  
    				     $e = TB.CharExpression($CHAR_LITERAL.text.Replace("'",""));}
    |   INT                        { CodeGenerator.ExprNumber(int.Parse($INT.text)); $e = TB.IntegerExpression($INT.text);}
    |   MINUS_OP INT               { CodeGenerator.ExprNumber(-int.Parse($INT.text)); $e = TB.IntegerExpression("-" + $INT.text);}
    |	ID			   { CodeGenerator.ExprId($ID.text); $e = TB.IdExpression($ID.text);}
    |	BOOL_LITERAL		   { CodeGenerator.ExprBool(bool.Parse($BOOL_LITERAL.text)); $e = TB.BooleanExpression($BOOL_LITERAL.text);};
