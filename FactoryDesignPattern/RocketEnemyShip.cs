﻿namespace FactoryDesignPattern
{
    class RocketEnemyShip : IEnemyShip
    {
        public string Name { get; set; }
        public double AmtDamage { get; set; }
        public int Hp { get; set; }

        public RocketEnemyShip()
        {
            Name = "Rocket Enemy Ship";
            AmtDamage = 10.0;
            Hp = 100;
        }

        public void FollowHeroShip()
        {
            Console.WriteLine(Name + " following the Hero Ship");
        }

        public void DisplayEnemyShip()
        {
            Console.WriteLine(Name + " is on the screen");
        }

        public void EnemyShipShoots()
        {
            Console.WriteLine(Name + " attacks and does " + AmtDamage + " damage");
        }

        public void ShipTakesDamage(int dmg)
        {
            Hp -= dmg;

            if (Hp <= 0)
            {
                Console.WriteLine(Name + " is dead!");
            }
            else
            {
                Console.WriteLine(Name + " has " + Hp + " Hp");
            }

        }
    }
}
