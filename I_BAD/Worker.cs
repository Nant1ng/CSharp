namespace I_BAD
{
    public class Worker : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Work Work Work");
        }

        public void Eat()
        {
            Console.WriteLine("Eating pancakes");
        }
    }
}
