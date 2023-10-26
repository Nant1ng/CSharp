namespace FactoryDesignPattern
{
    class EnemyShipFactory
    {
        public IEnemyShip? MakeEnemyShip(string shipTypeChosen)
        {
            if (shipTypeChosen == "U")
            {
                return new UFOEnemyShip();
            }

            else if (shipTypeChosen == "R")
            {
                return new RocketEnemyShip();
            }
            else if (shipTypeChosen == "BU")
            {
                return new BigUFOEnemyShip();
            }
            else if (shipTypeChosen == "BR")
            {
                return new BigRocketEnemyShip();
            }
            else
            {
                return null;
            }

        }
    }
}
