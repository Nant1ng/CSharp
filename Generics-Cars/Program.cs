namespace Generics_Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {   new Car()
                    {
                        Brand = "Volvo",
                    },
                new Car()
                    {
                        Brand = "Volkswagen"
                    },
                new Car()
                    {
                        Brand = "Toyota"
                    },
                new Car()
                    {
                        Brand = "Ford"
                    }
            };

            cars.RemoveAt(2);
            cars.Insert(2, new Car() { Brand = "Mercedes-Benz" });

            cars[0].Driving();
            cars[0].Refuel();
            cars[0].Driving();

            cars[2].Driving();
        }
    }
}