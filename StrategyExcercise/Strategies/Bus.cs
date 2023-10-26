namespace StrategyExcercise.Strategies
{
    public class Bus : TravelStrategy
    {
        public Bus()
        {
            KilometerCost = 15;
        }

        public override decimal Drive(int km)
        {
            return (km * KilometerCost) * .9m;
        }
    }
}
