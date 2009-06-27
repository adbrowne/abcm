namespace CFlat
{
    public class Parameter
    {
        public Parameter(Types type, string name)
        {
            Type = type;
            Name = name;
        }

        public Types Type { get; private set; }
        public string Name { get; private set; }
    }
}