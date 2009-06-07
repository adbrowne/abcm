namespace CFlat
{
    public class CompilerContext
    {
        public ICodeGenerator CodeGenerator { get; private set; }
        public ErrorSet ErrorSet { get; private set; }
        public CompilerContext(ICodeGenerator codeGenerator, ErrorSet errorSet)
        {
            CodeGenerator = codeGenerator;
            ErrorSet = errorSet;
        }

        public void Save()
        {
            CodeGenerator.Save();
        }
    }
}