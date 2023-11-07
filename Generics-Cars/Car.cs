namespace Generics_Cars
{
    public class Car
    {
        public string? Brand { get; set; }
        public Tank Fuel { get; set; } = Tank.NoFuel;

        // public Car() => Fuel = Tank.NoFuel;

        public void Refuel() => Fuel = Tank.Full;
        

        public void Driving()
        {
            if (Fuel == Tank.NoFuel)
            {
                Console.WriteLine($"Can't drive your {Brand} there is no fuel.");
            }
            else if (Fuel == Tank.Full)
            {
                Console.WriteLine($"Driving your {Brand}.");
            }
        }

    }
}
