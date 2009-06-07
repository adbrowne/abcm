using System;
using System.Reflection;
using CFlat.Tests.Helper;
using NUnit.Framework;

namespace CFlat.Tests.Integration
{
    [TestFixture]
    public class IntegerExpressionTests
    {
        [Test]
        public void IntegerExpressionTest()
        {
            
            var expression = "9";
            var @return = GetResult(expression);

            
            Assert.AreEqual(9, @return);
        }

        private static int GetResult(string expression)
        {
            var input = @"public class Test { public int TestMethodName(){ return " + expression + ";} }";

            var parser = Parser.CreateParser(input);
            var @class = parser.prog();

            var assemblyName = ("Output_" + Guid.NewGuid().ToString("N") + ".exe");
            var compilerContext = new CompilerContext(new ClrCodeGenerator(assemblyName));

            @class.Compile(new ErrorSet(), compilerContext);

            compilerContext.Save();
            var outputAssembly =  Assembly.Load(compilerContext.CodeGenerator.Name);

            Type type = outputAssembly.GetType("Test");
            MethodInfo main = type.GetMethod("TestMethodName");

            return (int)main.Invoke(null, null);
        }
    }
}