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

    public class BoolExprItem : ExprItem
    {
        public BoolExprItem(bool value)
        {
            Value = value;
        }

        public bool Value { get; private set; }
        public override void Generate(ICodeGenerator codeGenerator)
        {
            codeGenerator.ExprBool(Value);
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

    public class CharExprItem : ExprItem
    {
        public CharExprItem(char value)
        {
            Value = value;
        }

        public char Value
        {
            get;
            private set;
        }


        public override void Generate(ICodeGenerator codeGenerator)
        {
            codeGenerator.ExprChar(Value);
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

    public class MethodCallExprItem : ExprItem
    {
        public MethodCallExprItem(string name)
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
            codeGenerator.MethodCall(Name);
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
