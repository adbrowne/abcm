using System;
using System.Reflection.Emit;

namespace CFlat.CodeGen.Clr
{
    public class ParameterVariable : IVariable
    {
        private readonly int Number;
        private readonly MethodData MethodData;

        public ParameterVariable(int number, MethodData methodData, Type type)
        {
            Number = number;
            Type = type;
            MethodData = methodData;
        }

        public void PushToStack()
        {
            MethodData.Builder.GetILGenerator().Emit(OpCodes.Ldarg, Number);
        }

        public void StoreFromStack()
        {
            MethodData.Builder.GetILGenerator().Emit(OpCodes.Starg, Number);
        }

        public Type ClrType
        {
            get { return Type; }
        }

        private Type Type;
    }
}