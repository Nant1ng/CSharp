namespace Loopar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exitMenu = false;

            while (!exitMenu)
            {

                Console.WriteLine("===================================");
                Console.WriteLine("|| Welcome, choose an exercise!  ||");
                Console.Write("||");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("           Loopar              ");
                Console.ResetColor();
                Console.Write("||");
                Console.WriteLine();
                Console.WriteLine("===================================");
                Console.Write("||");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" [1].");
                Console.ResetColor();
                Console.Write("        #1                ");
                Console.Write("||");
                Console.WriteLine("");
                Console.WriteLine("||-------------------------------||");
                Console.Write("||");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" [2].");
                Console.ResetColor();
                Console.Write("        #2                ");
                Console.Write("||");
                Console.WriteLine("");
                Console.WriteLine("||-------------------------------||");
                Console.Write("||");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" [3].");
                Console.ResetColor();
                Console.Write("        #3                ");
                Console.Write("||");
                Console.WriteLine("");
                Console.WriteLine("||-------------------------------||");
                Console.Write("||");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" [4].");
                Console.ResetColor();
                Console.Write("        #4                ");
                Console.Write("||");
                Console.WriteLine("");
                Console.WriteLine("||-------------------------------||");
                Console.Write("||");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" [5].");
                Console.ResetColor();
                Console.Write("        #5                ");
                Console.Write("||");
                Console.WriteLine("");
                Console.WriteLine("||-------------------------------||");
                Console.Write("||");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" [6].");
                Console.ResetColor();
                Console.Write("        #6                ");
                Console.Write("||");
                Console.WriteLine("");
                Console.WriteLine("||-------------------------------||");
                Console.Write("||");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" [7].");
                Console.ResetColor();
                Console.Write("        #7                ");
                Console.Write("||");
                Console.WriteLine("");
                Console.WriteLine("===================================");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());



                switch (choice)
                {
                    case 1:
                        for (int i = 0; i <= 10; i++)
                        {
                            Console.WriteLine(i);
                        }
                        break;

                    case 2:
                        Console.Write("Give me two numbers: ");
                        string? number = Console.ReadLine();
                        string[] numbers = number.Split(" ");
                        int num1 = Convert.ToInt32(numbers[0]);
                        int num2 = Convert.ToInt32(numbers[1]);

                        for (int i = ++num1; i < num2; i++)
                        {
                            Console.WriteLine(i);
                        }
                        break;

                    case 3:
                        bool tryAgain = true;

                        while (tryAgain)
                        {
                            Console.WriteLine("Give me two numbers: ");
                            string? number2 = Console.ReadLine();

                            if (number2 != null)
                            {
                                string[] numbers2 = number2.Split(" ");
                                int numberOne = Convert.ToInt32(numbers2[0]);
                                int numberTwo = Convert.ToInt32(numbers2[1]);
                                int sum = numberOne + numberTwo;

                                Console.WriteLine($"{numberOne} + {numberTwo} = {sum}");
                                Console.WriteLine("Would you like to do it again? (Y/N)");

                                bool answer = false;
                                while (!answer)
                                {
                                    string? response = Console.ReadLine();

                                    if (!string.IsNullOrWhiteSpace(response))
                                    {
                                        response = response.ToUpper();

                                        if (response == "Y")
                                        {
                                            answer = true;

                                        }
                                        else if (response == "N")
                                        {
                                            answer = true;
                                            tryAgain = false;

                                        }
                                        else
                                        {
                                            Console.WriteLine("You need to answer with Y or N.");
                                        }
                                    }
                                }
                            }

                        }

                        break;

                    case 4:
                        int total = 0;

                        Console.WriteLine("Give me 10 different numbers: ");

                        for (int i = 1; i <= 10; i++)
                        {
                            Console.Write($"Number {i}: ");

                            int num = int.Parse(Console.ReadLine());
                            total += num;

                        }
                        Console.WriteLine($"The total of all is: {total}");

                        break;

                    case 5:
                        Console.Write("Give me a number: ");
                        int countDownNum = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"Now I will count down from {countDownNum} to 1");
                        for (int i = countDownNum; i > 0; i--)
                        {
                            Console.WriteLine(i);
                        }

                        break;

                    case 6:
                        List<int> tempList = new List<int> { 20, 25, 23, 21, 20 };

                        int last = tempList[tempList.Count - 1];
                        int secondLast = tempList[tempList.Count - 2];
                        int earliest = tempList[tempList.Count - 3];

                        int meanValue = (last + secondLast + earliest) / 3;

                        Console.WriteLine($"({last} + {secondLast} + {earliest}) / 3 = {meanValue}");

                        break;

                    case 7:
                        Console.WriteLine("Rolling the dices...");
                        Console.WriteLine("The Values are...");

                        //int[] dice = { 1, 2, 3, 4, 5, 6 };
                        List<int> dice = new List<int> { 1, 2, 3, 4, 5, 6 };
                        Random diceValue = new Random();

                        bool throwAgain = true;

                        while (throwAgain)
                        {
                            for (int i = 1; i <= 2; i++)
                            {
                                int value1 = diceValue.Next(0, dice.Count);

                                Console.WriteLine(value1);
                            }

                            Console.WriteLine("Do you want to play again? y/n");

                            string? yOrN = Console.ReadLine();

                            if (yOrN == "y")
                            {
                                throwAgain = true;
                            }
                            else if (yOrN == "n")
                            {
                                throwAgain = false;
                            }
                            else
                            {
                                Console.WriteLine("You need to anser y or n.");
                            }
                        }

                        break;
                }

                Console.WriteLine("Press Enter to go back to the menu.");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}