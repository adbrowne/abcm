namespace Decaf
{
    public interface IGenerator
    {
        void BeginExpression();
        void ExprNumber(int i);
        void ExprAddition(int num1, int num2);
    }
}