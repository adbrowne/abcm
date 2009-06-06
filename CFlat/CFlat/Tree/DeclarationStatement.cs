using CFlat;

namespace CFlat.Tree
{
    public class DeclarationStatement : Statement
    {
        public DeclarationStatement(string typeName, string name, Expression expression) : base(expression)
        {
            switch (typeName)
            {
                case "int":
                    Type = Types.Int;
                    break;
                case "string":
                    Type = Types.String;
                    break;
                case "char":
                    Type = Types.Char;
                    break;
                case "bool":
                    Type = Types.Bool;
                    break;
            }

            VariableName = name;
        }

        public string VariableName
        { get; private set; }

        public Types Type
        {
            get; private set;
        }

        public override void Compile(ErrorSet errorSet)
        {
            base.Compile(errorSet);

            if(Type != Expression.Type)
                errorSet.Add(new CompileError(CompileErrorType.TypeMismatch));
        }
    }
}