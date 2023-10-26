namespace StrategyCalculator
{
    public class HoldsChosenStrategy
    {
        private IStrategy? strategy;

        public void SetStrategy(IStrategy? chosenStrategy)
        {
            strategy = chosenStrategy;
        }

        public int ExecuteStrategy(int num1, int num2)
        {
            return strategy.Execute(num1, num2);
        }
    }
}
