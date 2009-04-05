using Antlr.Runtime;

namespace Decaf
{

    public partial class DecafParser
    {
        private IGenerator Generator { get; set; }

        public DecafParser(ITokenStream input, IGenerator generator)
            : this(input)
        {
            Generator = generator;
        }

        private void GenerateExpression(ExprStack e)
        {
            foreach (var item in e)
            {
                item.Generate(Generator);
            }
        }
    }

}
