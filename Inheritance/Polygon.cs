namespace Inheritance
{
    public class Polygon
    {
        public int NumbersOfSides { get; set; }

        public Polygon()
        {
            NumbersOfSides = 0;
        }

        public Polygon(int numbersOfSides)
        {
            NumbersOfSides = numbersOfSides;
        }
    }
}
