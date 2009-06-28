using System.Collections.Generic;
using System.Reflection.Emit;

namespace CFlat.CodeGen.Clr
{
    public class MethodData
    {
        public MethodBuilder Builder { get; private set; }
        public Dictionary<string, IVariable> Varables { get; private set; }

        public Types ReturnType { get; private set; }

        public MethodData(MethodBuilder builder, Types returnType, Dictionary<string, IVariable> varables)
        {
            Builder = builder;
            ReturnType = returnType;
            Varables = varables;
        }
    }
}