using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFlat.Tree
{
    public class MethodCall : Expression
    {
        private readonly Class Class;
        
        public override Types Type
        {
            get { return Class[Name].ReturnType; }
        }

        public string Name { get; private set; }

        public List<Expression> Parameters { get; private set; }

        public MethodCall(string name, Class @class)
        {
            Class = @class;
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
