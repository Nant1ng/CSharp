namespace OvningGetNumberFromUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetNumberFromUser();

        }
        static int GetNumberFromUser()
        {
            Console.WriteLine("Give me a number between 1 & 10!");
            string? inputValue = Console.ReadLine();
            int.TryParse(inputValue, out int userNumber);

            while (userNumber < 1 || userNumber > 10)
            {
                Console.WriteLine($"You picked number {userNumber}");
                return userNumber;

            }
            return userNumber;
        }
    }
}
