tree grammar DecafTree;

options {
    language=CSharp2;
    tokenVocab=Decaf;
    ASTLabelType=CommonTree;
}

@namespace {
    Decaf
}

prog: ^('class' name=ID {CodeGenerator.StartModule($name.text);} stat* {CodeGenerator.EndModule();})
    ;
    
stat:   {CodeGenerator.BeginExpression();} e=expr {CodeGenerator.EndExpression();}
	|
	^(EQUALS ^(t=ID name=ID) {CodeGenerator.DefineVariable($name.text, $t.text); CodeGenerator.BeginExpression();} expr {CodeGenerator.EndExpression(); CodeGenerator.AssignExpression($name.text); });

expr
    :   ^('+' a=expr b=expr)       { CodeGenerator.Operation("Addition"); }
    | 	^('-' a=expr b=expr)       { CodeGenerator.Operation("Subtraction"); }
    | 	^('*' a=expr b=expr)       { CodeGenerator.Operation("Multiplication"); }
    | 	^('/' a=expr b=expr)       { CodeGenerator.Operation("Division"); }
    | 	^('%' a=expr b=expr)       { CodeGenerator.Operation("Remainder"); }
    |   STRING_LITERAL             { CodeGenerator.ExprString($STRING_LITERAL.text); }
    |	CHAR_LITERAL		   { CodeGenerator.ExprChar(char.Parse($CHAR_LITERAL.text.Replace("'",""))); }
    |   INT                        { CodeGenerator.ExprNumber(int.Parse($INT.text)); }
    |   MINUS_OP INT               { CodeGenerator.ExprNumber(-int.Parse($INT.text)); }
    |	ID			   { CodeGenerator.ExprId($ID.text); }
    |	BOOL_LITERAL		   { CodeGenerator.ExprBool(bool.Parse($BOOL_LITERAL.text)); };
