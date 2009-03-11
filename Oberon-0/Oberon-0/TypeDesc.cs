namespace Oberon_0
{
    class TypeDesc
    {
        public static TypeDesc intType = new TypeDesc {form = GenForms.Integer, size = 4};
        public GenForms form;
        public object fields;
        public TypeDesc @base;
        public int size, len;
    }
}