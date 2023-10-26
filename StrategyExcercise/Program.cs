using StrategyExcercise.Strategies;

namespace StrategyExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myTravelPlanner = new TravelPlanner();

            myTravelPlanner.SetTravelStrategy(new Bus());

            myTravelPlanner.Drive(1100);

            Console.ReadKey();

        }
    }
}