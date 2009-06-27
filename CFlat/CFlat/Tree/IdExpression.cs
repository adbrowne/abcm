using CFlat;

namespace CFlat.Tree
{
    public class IdExpression : Expression
    {
        private readonly Method Method;
        public string Name { get; private set; }

        public IdExpression(string name, Method method)
        {
            Method = method;
            Name = name;
        }

        public override Types Type
        {
            get
            {
                return Method.GetVariableType(Name);
            }
        }

        public override void Compile(CompilerContext context)
        {
            base.Compile(context);
            context.CodeGenerator.ExprId(Name);
        }
    }
}