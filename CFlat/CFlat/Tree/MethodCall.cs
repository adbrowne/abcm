﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFlat.Tree
{
    public class MethodCall : Expression
    {
        public override Types Type
        {
            get { return Types.Int; }
        }

        public string Name { get; private set; }

        public List<Expression> Parameters { get; private set; }

        public MethodCall(string name)
        {
            Name = name;
            Parameters = new List<Expression>();
        }

        public override void Compile(CompilerContext context)
        {
            base.Compile(context);
            foreach (var parameter in Parameters)
            {
                parameter.Compile(context);
            }
            context.CodeGenerator.MethodCall(Name);
        }
    }
}
