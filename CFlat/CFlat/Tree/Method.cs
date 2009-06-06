using System.Collections.Generic;
using CFlat;

namespace CFlat.Tree
{
    public class Method
    {
        public string Name { get; private set; }

        public Method(string name)
        {
            Name = name;
            Statements = new List<Statement>();
        }

        public List<Statement> Statements { get; private set; }

        public void Compile(ErrorSet errorSet, CompilerContext context)
        {
            context.CodeGenerator.BeginMethod(Name);

            foreach (var statement in Statements)
            {
                statement.Compile(errorSet);
            }

            context.CodeGenerator.EndMethod();
        }
    }
}