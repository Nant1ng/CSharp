using SuperDuperClassLibrary;

namespace ECommerce
{
    public class App
    {
        public static void Run()
        {
            var nameService = new NameService();
            while (true)
            {
                Console.Write("Ange id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                var name = nameService.GetName(id);
                Console.WriteLine($"Name: {name}");
                Console.WriteLine();

            }
        }
    }
}
