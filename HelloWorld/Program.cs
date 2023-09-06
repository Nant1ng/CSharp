namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // C# Grundera

            // 1. Skriv en konsolapplikation som adderar två integer och skriver ut resultatet.
            /* 
             Console.Write("Write a integer: ");
             int num1 = Convert.ToInt16(Console.ReadLine());

             Console.Write("And one more: ");
             int num2 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine($"When you add both integers, it becomes {num1} + {num2} = {num1 + num2}");
            */

            // 2. Adderar 3 integer och dubblar resultatet innan det skrivs ut.
            /*
            Console.Write("Write a integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Another one: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("And one more: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int total = (num1 + num2 + num3)*2;

            Console.WriteLine($"When you add all the integers and double the answer, you get {total}");
            */

            // 3. Frågar efter användarens namn och sedan använder namnet för att skriva ut "Hej Richard" då man anger Johan som användarens namn.
            /*
            Console.Write("Enter your username: ");
            string? userName = Console.ReadLine();

            if (userName == "Johan") {
                Console.WriteLine("Hey Richard");
            } 
            else
            {
                Console.WriteLine($"Hello, {userName}");
            }
            */
        }
    }
}