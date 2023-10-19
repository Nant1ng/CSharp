namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var newPolygon = new Polygon();
            Console.WriteLine(newPolygon.NumbersOfSides);

            Polygon myTriangle = new Polygon(3);

            Polygon square = new Square(4.5f);
        }
    }
}