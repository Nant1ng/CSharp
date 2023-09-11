namespace IFSatser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exitMenu = false;

            while (!exitMenu)
            {
                Console.Clear();

                Console.WriteLine("===================================");
                Console.WriteLine("|| Welcome, choose an exercise!  ||");
                Console.Write("||");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("          IF-SATSER            ");
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
                Console.WriteLine("||-------------------------------||");
                Console.Write("||");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" [8].");
                Console.ResetColor();
                Console.Write("        #8                ");
                Console.Write("||");
                Console.WriteLine("");
                Console.WriteLine("||-------------------------------||");
                Console.Write("||");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" [9].");
                Console.ResetColor();
                Console.Write("        #9                ");
                Console.Write("||");
                Console.WriteLine("");
                Console.WriteLine("===================================");


                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You chose Exercise 1.");
                        Console.Write("Write a number: ");
                        int num = Convert.ToInt32(Console.ReadLine());

                        if (num > 10)
                        {
                            Console.WriteLine($"The number {num} is larger than 10.");
                        }
                        else
                        {
                            Console.WriteLine($"The number {num} is less than 10.");
                        }

                        break;

                    case 2:
                        Console.WriteLine("You chose Exercise 2.");
                        Console.WriteLine("How many milk cartons are left?");
                        int milkCarton = Convert.ToInt32(Console.ReadLine());

                        if (milkCarton < 10)
                        {
                            Console.WriteLine("Order 30 more milk cartons.");
                        }
                        else if (milkCarton < 20)
                        {
                            Console.WriteLine("Order 20 more milk cartons.");
                        }
                        else
                        {
                            Console.WriteLine("You dont need to order more.");
                        }

                        break;

                    case 3:
                        Console.WriteLine("You chose Exercise 3.");
                        Console.Write("Could you tell me the temperature from the thermometer: ");
                        float temp = Convert.ToSingle(Console.ReadLine());

                        if (temp > 37.8)
                        {
                            Console.WriteLine("You have a fever.");
                        }
                        else if (temp > 39.5)
                        {
                            Console.WriteLine("You need to see a doctor.");
                        }
                        else
                        {
                            Console.WriteLine("You do not have a fever.");
                        }

                        break;

                    case 4:
                        Console.WriteLine("You chose Exercise 4.");
                        Console.WriteLine("How old are you?");
                        int age = Convert.ToInt32(Console.ReadLine());

                        if (age < 18)
                        {
                            Console.WriteLine("You are not of legal age.");
                        }
                        else if (age > 65)
                        {
                            Console.WriteLine("You are retired.");
                        }
                        else
                        {
                            Console.WriteLine("You are of legal age but not retired");
                        }

                        break;

                    case 5:
                        Console.WriteLine("You chose Exercise 5.");
                        Console.Write("Choose one of the following categories are you, Adult, Retired or Student: ");
                        string? category = Console.ReadLine();

                        // if (category is not null && category.Length > 1)
                        if (!string.IsNullOrWhiteSpace(category))
                        {
                            string answer = category.ToLower();

                            if (answer == "adult")
                            {
                                Console.WriteLine("Your trip will cost 30kr.");
                            }
                            else if (answer == "retired" || answer == "student")
                            {
                                Console.WriteLine("Your trip will cost 20kr.");
                            }
                            else { Console.WriteLine("Your answer didnt match any of the categories."); }
                        }
                        else
                        {
                            Console.WriteLine("You didnt enter a category.");
                        }

                        break;

                    case 6:
                        Console.WriteLine("You chose Exercise 6.");
                        Console.Write("Tell me your birth year: ");
                        int birthYear = Convert.ToInt32(Console.ReadLine());

                        if (birthYear >= 1980 && birthYear < 1990)
                        {
                            Console.WriteLine("Youre born in the 1980s");
                        }
                        else if (birthYear < 2000 && birthYear >= 1990)
                        {
                            Console.WriteLine("Youre bron in the 1990s");
                        }
                        else
                        {
                            Console.WriteLine("Youre not bron in the 1980s or 1990s.");
                        }

                        break;

                    case 7:
                        Console.WriteLine("You chose Exercise 7.");
                        Console.WriteLine("Tell me which country do you live in? ");
                        string? country = Console.ReadLine();

                        if (country is not null)
                        {
                            string answer = country.ToLower();
                            if (answer == "sweden" || answer == "norway" || answer == "denmark")
                            {
                                Console.WriteLine("You live in the Scandinavia.");
                            }
                            else
                            {
                                Console.WriteLine("You do not live in the Scandinavia");
                            }
                        }

                        break;

                    case 8:
                        Console.WriteLine("You chose Exercise 8.");
                        Console.WriteLine("Tell me how much money you have?");
                        decimal money = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine($"You have {money}kr, do you have a discount? yes/no");
                        string? discount = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(discount))
                        {

                            string discountValue = discount.ToLower();

                            if (discountValue == "yes")
                            {
                                if (money > 15 && money < 25)
                                {
                                    Console.WriteLine("Du kan köpa en liten hamburgare och en liten pommes.");
                                }
                                else if (money > 25 && money <= 50)
                                {
                                    Console.WriteLine("Du kan köpa en stor hamburgare och en pommes.");
                                }
                                else if (money > 60)
                                {
                                    Console.WriteLine("Du kan köpa en meal med drycka");
                                }
                                else
                                {
                                    Console.WriteLine("Tyvärr du har för lite pengar för att handla här.");
                                }
                            }
                            else
                            {
                                if (money > 15 && money < 25)
                                {
                                    Console.WriteLine("Du kan köpa en liten hamburgare.");
                                }
                                else if (money > 25 && money >= 50)
                                {
                                    Console.WriteLine("Du kan köpa en stor hamburgare.");
                                }
                                else
                                {
                                    Console.WriteLine("Tyvärr du har för lite pengar för att handla här.");
                                }
                            }
                        } else
                        {
                            Console.WriteLine("You need to answer with yes or no.");
                        }

                        break;

                    case 9:
                        Console.WriteLine("You chose Exercise 9.");

                        Console.Write("Enter the amount you have: ");
                        decimal amount = Convert.ToDecimal(Console.ReadLine());

                        ExchangeToSEK(amount);
                        break;

                    default:
                        Console.WriteLine("Invaild choice, please choose a valid exercise");
                        break;
                }

                Console.WriteLine("Press Enter to go back to the menu.");
                Console.ReadLine();
            }
        }
        static void ExchangeToSEK(decimal amount)
        {
            int[] denominations = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            Console.Write("Money Exchange: ");
            for (int i = 0; i < denominations.Length; i++)
            {
                int numNotes = (int)(amount / denominations[i]);
                if (numNotes > 0)
                {
                    amount -= numNotes * denominations[i];
                    Console.WriteLine($"{numNotes} x {denominations[i]} Kr");
                }
            }
        }
    }
}
