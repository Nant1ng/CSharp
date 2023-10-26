namespace StrategyExcercise
{
    public abstract class TravelStrategy
    {
        private int _kilometerCost;

        public int KilometerCost
        {
            get { return _kilometerCost; }
            protected set { _kilometerCost = value; }
        }

        public abstract decimal Drive(int km);

    }
}
