namespace ColourClass
{
    public class Ball
    {
        public Colour Colour { get; set; }
        public int Size { get; set; }
        public int BallThrown { get; private set; }
        public Ball(int size, Colour colour)
        {
            Size = size;
            Colour = colour;
            ballThrown = 0;
        }

        private Colour colour;
        private int size;
        private int ballThrown;

        public void Pop()
        {
            size = 0;
        }

        public void ThrowBall()
        {
            if (size >= 1)
            {
                ballThrown += 1;
            }

        }

        public int GetHowManyTimesBallBeingThrown()
        {
            return ballThrown;
        }

    }
}
