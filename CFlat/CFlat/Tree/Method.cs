using System.Collections.Generic;
using CFlat;

namespace CFlat.Tree
{
    public class Method
    {
        public string Name { get; private set; }

        public Method(string name, Types returnType)
        {
            Name = name;
            ReturnType = returnType;
            Statements = new List<Statement>();
        }

        public List<Statement> Statements { get; private set; }

        public Types ReturnType
        {
            get; private set;
        }

        public void Compile(CompilerContext context)
        {
            context.CodeGenerator.BeginMethod(Name);

            foreach (var statement in Statements)
            {
                statement.Compile(context);
            }

            context.CodeGenerator.EndMethod();
        }
    }
}