using System.Reflection.Emit;

namespace CFlat.CodeGen.Clr
{
    public class ClrWhileToken : IWhileToken
    {
        public Label BeforeWhile { get; private set; }
        public Label AfterWhile { get; private set; }

        public ClrWhileToken(Label beforeWhile, Label afterWhile)
        {
            BeforeWhile = beforeWhile;
            AfterWhile = afterWhile;
        }
    }
}