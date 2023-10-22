namespace O_GOOD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            AreaCalculator areaCalculator = new AreaCalculator();

            double rectangleWidth = 10;
            double rectangleHeight = 10;

            rectangle.Width = rectangleWidth;
            rectangle.Height = rectangleHeight;

            double area = areaCalculator.CalculateArea(rectangle);

            Console.WriteLine(area);
        }
    }
}