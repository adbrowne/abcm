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
        public abstract void Generate(ICodeGenerator codeGenerator);
    }

    public class OperationExprItem :ExprItem
    {
        public OperationExprItem(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
        public override void Generate(ICodeGenerator codeGenerator)
        {
            codeGenerator.Operation(Name);
        }
    }

    public class StringExprItem :ExprItem
    {
        public StringExprItem(string value)
        {
            Value = value;
        }

        public string Value
        {
            get; private set;
        }


        public override void Generate(ICodeGenerator codeGenerator)
        {
            codeGenerator.ExprString(Value);
        }
    }

    public class IdExprItem : ExprItem
    {
        public IdExprItem(string name)
        {
            Name = name;
        }

        public string Name
        {
            get;
            private set;
        }


        public override void Generate(ICodeGenerator codeGenerator)
        {
            codeGenerator.ExprId(Name);
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

        public override void Generate(ICodeGenerator codeGenerator)
        {
            codeGenerator.ExprNumber(Value);
        }
    }
}
