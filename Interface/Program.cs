namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Wolf myWolf = new Wolf();

            Console.WriteLine(myWolf.NumberOfLegs);
            Console.WriteLine(myWolf.Bark());
            myWolf.Eat();
            myWolf.Sleep();

        }
    }
}