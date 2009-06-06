namespace CFlat
{
    public class CompilerContext
    {
        public ICodeGenerator CodeGenerator { get; private set; }
        
        public CompilerContext(ICodeGenerator codeGenerator)
        {
            CodeGenerator = codeGenerator;
        }

        public void Save()
        {
            CodeGenerator.Save();
        }
    }
}