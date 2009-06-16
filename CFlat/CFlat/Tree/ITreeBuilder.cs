using CFlat.Tree;

namespace CFlat.Tree
{
    public interface ITreeBuilder
    {
        IntegerExpression IntegerExpression(string value);
        AdditionExpression AdditionExpression(Expression expr1, Expression expr2);
        Class Class(string name);
        Method Method(string name, string returnTypeName);
        Statement Statement(Expression e);
        Expression SubtractionExpression(Expression expr1, Expression expr2);
        Expression MultiplicationExpression(Expression expr1, Expression expr2);
        Expression DivisionExpression(Expression expr1, Expression expr2);
        Expression RemainderExpression(Expression expr1, Expression expr2);
        Expression CharExpression(string value);
        Expression StringExpression(string value);
        Expression IdExpression(string name);
        Expression BooleanExpression(string value);
        Statement DeclarationStatement(string typeName, string name, Expression expression);
        Statement ReturnStatement(Expression expression);
        Statement IfStatement(Expression expression);
        Expression RelationalExpression(string op, Expression expr1, Expression expr2);
        Expression MethodCall(string name);
    }
}