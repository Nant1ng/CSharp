namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentsInfo = "Richard, 52, Man\n" + "Linda, 47, Kvinna\n" + "Lucas, 18, Man";
            File.WriteAllText("../../../../../Files/students.csv", studentsInfo);

            string[] readInfo = File.ReadAllLines("../../../../../Files/students.csv");

            string[] values = readInfo;

            int[] evenNumbers = new int[readInfo.Length];
            int[] oddNumbers = new int[readInfo.Length];

            int evenIndex = 0;
            int oddIndex = 0;

            Console.WriteLine(values);

            //foreach (var info in readInfo)
            //{
            //    int number = int.Parse(info);
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine("These numbers are even: ");
            //        evenNumbers[evenIndex] = number;
            //        evenIndex++;

            //    }
            //    else
            //    {
            //        Console.WriteLine("These numbers are odd: ");
            //        oddNumbers[oddIndex] = number;
            //        oddIndex++;

            //    }
            //}

            //Console.WriteLine("These are the even numbers: ");
            //for (int i = 0; i < evenNumbers.Length; i++)
            //{
            //    Console.WriteLine(evenNumbers[i]);
            //}

            //Console.WriteLine("These are the odd numbers: ");
            //for (int i = 0; i < oddNumbers.Length; i++)
            //{
            //    Console.WriteLine(oddNumbers[i]);
            //}
        }
    }
}