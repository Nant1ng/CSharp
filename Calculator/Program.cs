namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me 2 numbers and separte them with ,");
            Console.Write("Numbers: ");
            string? inputValue = Console.ReadLine();

            if (inputValue != null)
            {
                string[] numbers = inputValue.Split(", ");
                float numberOne = int.Parse(numbers[0]);
                float numberTwo = int.Parse(numbers[1]);

                Console.WriteLine("Which math operation do you want to use? ");
                Console.WriteLine("+, -, *, /, %");

                string? choice = Console.ReadLine();

                if (choice != null)
                {
                    switch (choice)
                    {
                        case "+":
                            Addition(numberOne, numberTwo);
                            break;
                        case "-":
                            Subtraction(numberOne, numberTwo);
                            break;
                        case "*":
                            Multiplication(numberOne, numberTwo);
                            break;
                        case "/":
                            Division(numberOne, numberTwo);
                            break;
                        case "%":
                            Modula(numberOne, numberTwo);
                            break;
                        default:
                            Console.WriteLine($"You cant choose this operator: {choice}");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("You have to answer with a Math Operation: ");
                    Console.WriteLine("+, -, *, /, %");

                }
            }
        }
        static void Addition(float numberOne, float numberTwo)
        {
            float sum = numberOne + numberTwo;
            Console.WriteLine($"{numberOne} + {numberTwo} = {sum}");
        }
        static void Subtraction(float numberOne, float numberTwo)
        {
            float sum = numberOne - numberTwo;
            Console.WriteLine($"{numberOne} - {numberTwo} = {sum}");
        }
        static void Multiplication(float numberOne, float numberTwo)
        {
            float sum = numberOne * numberTwo;
            Console.WriteLine($"{numberOne} * {numberTwo} = {sum}");
        }
        static void Division(float numberOne, float numberTwo)
        {
            float sum = numberOne / numberTwo;
            Console.WriteLine($"{numberOne} / {numberTwo} = {sum}");
        }
        static void Modula(float numberOne, float numberTwo)
        {
            float sum = numberOne % numberTwo;
            Console.WriteLine($"{numberOne} % {numberTwo} = {sum}");
        }
    }
}