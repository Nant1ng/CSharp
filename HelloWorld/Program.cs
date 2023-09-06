namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter du?");
            string? name = Console.ReadLine();
            Console.WriteLine($"Hejsan,  + {name}");

        }
    }
}