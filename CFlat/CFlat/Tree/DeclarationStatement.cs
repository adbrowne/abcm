using CFlat;

namespace CFlat.Tree
{
    public class DeclarationStatement : Statement
    {
        public DeclarationStatement(Types type, string name, Expression expression) : base(expression)
        {
            Type = type;
            VariableName = name;
        }

        public string VariableName
        { get; private set; }

        public Types Type
        {
            get; private set;
        }

        public override void Compile(ErrorSet errorSet, CompilerContext context)
        {
            base.Compile(errorSet, context);

            if(Type != Expression.Type)
                errorSet.Add(new CompileError(CompileErrorType.TypeMismatch));
        }
    }
}