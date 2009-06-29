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

        [Test]
        public void SimpleForStatementTest()
        {
            var input = @"
public class Test { 
    public int TestMethod(){ 
        int a = 0;
        for(int b = 0; b < 5; b = b + 1){
            a = a + 1;
        }
        return a; 
    }
}";
            var @class = GetAst(input);

            var statement = ((Class)@class)["TestMethod"].Statements[1];

            var forStatement = (ForStatement)statement;

            // Check on the actual expression
            var testExpression = (LessThanExpression)forStatement.Expression;
            Assert.AreEqual("b", ((IdExpression)testExpression.Expr1).Name);
            Assert.AreEqual(5, ((IntegerExpression)testExpression.Expr2).Value);

            // Check for the assignment statement in the body
            var body = (AssignmentStatement)forStatement.Body[0];
            Assert.AreEqual("a", body.VariableName);

            // Check the declaration
            var declarationStatement = forStatement.Declaration;
            Assert.AreEqual("b", declarationStatement.VariableName);

            // Check the assignment
            var assignmentStatement = forStatement.Iterator;
            Assert.AreEqual("b", assignmentStatement.VariableName);
        }
    }
}