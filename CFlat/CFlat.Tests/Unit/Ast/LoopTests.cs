using CFlat.Tree;
using NUnit.Framework;

namespace CFlat.Tests.Unit.AST
{
    [TestFixture]
    public class LoopTests : AstTestBase
    {
        [Test]
        public void SimpleWhileStatementTest()
        {
            var input = @"
public class Test { 
    public int TestMethod(){ 
        int a = 0;
        while(a < 5){
            a = a + 1;
        }
        return a; 
    }
}";
            var @class = GetAst(input);

            var statement = ((Class)@class)["TestMethod"].Statements[1];

            var whileStatement = (WhileStatement)statement;

            // Check on the actual expression
            var testExpression = (LessThanExpression)whileStatement.Expression;
            Assert.AreEqual("a", ((IdExpression)testExpression.Expr1).Name);
            Assert.AreEqual(5, ((IntegerExpression)testExpression.Expr2).Value);

            // Check for the assignment statement in the body
            var assignmentStatement = (AssignmentStatement)whileStatement.Body[0];
            Assert.AreEqual("a", assignmentStatement.VariableName);
        }
    }
}