using CFlat;

namespace CFlat.Tree
{
    public class IdExpression : Expression
    {
        private readonly Types type;
        public string Name { get; private set; }

        public IdExpression(string name, Types type)
        {
            Name = name;
            this.type = type;
        }

        public override Types Type
        {
            get
            {
                return type;
            }
        }

        public override void Compile(CompilerContext context)
        {
            base.Compile(context);
            context.CodeGenerator.ExprId(Name);
        }
    }
}