namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathDelegate mathOperation = Add;

            int a = 11;
            int b = 9;

            int result = mathOperation(a, b);

            Console.WriteLine(result);

        }
        public static int Add(int a, int b)
        {
            int results = a + b;
            return results;
        }

        public static int Subtract(int a, int b)
        {
            int results = a - b;
            return results;
        }

        public static int Power(int baseNo, int exp)
        {
            int result = (int)Math.Pow(baseNo, exp);
            return result;
        }

    }
}
