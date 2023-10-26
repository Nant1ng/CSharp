namespace StrategyExcercise
{
    public class TravelPlanner
    {
        private TravelStrategy _travelStrategy;

        public void SetTravelStrategy(TravelStrategy travelStrategy)
        {
            _travelStrategy = travelStrategy;
        }

        public void Drive(int km)
        {
            var cost = _travelStrategy.Drive(km);
            Console.WriteLine("This journey will cost: " + cost);
        }
    }
}
