namespace StrategyExcercise.Strategies
{
    public class Car : TravelStrategy
    {
        public Car()
        {
            KilometerCost = 25;
        }

        public override decimal Drive(int km)
        {
            return km * KilometerCost;
        }
    }
}
