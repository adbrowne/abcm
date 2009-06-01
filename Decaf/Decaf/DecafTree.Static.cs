using Antlr.Runtime.Tree;
using Decaf.Tree;

namespace Decaf
{

    public partial class DecafTree
    {
        private ICodeGenerator CodeGenerator { get; set; }
        private ITreeBuilder TB { get; set; }
        public DecafTree(ITreeNodeStream input, ICodeGenerator codeGenerator, ErrorSet errorSet) : this(input)
        {
            CodeGenerator = codeGenerator;
            TB = new TreeBuilder();
        }
    }

}
