namespace FactoryDesignPattern
{
    public interface IEnemyShip
    {
        string Name { get; set; }
        double AmtDamage { get; set; }
        int Hp { get; set; }
        void FollowHeroShip();
        void DisplayEnemyShip();
        void EnemyShipShoots();
        void ShipTakesDamage(int dmg);

        //abstract class EnemyShip
        //{
        //    public string? Name { get; set; }
        //    public double AmtDamage { get; set; }
        //    public void FollowHeroShip()
        //    {
        //        Console.WriteLine(
        //           Name + " Following the Hero Ship");
        //    }
        //    public void DisplayEnemyShip()
        //    {
        //        Console.WriteLine(
        //           Name + " is on the screen");
        //    }
        //    public void EnemyShipShoots()
        //    {
        //        Console.WriteLine(
        //           Name + " attacks and does "
        //           + AmtDamage + " damage");
        //    }
        //}
    }
}
