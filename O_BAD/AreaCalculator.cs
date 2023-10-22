namespace O_BAD
{
    public class AreaCalculator
    {
        public double CalculateArea(object shape)
        {
            double area = 0;

            if (shape is Rectangle rectangle)
            {
                double rectangleArea = rectangle.Width * rectangle.Height;
                area = rectangleArea;
            }
            else if (shape is Circle circle)
            {
                double circleArea = Math.PI * Math.Pow(circle.Radius, 2);
                area = circleArea;
            }

            return area;
        }
    }
}
