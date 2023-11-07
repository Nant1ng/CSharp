namespace GenericsArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var intArray = new ArraysGeneric().CreateArray(1, 11);

            Console.WriteLine("Int: ");
            foreach (var num in intArray)
                Console.WriteLine(num);

            Console.WriteLine();


            var doubleArray = new ArraysGeneric().CreateArray(1.1, 11.1);

            Console.WriteLine("Double: ");
            foreach (var num in doubleArray)
                Console.WriteLine(num);

            Console.WriteLine();

            var stringArray = new ArraysGeneric().CreateArray("QWER", "WASD");

            Console.WriteLine("String: ");
            foreach (var name in stringArray)
                Console.WriteLine(name);

            Console.WriteLine();
            Console.WriteLine();


            var intArrGen = new ArraysGeneric().CreateArrayGeneric(9, 99);

            Console.WriteLine("Int: ");
            foreach (var num in intArrGen)
                Console.WriteLine(num);

            Console.WriteLine();

            var doubleArrGen = new ArraysGeneric().CreateArrayGeneric(9.9, 99.9);

            Console.WriteLine("Double: ");
            foreach (var num in doubleArrGen)
                Console.WriteLine(num);

            Console.WriteLine();

            var stringArrGen = new ArraysGeneric().CreateArrayGeneric("WASD", "QWER");

            Console.WriteLine("String: ");
            foreach (var name in stringArrGen)
                Console.WriteLine(name);
        }
    }
}