using System;

namespace CFlat.CodeGen.Clr
{
    public interface IVariable
    {
        void PushToStack();
        void StoreFromStack();
        Type ClrType { get; }
    }
}