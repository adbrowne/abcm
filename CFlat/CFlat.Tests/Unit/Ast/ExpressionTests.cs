using CFlat.Tree;
using NUnit.Framework;

namespace CFlat.Tests.Unit.AST
{
    [TestFixture]
    public class ExpressionTests : AstTestBase
    {
        [Test]
        public void SingleDigitExpressionTest()
        {
            var input = "9";
            var exprTree = GetExpressionTree(input);

            Assert.IsInstanceOfType(typeof(IntegerExpression), exprTree);
            var integerExpression = (IntegerExpression)exprTree;
            Assert.AreEqual(9, integerExpression.Value);
        }

        private ITreeNode GetExpressionTree(string input)
        {
            var @class = (Class)GetAst(SurroundWithProgram(input));
            var method = @class["Test"];
            return method.Statements[0].Expression;
        }

        [Test]
        public void SimpleAdditionExpressionTest()
        {
            var input = "9+8";

            var exprTree = GetExpressionTree(input);

            Assert.IsInstanceOfType(typeof(AdditionExpression), exprTree);
            var additionExpression = (AdditionExpression)exprTree;
            Assert.AreEqual(9, ((IntegerExpression)additionExpression.Expr1).Value);
            Assert.AreEqual(8, ((IntegerExpression)additionExpression.Expr2).Value);
        }

        [Test]
        public void SimpleSubtractionExpressionTest()
        {
            var input = "9-8";
            var exprTree = GetExpressionTree(input);

            Assert.IsInstanceOfType(typeof(SubtractionExpression), exprTree);
            var subtractionExpression = (SubtractionExpression)exprTree;
            Assert.AreEqual(9, ((IntegerExpression)subtractionExpression.Expr1).Value);
            Assert.AreEqual(8, ((IntegerExpression)subtractionExpression.Expr2).Value);
        }

        [Test]
        public void TwoAdditionsExpressionTest()
        {
            var input = "9+8+10";
            var exprTree = GetExpressionTree(input);

            Assert.IsInstanceOfType(typeof(AdditionExpression), exprTree);
            var additionExpression = (AdditionExpression)exprTree;

            // First node should be sub expression for 9 + 8
            Assert.IsInstanceOfType(typeof(AdditionExpression), additionExpression.Expr1);
            var subAdditionExpression = (AdditionExpression)additionExpression.Expr1;
            Assert.AreEqual(9, ((IntegerExpression)subAdditionExpression.Expr1).Value);
            Assert.AreEqual(8, ((IntegerExpression)subAdditionExpression.Expr2).Value);

            // Second node should be the 10
            Assert.AreEqual(10, ((IntegerExpression)additionExpression.Expr2).Value);
        }

        [Test]
        public void SimpleMultiplicationExpressionTest()
        {
            var input = "9*8";
            var exprTree = GetExpressionTree(input);

            Assert.IsInstanceOfType(typeof(MultiplicationExpression), exprTree);
            var multiplicationExpression = (MultiplicationExpression)exprTree;
            Assert.AreEqual(9, ((IntegerExpression)multiplicationExpression.Expr1).Value);
            Assert.AreEqual(8, ((IntegerExpression)multiplicationExpression.Expr2).Value);
        }

        [Test]
        public void SimpleDivisionExpressionTest()
        {
            var input = "9/8";
            var exprTree = GetExpressionTree(input);

            Assert.IsInstanceOfType(typeof(DivisionExpression), exprTree);
            var divisionExpression = (DivisionExpression)exprTree;
            Assert.AreEqual(9, ((IntegerExpression)divisionExpression.Expr1).Value);
            Assert.AreEqual(8, ((IntegerExpression)divisionExpression.Expr2).Value);
        }

        [Test]
        public void SimplerRemainderExpressionTest()
        {
            var input = "9 % 8";
            var exprTree = GetExpressionTree(input);

            Assert.IsInstanceOfType(typeof(RemainderExpression), exprTree);
            var remainderExpression = (RemainderExpression)exprTree;
            Assert.AreEqual(9, ((IntegerExpression)remainderExpression.Expr1).Value);
            Assert.AreEqual(8, ((IntegerExpression)remainderExpression.Expr2).Value);
        }

        [Test]
        public void MultiplicationPrecedenceExpressionTest()
        {
            var input = "9*8+3";
            var exprTree = GetExpressionTree(input);

            Assert.IsInstanceOfType(typeof(AdditionExpression), exprTree);
            var additionExpression = (AdditionExpression)exprTree;

            // First node should be sub expression for 9 + 8
            Assert.IsInstanceOfType(typeof(MultiplicationExpression), additionExpression.Expr1);
            var multiplicationExpression = (MultiplicationExpression)additionExpression.Expr1;
            Assert.AreEqual(9, ((IntegerExpression)multiplicationExpression.Expr1).Value);
            Assert.AreEqual(8, ((IntegerExpression)multiplicationExpression.Expr2).Value);

            // Second node should be the 10
            Assert.AreEqual(3, ((IntegerExpression)additionExpression.Expr2).Value);
        }


