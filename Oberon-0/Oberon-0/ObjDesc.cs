using System;
using System.Reflection.Emit;

namespace Oberon_0
{
    internal delegate void GenIlDelegate(ILGenerator ilGenerator);

    class ObjDesc
    {
        public GenType @class, lev;
        public ObjDesc next, dsc;
        public TypeDesc type;
        public string name;
        public Int64 val;
        public GenIlDelegate ILGen;
        public MethodBuilder MethodBuilder;
    }
}
