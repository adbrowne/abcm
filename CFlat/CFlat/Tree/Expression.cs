using CFlat;

namespace CFlat.Tree
{
    public abstract class Expression : ITreeNode
    {
        public abstract Types Type { get; }

        public virtual void Compile(ErrorSet set, CompilerContext context)
        {
            
        }
    }
}