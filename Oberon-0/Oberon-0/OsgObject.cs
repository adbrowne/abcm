using System;
using System.Reflection.Emit;

namespace Oberon_0
{
    internal delegate void GenIlDelegate(ILGenerator ilGenerator);

    class OsgObject
    {
        public OsgClassMode @class, lev;
        public OsgObject next, dsc;
        public TypeDesc type;
        public string name;
        public Int64 val;
        public GenIlDelegate ILGen;
        public MethodBuilder MethodBuilder;
    }
}
