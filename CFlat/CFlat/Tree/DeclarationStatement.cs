using CFlat;

namespace CFlat.Tree
{
    public class DeclarationStatement : Statement
    {
        public DeclarationStatement(Types type, string name, Expression expression, Method method) : base(expression)
        {
            Type = type;
            VariableName = name;
            method.Variables.Add(this);
        }

        public string VariableName
        { get; private set; }

        public Types Type
        {
            get; private set;
        }

        public override void Compile(CompilerContext context)
        {
            base.Compile(context);

            if (Type != Expression.Type)
            {
                context.ErrorSet.Add(new CompileError(CompileErrorType.TypeMismatch));
                return;
            }

            context.CodeGenerator.DefineVariable(VariableName, Type);
            Expression.Compile(context);
            context.CodeGenerator.AssignExpression(VariableName);
        }
    }
}