namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string charles = "Charles";
            var newKing = new King(charles);

            Console.WriteLine(newKing.Title);

        }
    }
}
