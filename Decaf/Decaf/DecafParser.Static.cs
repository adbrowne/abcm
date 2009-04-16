using Antlr.Runtime;

namespace Decaf
{

    public partial class DecafParser
    {
        private ICodeGenerator CodeGenerator { get; set; }

        public DecafParser(ITokenStream input, ICodeGenerator codeGenerator)
            : this(input)
        {
            CodeGenerator = codeGenerator;
        }

        private void GenerateExpression(ExprStack e)
        {
            foreach (var item in e)
            {
                item.Generate(CodeGenerator);
            }
        }
    }

}
