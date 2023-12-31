﻿using System.Diagnostics.CodeAnalysis;

namespace Conditions
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
                Console.Write("          Conditions           ");
                Console.ResetColor();
                Console.Write("||");
                Console.WriteLine();
                Console.WriteLine("===================================");
                Console.Write("||");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" [1].");
                Console.ResetColor();
                Console.Write("         1                ");
                Console.Write("||");
                Console.WriteLine("");
                Console.WriteLine("||-------------------------------||");
                Console.Write("||");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" [2].");
                Console.ResetColor();
                Console.Write("         2                ");
                Console.Write("||");
                Console.WriteLine("");
                Console.WriteLine("||-------------------------------||");
                Console.Write("||");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" [3].");
                Console.ResetColor();
                Console.Write("         3                ");
                Console.Write("||");
                Console.WriteLine("");
                Console.WriteLine("||-------------------------------||");
                Console.Write("||");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" [4].");
                Console.ResetColor();
                Console.Write("         4                ");
                Console.Write("||");
                Console.WriteLine("");
                Console.WriteLine("||-------------------------------||");
                Console.Write("||");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" [5].");
                Console.ResetColor();
                Console.Write("         5                ");
                Console.Write("||");
                Console.WriteLine("");
                Console.WriteLine("||-------------------------------||");
                Console.Write("||");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" [6].");
                Console.ResetColor();
                Console.Write("         6                ");
                Console.Write("||");
                Console.WriteLine("");
                Console.WriteLine("||-------------------------------||");
                Console.Write("||");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" [7].");
                Console.ResetColor();
                Console.Write("         7                ");
                Console.Write("||");
                Console.WriteLine("");
                Console.WriteLine("||-------------------------------||");
                Console.Write("||");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" [8].");
                Console.ResetColor();
                Console.Write("         8                ");
                Console.Write("||");
                Console.WriteLine("");
                Console.WriteLine("||-------------------------------||");
                Console.Write("||");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" [9].");
                Console.ResetColor();
                Console.Write("         9                ");
                Console.Write("||");
                Console.WriteLine("");
                Console.WriteLine("===================================");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ExerciseOne();
                        break;

                    case 2:
                        ExerciseTwo();
                        break;

                    case 3:
                        ExerciseThree();
                        break;

                    case 4:
                        ExerciseFour();
                        break;
                    case 5:
                        ExerciseFive();
                        break;
                    case 6:
                        ExerciseSix();
                        break;
                    case 7:
                        ExerciseSeven();
                        break;
                    case 8:
                        break;
                }

                Console.WriteLine("Press Enter to go back to the menu.");
                Console.ReadLine();
                Console.Clear();
            }
        }

        static void ExerciseOne()
        {
            Console.Write("Give me any number, negative or posetive: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine($"{number} is a negative number.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"{number} is a positive number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a positive or negative number.");
            }
        }

        static void ExerciseTwo()
        {
            Console.Write("Give me 2 numbers, I will compare them: ");
            string? numbers = Console.ReadLine();
            string[] number = numbers.Split(" ");
            int numberOne = Convert.ToInt32(number[0]);
            int numberTwo = Convert.ToInt32(number[1]);

            if (numberOne > numberTwo)
            {
                Console.WriteLine($"{numberOne} is bigger than {numberTwo}");
            }
            else if (numberOne < numberTwo)
            {
                Console.WriteLine($"{numberTwo} is bigger than {numberOne}");
            }
            else
            {
                Console.WriteLine(":(");
            }
        }

        static void ExerciseThree()
        {
            Console.Write("Would you like to addition or subtraction? ");
            string? chose = Console.ReadLine().ToLower();

            if (chose == "addition" || chose == "subtraction")
            {
                if (chose == "addition")
                {
                    Console.Write($"You chose {chose}. Now give me two numbers: ");
                    string? number = Console.ReadLine();
                    string[] numbers = number.Split();
                    int numberOne = Convert.ToInt32(numbers[0]);
                    int numberTwo = Convert.ToInt32(numbers[1]);

                    int sum = numberOne + numberTwo;

                    Console.WriteLine($"{numberOne} + {numberTwo} = {sum}");
                }
                else
                {
                    Console.Write($"You chose {chose}. Now give me two numbers: ");
                    string? number = Console.ReadLine();
                    string[] numbers = number.Split();
                    int numberOne = Convert.ToInt32(numbers[0]);
                    int numberTwo = Convert.ToInt32(numbers[1]);

                    int sum = numberOne - numberTwo;

                    Console.WriteLine($"{numberOne} - {numberTwo} = {sum}");
                }
            }
            else
            {
                Console.WriteLine("You need to answer with ADDITION or SUBTRACTION");
            }
        }
        static void ExerciseFour()
        {
            Console.Write("Give me one number: ");
            string? userInput = Console.ReadLine();

            if (userInput != null)
            {
                Console.Write("Another number: ");
                string? userInput2 = Console.ReadLine();

                if (userInput2 != null)
                {
                    float userValue = Convert.ToInt32(userInput);
                    float userValue2 = Convert.ToInt32(userInput2);

                    Console.WriteLine($"{userValue} / {userValue2} = {userValue / userValue2}");
                }
            }
        }
        static void ExerciseFive()
        {
            Console.Write("Give me three numbers: ");
            string? userInput = Console.ReadLine();
            if (userInput != null)
            {
                string[] numbers = userInput.Split(" ");

                if (numbers.Length == 3)
                {
                    int numberOne = Convert.ToInt32(numbers[0]);
                    int numberTwo = Convert.ToInt32(numbers[1]);
                    int numberThree = Convert.ToInt32(numbers[2]);

                    if (numberOne == numberTwo && numberTwo == numberThree)
                    {
                        Console.WriteLine(":O");
                    }
                    else
                    {
                        int largestNumber = Math.Max(numberOne, Math.Max(numberTwo, numberThree));
                        Console.WriteLine($"The largest number is {largestNumber}");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter three numbers.");
                }
            }

        }
        static void ExerciseSix()
        {
            bool acceptedInput = false;

            // Frågade ChatGPT om förbättrings möjligheter.
            const int comparisonValue = 10;

            while (!acceptedInput)
            {
                Console.Write("Give me a number: ");
                string? userInput = Console.ReadLine();
                bool intCheck = int.TryParse(userInput, out int number);


                if (userInput != null && intCheck)
                {
                    if (number > comparisonValue)
                    {
                        Console.WriteLine($"The number {number} is bigger than {comparisonValue}.");
                        acceptedInput = true;
                    }
                    else if (number < 10)
                    {
                        Console.WriteLine($"The number {number} is less than 10.");
                        acceptedInput = true;
                    }
                    else
                    {
                        Console.WriteLine($"The number {number} is equal to 10.");
                        acceptedInput = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a vaild number.");
                }
            }
        }
        static void ExerciseSeven()
        {
            bool acceptedInput = false;

            while (!acceptedInput)
            {
                Console.Write("Give me a temperature: ");
                string? userInput = Console.ReadLine();
                bool intCheck = int.TryParse(userInput, out int number);

                if (userInput != null && intCheck)
                {
                    if (number < -10)
                    {
                        Console.WriteLine("Its verry cold!");
                        acceptedInput = true;
                    }
                    else if (number > -10 && number <= -1)
                    {
                        Console.WriteLine("Its cold!");
                        acceptedInput = true;
                    }
                    else if (number >= 0 && number <= 10)
                    {
                        Console.WriteLine("Its mild!");
                        acceptedInput = true;
                    }
                    else if (number >= 11 && number <= 20)
                    {
                        Console.WriteLine("Its fine!");
                        acceptedInput = true;
                    }
                    else if (number >= 21 && number <= 30)
                    {
                        Console.WriteLine("Its hot!");
                        acceptedInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Help Im melting!");
                        acceptedInput = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a vaild number.");
                }
            }
        }
    }
}