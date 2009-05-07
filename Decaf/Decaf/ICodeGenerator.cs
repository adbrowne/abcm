namespace Decaf
{
    public interface ICodeGenerator
    {
        void BeginExpression();
        void ExprNumber(int i);
        void Operation(string operationName);
        void Comment(string comment);
        void EndExpression();
        void ExprString(string value);
        void ExprId(string name);
        void ExprBool(bool i);
        void ExprChar(char value);
        void MethodCall(string name);
        void BeginMethodArguments();
    }
}