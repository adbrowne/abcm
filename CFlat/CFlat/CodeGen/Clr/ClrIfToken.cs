using System.Reflection.Emit;

namespace CFlat.CodeGen.Clr
{
    class ClrIfToken : IIfToken
    {
        public Label Label { get; private set; }
        public ClrIfToken(Label label)
        {
            Label = label;
        }
    }
}