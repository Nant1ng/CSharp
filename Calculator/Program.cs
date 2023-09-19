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
                float sum;

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
                            sum = numberOne - numberTwo;
                            Console.WriteLine($"{numberOne} - {numberTwo} = {sum}");
                            break;
                        case "*":
                            sum = numberOne * numberTwo;
                            Console.WriteLine($"{numberOne} * {numberTwo} = {sum}");
                            break;
                        case "/":
                            sum = numberOne / numberTwo;
                            Console.WriteLine($"{numberOne} / {numberTwo} = {sum}");
                            break;
                        case "%":
                            sum = numberOne % numberTwo;
                            Console.WriteLine($"{numberOne} % {numberTwo} = {sum}");
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
    }
}