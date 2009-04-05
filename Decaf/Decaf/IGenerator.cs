namespace Decaf
{
    public interface IGenerator
    {
        void BeginExpression();
        void ExprNumber(int i);
        void Operation(string operationName);
        void Comment(string comment);
        void EndExpression();
    }
}