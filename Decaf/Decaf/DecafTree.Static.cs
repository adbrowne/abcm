using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace Decaf
{

    public partial class DecafTree
    {
        private ICodeGenerator CodeGenerator { get; set; }

        public DecafTree(ITreeNodeStream input, ICodeGenerator codeGenerator) : this(input)
        {
            CodeGenerator = codeGenerator;
        }
    }

}