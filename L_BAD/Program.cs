namespace L_BAD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Square square = new Square();

            int rectangleWidth = 11;
            int rectangleHeight = 11;

            rectangle.Width = rectangleWidth;
            rectangle.Height = rectangleHeight;

            int squareWidth = 12;
            int squareHeight = 12;

            square.Width = squareWidth;
            square.Height = squareHeight;

            Console.WriteLine($"Rectangle Area: {rectangle.Area()}");
            Console.WriteLine($"Square Area: {square.Area()}");
        }
    }
}