using CFlat.Tree;
using NUnit.Framework;

namespace CFlat.Tests.Unit.AST
{
    [TestFixture]
    public class ClassMethodStatementTests : AstTestBase
    {
        [Test]
        public void DefineIntegerWithValue()
        {
            var input = "public class Test { public int TestMethod(){ int a=9; }}";
            var @class = GetAst(input);

            var statement = ((Class) @class)["TestMethod"].Statements[0];

            var declarationStatement = (DeclarationStatement) statement;

            Assert.AreEqual("a", declarationStatement.VariableName);
            Assert.AreEqual(Types.Int, declarationStatement.Type);
            var expression = declarationStatement.Expression;

            var integerExpression = (IntegerExpression) expression;

            Assert.AreEqual(9, integerExpression.Value);
        }

        [Test]
        public void AssignValueIntegerWithValue()
        {
            var input = "public class Test { public int TestMethod(){ int a=9; a = 10;}}";
            var @class = GetAst(input);

            var statement = ((Class)@class)["TestMethod"].Statements[1];

            var assignmentStatement = (AssignmentStatement)statement;

            Assert.AreEqual("a", assignmentStatement.VariableName);
            var expression = assignmentStatement.Expression;

            var integerExpression = (IntegerExpression)expression;

            Assert.AreEqual(10, integerExpression.Value);
        }

        [Test]
        public void UseVariableInExpressionTest()
        {
            var input = @"public class Test { public int TestMethod(){ int a = 8; return 9 + a;} }";
            var @class = GetAst(input);

            var statement = (ReturnStatement)((Class)@class)["TestMethod"].Statements[1];

            var additionExpression = (AdditionExpression) statement.Expression;

            var aExpression = (IdExpression) additionExpression.Expr2;

            Assert.AreEqual("a", aExpression.Name);
        }

        [Test]
        public void VoidMethod()
        {
            var input = "public class Test { public void TestMethod(){ }}";
            var @class = GetAst(input);

            var method = ((Class)@class)["TestMethod"];

            Assert.AreEqual(Types.Void, method.ReturnType);
        }

        [Test]
        public void MethodWithReturn()
        {
            var input = "public class Test { public int TestMethod(){ return 9; }}";
            var @class = GetAst(input);

            var statement = ((Class)@class)["TestMethod"].Statements[0];

            var returnStatement = (ReturnStatement)statement;

            var expression = returnStatement.Expression;

            var integerExpression = (IntegerExpression)expression;

            Assert.AreEqual(9, integerExpression.Value);
        }

        [Test]
        public void MultipleStatementTest()
        {
            var input = @"public class Test { public int TestMethodName(){int a=9;int b=10; }}";
            var @class = GetAst(input);

            var method = ((Class)@class)["TestMethodName"];

            var declarationStatementA = (DeclarationStatement)method.Statements[0];

            Assert.AreEqual("a", declarationStatementA.VariableName);
            Assert.AreEqual(Types.Int, declarationStatementA.Type);
            var expression = declarationStatementA.Expression;

            var integerExpression = (IntegerExpression)expression;

            Assert.AreEqual(9, integerExpression.Value);

            var declarationStatementB = (DeclarationStatement)method.Statements[1];

            Assert.AreEqual("b", declarationStatementB.VariableName);
            Assert.AreEqual(Types.Int, declarationStatementB.Type);
            var expressionB = declarationStatementB.Expression;

            var integerExpressionB = (IntegerExpression)expressionB;

            Assert.AreEqual(10, integerExpressionB.Value);
        
        }

        [Test]
        public void DefineIntegerWithExpression()
        {
            var input = "public class Test { public int TestMethodName(){int a=9*2+4;} }";
            var @class = GetAst(input);

            var method = ((Class)@class)["TestMethodName"];

            var declarationStatementA = (DeclarationStatement)method.Statements[0];

            Assert.AreEqual("a", declarationStatementA.VariableName);
            Assert.AreEqual(Types.Int, declarationStatementA.Type);

            var additionExpression = (AdditionExpression)declarationStatementA.Expression;

            // First node should be sub expression for 9 * 2
            Assert.IsInstanceOfType(typeof(MultiplicationExpression), additionExpression.Expr1);
            var subMultiplicationExpression = (MultiplicationExpression)additionExpression.Expr1;
            Assert.AreEqual(9, ((IntegerExpression)subMultiplicationExpression.Expr1).Value);
            Assert.AreEqual(2, ((IntegerExpression)subMultiplicationExpression.Expr2).Value);

            // Second node should be the 4
            Assert.AreEqual(4, ((IntegerExpression)additionExpression.Expr2).Value);
        }

        [Test]
        public void DefineClass()
        {
            var input = @"public class Test {}";
            var @class = (Class) GetAst(input);
            
            Assert.AreEqual("Test", @class.Name);
        }

        [Test]
        public void DefineMethod()
        {
            var input = @"public class Test { public int TestMethodName(){} }";
            var @class = (Class)GetAst(input);

            var method = @class["TestMethodName"];
            
            Assert.AreEqual("TestMethodName", method.Name);
            Assert.AreEqual(Types.Int, method.ReturnType);
        }
    }
}