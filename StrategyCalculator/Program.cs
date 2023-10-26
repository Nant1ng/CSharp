using StrategyCalculator.MathOperations;

namespace StrategyCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HoldsChosenStrategy strategy = new HoldsChosenStrategy();

            strategy.SetStrategy(new Addition());
            Console.WriteLine("Addition: 11 + 11 = " + strategy.ExecuteStrategy(11, 11));

            strategy.SetStrategy(new Subtraction());
            Console.WriteLine("Subtraction: 99 - 11 = " + strategy.ExecuteStrategy(99, 11));

            strategy.SetStrategy(new Multiplication());
            Console.WriteLine("Multiplication: 11 * 11 = " + strategy.ExecuteStrategy(11, 11));

            strategy.SetStrategy(new Division());
            Console.WriteLine("Division: 99/11 = " + strategy.ExecuteStrategy(99, 11));

            Console.ReadLine();
        }
    }
}