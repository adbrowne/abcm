using System;
using System.Reflection.Emit;

namespace CFlat.CodeGen.Clr
{
    class LocalVariable : IVariable
    {
        private LocalBuilder localBuilder;
        private MethodData methodData;
        public LocalVariable(string name, MethodData methodData, Type type)
        {
            this.methodData = methodData;
            Type = type;
            localBuilder = methodData.Builder.GetILGenerator().DeclareLocal(type);
        }

        public void PushToStack()
        {
            methodData.Builder.GetILGenerator().Emit(OpCodes.Ldloc, localBuilder.LocalIndex);
        }

        public void StoreFromStack()
        {
            methodData.Builder.GetILGenerator().Emit(OpCodes.Stloc, localBuilder.LocalIndex);
        }

        public Type ClrType
        {
            get { return Type; }
        }

        private Type Type;
    }
}