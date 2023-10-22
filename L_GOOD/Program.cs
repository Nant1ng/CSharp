namespace L_GOOD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Square square = new Square();
            Triangle triangle = new Triangle();

            int rectangleWidth = 10;
            int rectangleHeight = 10;

            rectangle.Width = rectangleWidth;
            rectangle.Height = rectangleHeight;

            int squareSide = 11;

            square.Side = squareSide;

            int triangleHeight = 12;
            int triangleBase = 12;

            triangle.Base = triangleBase;
            triangle.Height = triangleHeight;

            Console.WriteLine($"Rectangles Area: {rectangle.Area()}");
            Console.WriteLine($"Squares Area: {square.Area()}");
            Console.WriteLine($"Triangles Area: {triangle.Area()}");

        }
    }
}