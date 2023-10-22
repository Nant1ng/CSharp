namespace O_BAD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();
            AreaCalculator areaCalculator = new AreaCalculator();

            double circleRadius = 10;
            double rectangleWidth = 10;
            double rectangleHeight = 10;

            circle.Radius = circleRadius;
            double circleArea = areaCalculator.CalculateArea(circle);

            rectangle.Width = rectangleWidth;
            rectangle.Height = rectangleHeight;
            double rectangleArea = areaCalculator.CalculateArea(rectangle);


            Console.WriteLine($"Circles Area: {circleArea}");
            Console.WriteLine($"Rectangles Area: {rectangleArea}");
        }
    }
}
