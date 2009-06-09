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

        public override void Compile(CompilerContext context)
        {
            base.Compile(context);

            if(Type != Expression.Type)
                context.ErrorSet.Add(new CompileError(CompileErrorType.TypeMismatch));
        }
    }
}