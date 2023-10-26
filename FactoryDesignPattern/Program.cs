namespace FactoryDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a kind of enemy:");
            Console.WriteLine("U: UFO");
            Console.WriteLine("R: Rocket");
            Console.WriteLine("B: Big UFO");
            Console.WriteLine("BR: Big Rocket");
            var ship = Console.ReadLine().ToUpper();

            var myEnemyShipFactory = new EnemyShipFactory();
            var theEnemy = myEnemyShipFactory.MakeEnemyShip(ship);

            theEnemy.DisplayEnemyShip();
            theEnemy.FollowHeroShip();
            theEnemy.EnemyShipShoots();

            theEnemy.ShipTakesDamage(100);

            Console.ReadKey();
        }
    }
}