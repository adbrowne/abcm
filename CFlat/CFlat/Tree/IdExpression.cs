using CFlat;

namespace CFlat.Tree
{
    public class IdExpression : Expression
    {
        public string Name { get; private set; }

        public IdExpression(string name)
        {
            Name = name;
        }

        public override Types Type
        {
            get { return Types.Int; }
        }

        public override void Compile(CompilerContext context)
        {
            base.Compile(context);
            context.CodeGenerator.ExprId(Name);
        }
    }
}