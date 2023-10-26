namespace StrategyCalculator.MathOperations
{
    public class Multiplication : IStrategy
    {
        public int Execute(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }
    }
}
