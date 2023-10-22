namespace I_BAD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            Unemployed unemployed = new Unemployed();

            worker.Work();
            worker.Eat();

            unemployed.Work();
            unemployed.Eat();

        }
    }
}