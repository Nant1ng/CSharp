namespace FactoryDesignPattern
{
    class EnemyShipFactory
    {
        public EnemyShip? MakeEnemyShip(
           string shipTypeChosen)
        {
            if (shipTypeChosen == "U")
                return new UFOEnemyShip();
            else if (shipTypeChosen == "R")
                return new RocketEnemyShip();
            else
                return null;
        }
    }

}
