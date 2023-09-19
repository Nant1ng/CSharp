namespace MiniBoss
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
                Console.Write("          Mini Boss            ");
                Console.ResetColor();
                Console.Write("||");
                Console.WriteLine();
                Console.WriteLine("===================================");
                Console.Write("||");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" [1].");
                Console.ResetColor();
                Console.Write("        Copy              ");
                Console.Write("||");
                Console.WriteLine("");
                Console.WriteLine("||-------------------------------||");
                Console.Write("||");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" [2].");
                Console.ResetColor();
                Console.Write("    Jagged Arrays         ");
                Console.Write("||");
                Console.WriteLine("");
                Console.WriteLine("||-------------------------------||");
                Console.Write("||");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" [3].");
                Console.ResetColor();
                Console.Write("  Rectangular Arrays      ");
                Console.Write("||");
                Console.WriteLine("");
                Console.WriteLine("===================================");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Copy();
                        break;

                    case 2:
                        JaggedArrays();
                        break;

                    case 3:
                        RectangularArray();
                        break;
                }

                Console.WriteLine("Press Enter to go back to the menu.");
                Console.ReadLine();
                Console.Clear();
            }
        }
        static void Copy()
        {
            string[] array = new string[]
            {
                "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten"
            };
            string[] newArray = new string[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            Console.Write("Array: ");
            foreach (string value in array)
            {
                Console.WriteLine(value);
            }

            Console.Write("New Array: ");
            foreach (string value in newArray)
            {
                Console.WriteLine(value);
            }

        }
        static void JaggedArrays()
        {
            Console.WriteLine("Add the numbers 10, 20, 30, 40 and 50 to a Jagged Array.");
            int[][] matrix = new int[4][];
            matrix[0] = new int[4];
            matrix[1] = new int[5];
            matrix[2] = new int[2];
            matrix[3] = new int[6];

            //for (int row = 0; row < matrix.Length; row++)
            //{
            //    int addValue = 10;

            //    for (int col = 0; col < matrix[row].Length; col++)
            //    {
            //        matrix[row][col] = addValue;
            //        addValue += 10;
            //        Console.Write(matrix[row][col] + " ");

            //    }
            //    Console.WriteLine();

            //}

            int addValue = 0;
            for (int i = 0; i < matrix[1].Length; i++)
            {
                addValue += 10;
                matrix[1][i] = addValue;
            }

            foreach (int value in matrix[1])
            {
                Console.WriteLine(value);
            }
        }
        static void RectangularArray()
        {
            int[,] matrix = new int[4, 4];
            matrix[0, 0] = 1;
            matrix[0, 1] = 0;
            matrix[3, 3] = 1;

            matrix[3, 2] = 12;
            matrix[3, 3] = 98;

            Console.WriteLine(matrix[3, 2]);
            Console.WriteLine(matrix[3, 3]);
        }
    }
}