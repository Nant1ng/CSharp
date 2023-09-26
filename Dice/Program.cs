namespace Dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool looping = false;
            Random random = new Random();

            while (!looping)
            {
                Console.WriteLine("\x1b[6mThrow dice!\x1b[0m");
                Console.WriteLine("How many dices do you want me to throw: ");
                string? inputValue = Console.ReadLine();

                try
                {
                    int dicesToThrow = Convert.ToInt32(inputValue);
                    int totalSum = 0;

                    for (int i = 1; i <= dicesToThrow; i++)
                    {
                        int throwDice = random.Next(7);
                        totalSum += throwDice;

                        Console.Write(throwDice + " + ");

                    }

                    Console.WriteLine($"{totalSum}");
                    Console.WriteLine("If you want to throw again write yes else write quit/exit");
                    string? yesOrQuit = Console.ReadLine();

                    if (yesOrQuit == "yes" || yesOrQuit == "exit" || yesOrQuit == "quit")
                    {
                        string answer = yesOrQuit.ToLower();
                        if (yesOrQuit == "yes")
                        {
                            Console.WriteLine("Press any key to start over. ");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        else if (yesOrQuit == "exit" || yesOrQuit == "quit")
                        {
                            Console.Clear();
                            Console.WriteLine("Press any key to close the program.");
                            Console.WriteLine("Bye!");
                            Console.ReadKey();
                            break;

                        }
                    }
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine($"Error: {e.Message}");

                }
            }
        }
    }
}
