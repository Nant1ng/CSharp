namespace Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I can convert Km to Miles.");
            Console.Write("Tell me the value you want to convert: ");

            string? inputValue = Console.ReadLine();

            float.TryParse(inputValue, out float km);

            KmConverter converter = new KmConverter(km);
            converter.ConvertedToMiles();

            Console.WriteLine($"{converter.Km}");
            Console.WriteLine($"{converter.Miles}");
        }
    }
}
