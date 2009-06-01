namespace Decaf.Tree
{
    public interface ITreeBuilder
    {
        IntegerExpression IntegerExpression(string value);
        AdditionExpression AdditionExpression(Expression expr1, Expression expr2);
        Class Class(string name);
        Method Method(string name);
        Statement Statement();
        Expression SubtractionExpression(Expression expr1, Expression expr2);
        Expression MultiplicationExpression(Expression expr1, Expression expr2);
        Expression DivisionExpression(Expression expr1, Expression expr2);
        Expression RemainderExpression(Expression expr1, Expression expr2);
        Expression CharExpression(string value);
        Expression StringExpression(string value);
        Expression IdExpression(string name);
        Expression BooleanExpression(string value);
    }
}