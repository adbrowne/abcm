namespace Decaf
{
    public class CompileError
    {
        public CompileError(CompileErrorType type)
        {
            Type = type;
        }

        public CompileErrorType Type {get; private set;}
    }
}