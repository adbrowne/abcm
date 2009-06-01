namespace Decaf.Tree
{
    public abstract class Expression : ITreeNode
    {
        public abstract Types Type { get; }
    }
}