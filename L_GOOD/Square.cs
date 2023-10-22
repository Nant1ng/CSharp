namespace L_GOOD
{
    public class Square : IForm
    {
        public int Side { get; set; }
        public int Area()
        {
            return Side * Side;
        }
    }
}
