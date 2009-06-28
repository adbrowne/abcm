using System;

namespace CFlat
{
    public class Types
    {
        private readonly int Value;
        private readonly string DisplayName;
        private readonly Type Type;

        public static readonly Types Error = new Types(-1, "Error");
        public static readonly Types Void = new Types(0, "Void");
        public static readonly Types Int = new Types(1, "Int", typeof(int));
        public static readonly Types Bool = new Types(2, "Bool", typeof(bool));
        public static readonly Types String = new Types(3, "String", typeof(string));
        public static readonly Types Char = new Types(4, "Char", typeof(char));

        private Types(int value, string displayName) : this(value, displayName, null)
        {

        }

        private Types(int value, string displayName, Type type)
        {
            Value = value;
            DisplayName = displayName;
            Type = type;
        }

        public Type ClrType
        {
            get{return Type;}
        }
    }
}