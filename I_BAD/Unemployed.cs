namespace I_BAD
{
    public class Unemployed : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Unemployed, Work Work Work");
        }

        public void Eat()
        {
            Console.WriteLine("Eating pancakes");
        }
    }

}
