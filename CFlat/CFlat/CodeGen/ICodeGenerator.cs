using System.Reflection;

namespace CFlat.CodeGen
{
    public interface ICodeGenerator
    {
        void BeginExpression();
        void ExprNumber(int i);
        void Operation(Operator operation);
        void EndExpression();
        void ExprString(string value);
        void ExprId(string name);
        void ExprBool(bool i);
        void MethodCall(string name);
        void AssignExpression(string name);
        void DefineVariable(string name, Types type);
        void Return(string name);
        void StartModule(string id);
        void EndModule();
        void BeginMethod(string name);
        void ReturnExpression(Types type);
        void EndMethod();
        IIfToken BeginIf();
        void EndIf(IIfToken ifToken);
        Assembly Save(bool outputToFile);

        void BeginLoopBody(ILoopToken loopToken);
        void EndLoop(ILoopToken loopToken);
        ILoopToken BeginLoopExpression();
        
        void RegisterMethod(string name, Types returnType, params Parameter[] parameters);
    }
}