using System;
using CFlat;

namespace CFlat.Tree
{
    public class IntegerExpression : Expression
    {
        public IntegerExpression(string value)
        {
            Value = Int32.Parse(value);
        }

        public int Value
        {
            get; private set;
        }

        public override Types Type
        {
            get { return Types.Int; }
        }

        public override void Compile(ErrorSet set, CompilerContext context)
        {
            base.Compile(set, context);
            context.CodeGenerator.ExprNumber(Value);
        }
    }
}