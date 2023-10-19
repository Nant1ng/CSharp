namespace ColourClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ball redBall = new Ball(1, new Colour(255, 0, 0));
            Ball blueBall = new Ball(1, new Colour(0, 0, 255));
            Ball greenBall = new Ball(1, new Colour(0, 255, 0));

            redBall.ThrowBall();
            blueBall.ThrowBall();
            greenBall.ThrowBall();

            Console.WriteLine($"Red ball: {redBall.GetHowManyTimesBallBeingThrown()}");
            Console.WriteLine($"Blue ball: {blueBall.GetHowManyTimesBallBeingThrown()}");
            Console.WriteLine($"Green ball: {greenBall.GetHowManyTimesBallBeingThrown()}");

            blueBall.Pop();

            redBall.ThrowBall();
            blueBall.ThrowBall();
            greenBall.ThrowBall();

            Console.WriteLine($"Red ball: {redBall.GetHowManyTimesBallBeingThrown()}");
            Console.WriteLine($"Blue ball: {blueBall.GetHowManyTimesBallBeingThrown()}");
            Console.WriteLine($"Green ball: {greenBall.GetHowManyTimesBallBeingThrown()}");

        }
    }
}