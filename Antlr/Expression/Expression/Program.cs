using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Antlr.Runtime;

namespace Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var stardardInput = Console.OpenStandardInput())
            {
                ANTLRInputStream input = new ANTLRInputStream(stardardInput);
                ExprLexer lexer = new ExprLexer(input);
                CommonTokenStream tokens = new CommonTokenStream(lexer);
                ExprParser parser = new ExprParser(tokens);
                parser.prog();
            }

            Console.ReadKey();
        }
    }
}