        [Test]
        public void MultipleMultiplicationsExpressionTest()
        {
            var input = "9*8*3";
            var exprTree = GetExpressionTree(input);

            Assert.IsInstanceOfType(typeof(MultiplicationExpression), exprTree);
            var multiplicationExpression1 = (MultiplicationExpression)exprTree;

            // First node should be sub expression for 9 + 8
            Assert.IsInstanceOfType(typeof(MultiplicationExpression), multiplicationExpression1.Expr1);
            var subMultiplicationExpression = (MultiplicationExpression)multiplicationExpression1.Expr1;
            Assert.AreEqual(9, ((IntegerExpression)subMultiplicationExpression.Expr1).Value);
            Assert.AreEqual(8, ((IntegerExpression)subMultiplicationExpression.Expr2).Value);

            // Second node should be the 10
            Assert.AreEqual(3, ((IntegerExpression)multiplicationExpression1.Expr2).Value);
        }

        [Test]
        public void UnaryMinusExpressionTest()
        {
            var input = "-9";
            var exprTree = GetExpressionTree(input);

            Assert.IsInstanceOfType(typeof(IntegerExpression), exprTree);
            var integerExpression = (IntegerExpression)exprTree;
            Assert.AreEqual(-9, integerExpression.Value);
        }

        [Test]
        public void UnaryMinusInExpressionTest()
        {
            var input = "3+-2";
            var exprTree = GetExpressionTree(input);

            Assert.IsInstanceOfType(typeof(AdditionExpression), exprTree);
            var additionExpression = (AdditionExpression)exprTree;
            Assert.AreEqual(3, ((IntegerExpression)additionExpression.Expr1).Value);
            Assert.AreEqual(-2, ((IntegerExpression)additionExpression.Expr2).Value);
        }

        [Test]
        public void BracketsExpressionTest()
        {
            var input = "(9+8)*3";
            var exprTree = GetExpressionTree(input);

            Assert.IsInstanceOfType(typeof(MultiplicationExpression), exprTree);
            var multiplicationExpression = (MultiplicationExpression)exprTree;

            // First node should be sub expression for (9 + 8)
            Assert.IsInstanceOfType(typeof(AdditionExpression), multiplicationExpression.Expr1);
            var additionExpression = (AdditionExpression)multiplicationExpression.Expr1;
            Assert.AreEqual(9, ((IntegerExpression)additionExpression.Expr1).Value);
            Assert.AreEqual(8, ((IntegerExpression)additionExpression.Expr2).Value);

            // Second node should be the 3
            Assert.AreEqual(3, ((IntegerExpression)multiplicationExpression.Expr2).Value);
        }

        [Test]
        public void StringExpressionTest()
        {
            var input = @"""test""";
            var exprTree = GetExpressionTree(input);

            Assert.IsInstanceOfType(typeof(StringExpression), exprTree);
            var stringExpression = (StringExpression)exprTree;
            Assert.AreEqual("test", stringExpression.Value);
        }

        [Test]
        public void CharExpressionTest()
        {
            var input = @"'t'";
            var exprTree = GetExpressionTree(input);

            Assert.IsInstanceOfType(typeof(CharExpression), exprTree);
            var charExpression = (CharExpression)exprTree;
            Assert.AreEqual('t', charExpression.Value);
        }

        [Test]
        public void IdExpressionTest()
        {
            var input = @"Id";
            var exprTree = GetExpressionTree(input);

            Assert.IsInstanceOfType(typeof(IdExpression), exprTree);
            var idExpression = (IdExpression)exprTree;
            Assert.AreEqual("Id", idExpression.Name);
        }

        [Test]
        public void BooleanFalseExpressionTest()
        {
            var input = "false";
            var exprTree = GetExpressionTree(input);

            Assert.IsInstanceOfType(typeof(BooleanExpression), exprTree);
            var booleanExpression = (BooleanExpression)exprTree;
            Assert.AreEqual(false, booleanExpression.Value);
        }

        [Test]
        public void BooleanTrueExpressionTest()
        {
            var input = "true";
            var exprTree = GetExpressionTree(input);

            Assert.IsInstanceOfType(typeof(BooleanExpression), exprTree);
            var booleanExpression = (BooleanExpression)exprTree;
            Assert.AreEqual(true, booleanExpression.Value);
        }

        [Test]
        public void MutiplicationRelationalPrecedenceTest()
        {
            var input = "9 * 3 < 10 + 2";
            var exprTree = GetExpressionTree(input);

            var lessThanExpression = (LessThanExpression)exprTree;
            Assert.IsInstanceOfType(typeof(MultiplicationExpression), lessThanExpression.Expr1);

            Assert.IsInstanceOfType(typeof(AdditionExpression), lessThanExpression.Expr2);

        }

        [Test]
        public void LessThanExpressionTest()
        {
            var input = "9 < 10";
            var exprTree = GetExpressionTree(input);

            var lessThanExpression = (LessThanExpression)exprTree;
            var leftSide = (IntegerExpression)lessThanExpression.Expr1;
            var rightSide = (IntegerExpression)lessThanExpression.Expr2;

            Assert.AreEqual(9, leftSide.Value);
            Assert.AreEqual(10, rightSide.Value);
        }

        [Test]
        public void GreaterThanExpressionTest()
        {
            var input = "9 > 10";
            var exprTree = GetExpressionTree(input);

            var greaterThanExpression = (GreaterThanExpression)exprTree;
            var leftSide = (IntegerExpression)greaterThanExpression.Expr1;
            var rightSide = (IntegerExpression)greaterThanExpression.Expr2;

            Assert.AreEqual(9, leftSide.Value);
            Assert.AreEqual(10, rightSide.Value);
        }

        private static string SurroundWithProgram(string s)
        {
            return "public class Test { public int Test(){" + s + ";}}";
        }
    }
}