using CFlat.Tree;
using NUnit.Framework;

namespace CFlat.Tests.Unit.AST
{
    [TestFixture]
    public class IfThenElseTests : AstTestBase
    {
        [Test]
        public void SimpleIfStatement()
        {
            var input = @"public class Test { public int TestMethod(){ if(true){return 3;} return 4; }}";
            var @class = GetAst(input);

            var statement = ((Class)@class)["TestMethod"].Statements[0];

            var ifStatement = (IfStatement)statement;

            // Check on the actual expression
            var testExpression = (BooleanExpression)ifStatement.Expression;
            Assert.AreEqual(true, testExpression.Value);
            
            // Check for the return statement in the body
            var returnStatement = (ReturnStatement) ifStatement.IfBody[0];
            var integerExpression = (IntegerExpression)returnStatement.Expression;
            Assert.AreEqual(3, integerExpression.Value);
        }
    }
}