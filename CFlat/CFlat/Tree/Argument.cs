using System;

namespace CFlat.Tree
{
    public class Argument
    {
        public Argument(Types type, string name)
        {
            Type = type;
            Name = name;
        }

        public Types Type { get; set; }

        public string Name { get; set; }
    }
}