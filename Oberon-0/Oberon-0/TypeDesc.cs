namespace Oberon_0
{
    class TypeDesc
    {
        public static TypeDesc intType = new TypeDesc {form = OsgForm.Integer, size = 4};
        public OsgForm form;
        public object fields;
        public TypeDesc @base;
        public int size, len;
    }
}