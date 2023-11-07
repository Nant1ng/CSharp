namespace GenericsPractiseList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var intItems = new PracticeList<int>();
            var stringItems = new PracticeList<string>();

            intItems.Add(1);
            intItems.Add(11);
            intItems.Add(111);

            int[] items = intItems.GetItems();

            Console.WriteLine($"All items in the list: ");

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            stringItems.Add("W");
            stringItems.Add("A");
            stringItems.Add("S");
            stringItems.Add("D");
            stringItems.Add("Q");

            string s = stringItems.GetItem(2);

            Console.WriteLine();
            Console.WriteLine($"WA{s}D");


        }
    }
}