using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decaf
{
    public class ExprStack : List<ExprItem>
    {
        public void Prepend(ExprStack stack2)
        {
            this.InsertRange(0, stack2);
        }
    }

    public abstract class ExprItem
    {
        public abstract void Generate(IGenerator generator);
    }

    public class OperationExprItem :ExprItem
    {
        public OperationExprItem(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
        public override void Generate(IGenerator generator)
        {
            generator.Operation(Name);
        }
    }

    public class NumericExprItem :ExprItem
    {
        public NumericExprItem(int num)
        {
            Value = num;
        }

        public int Value
        {
            get; private set;
        }

        public override void Generate(IGenerator generator)
        {
            generator.ExprNumber(Value);
        }
    }
}
