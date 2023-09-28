namespace RecursionOvningFibonaccis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\x1b[6mFibonaccis\x1b[0m");

            for (int num = 0; num <= 10; num++)
            {
                Console.WriteLine(Fibonaccis(num));
            }
        }
        static int Fibonaccis(int num)
        {
            int numOne = 0;
            int numTwo = 1;
            int result = 0;

            for (int i = 1; i <= num; i++)
            {
                result = numOne + numTwo;
                numOne = numTwo;
                numTwo = result;
            }

            return result;
        }
    }
}