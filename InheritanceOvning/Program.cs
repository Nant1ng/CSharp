namespace InheritanceOvning
{
    internal class Program
    {
        public static void Main(string[] args)
        {

        }

        // Nothing special about this class.
        // It will be used as the base class.
        class Polygon
        {
            public int NumberOfSides { get; set; }
            public Polygon()
            {
                NumberOfSides = 0;
            }
            public Polygon(int numberOfSides)
            {
                NumberOfSides = numberOfSides;
            }
        }

        class Square : Polygon
        {
            // Square contains EVERYTHING from Polygon
            // ... but can also do its own stuff!
            public float Size { get; set; }
            public Square(float size)
            {
                Size = size;
                NumberOfSides = 4;
            }
        }

        class Triangle : Polygon
        {
            public float Base { get; set; }
            public float Height { get; set; }
            public Triangle()
            {

            }
        }
    }
}
