using System.Collections.Generic;

namespace Decaf.Tree
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
    }
}