using System;

namespace Oberon_0
{
    class ObjDesc
    {
        public GenType @class, lev;
        public ObjDesc next, dsc;
        public TypeDesc type;
        public string name;
        public Int64 val;
    }
}
