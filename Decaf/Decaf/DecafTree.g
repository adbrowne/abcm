tree grammar DecafTree;

options {
    language=CSharp2;
    tokenVocab=Decaf;
    ASTLabelType=CommonTree;
}

@namespace {
    Decaf
}

prog:   stat*
    ;
    
stat:   {CodeGenerator.BeginExpression();} e=expr {CodeGenerator.EndExpression();};

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
