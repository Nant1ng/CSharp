namespace EnumExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool looping = true;

            while (looping)
            {
                Console.Write("Give a number between 1 and 12 and I'll tell you what month it is: ");
                string? inputValue = Console.ReadLine();

                if (int.TryParse(inputValue, out int month))
                {
                    if (month >= 1 && month <= 12)
                    {
                        EnumMonth monthEnum = (EnumMonth)month;
                        Console.WriteLine($"{month} = {monthEnum}");
                        looping = false;
                    }
                    else
                    {
                        Console.WriteLine("You need to answer with a number between 1 and 12.");
                    }
                }
                else
                {
                    Console.WriteLine("You can't answer with a letter, you need to answer with a number between 1 and 12");
                }
            }
        }
    }
}
