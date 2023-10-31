namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> Add = (x, y) => x + y;
            Console.WriteLine(Add(11, 9));

            Func<int, bool> IsOdd = x => x % 2 != 0;
            Console.WriteLine(IsOdd(11));

            Action<string> PrintMessage = x => Console.WriteLine(x);
            PrintMessage("Hhhhaaayyyeee");

            Func<double, double> CalculateCircleArea = radius => Math.PI * radius * radius;
            Console.WriteLine(CalculateCircleArea(11));

            Func<string, string, string> GetFullName = (fName, lName) => $"{fName} {lName}";
            Console.WriteLine(GetFullName("Andrés", "Santana"));

            Func<int, int, int, int> ABC = (a, b, c) => (a * b) + c;
            Console.WriteLine(ABC(11, 9, 11));

            Console.WriteLine(ABC2(11, 9, 11));

        }

        public static int ABC2(int a, int b, int c)
        {
            int result = (a * b) + c;
            return result;
        }

    }
}