using Project1;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, from porject one!");
            Book myBook = new Book("Harry Potter", "JK");
            Console.WriteLine(myBook);
        }
    }
}