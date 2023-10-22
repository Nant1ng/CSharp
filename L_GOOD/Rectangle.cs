namespace L_GOOD
{
    public class Rectangle : IForm
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Area()
        {
            return Width * Height;
        }
    }

}
