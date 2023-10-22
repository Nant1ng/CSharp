namespace L_GOOD
{
    public class Triangle : IForm
    {
        public int Height { get; set; }
        public int Base { get; set; }

        public int Area()
        {
            return (Height * Base) / 2;
        }
    }
}
