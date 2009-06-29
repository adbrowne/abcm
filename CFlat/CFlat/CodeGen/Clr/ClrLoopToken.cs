using System.Reflection.Emit;

namespace CFlat.CodeGen.Clr
{
    public class ClrLoopToken : ILoopToken
    {
        public Label BeforeLoop { get; private set; }
        public Label AfterLoop { get; private set; }

        public ClrLoopToken(Label beforeLoop, Label afterLoop)
        {
            BeforeLoop = beforeLoop;
            AfterLoop = afterLoop;
        }
    }
}