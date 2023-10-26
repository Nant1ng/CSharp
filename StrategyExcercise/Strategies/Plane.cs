namespace StrategyExcercise.Strategies
{
    public class Plane : TravelStrategy
    {
        public Plane()
        {
            KilometerCost = 50;
        }
        public override decimal Drive(int km)
        {
            if (km > 1000)
                KilometerCost = 15;

            decimal cost = km * KilometerCost;
            return cost;
        }
    }
}
