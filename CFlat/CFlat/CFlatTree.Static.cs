using Antlr.Runtime.Tree;
using CFlat.Tree;

namespace CFlat
{

    public partial class CFlatTree
    {
        private ICodeGenerator CodeGenerator { get; set; }
        private ITreeBuilder TB { get; set; }
        public CFlatTree(ITreeNodeStream input, ICodeGenerator codeGenerator, ErrorSet errorSet)
            : this(input)
        {
            CodeGenerator = codeGenerator;
            TB = new TreeBuilder();
        }
    }

}
