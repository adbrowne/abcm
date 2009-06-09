namespace CFlat
{
    public interface ICodeGenerator
    {
        void BeginExpression();
        void ExprNumber(int i);
        void Operation(Operator operation);
        void Comment(string comment);
        void EndExpression();
        void ExprString(string value);
        void ExprId(string name);
        void ExprBool(bool i);
        void ExprChar(char value);
        void MethodCall(string name);
        void BeginMethodArguments();
        void AssignExpression(string name);
        void DefineVariable(string name, string type);
        void Return(string name);
        void StartModule(string id);
        void EndModule();
        void BeginMethod(string name);
        void ReturnExpression(Types type);
        void EndMethod();
        void BeginIf();
        void EndIf();
        void Save();
        string Name { get; }
    }
}