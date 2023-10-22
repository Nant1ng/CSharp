namespace I_GOOD
{
    public class Worker : IWorker, IEat
    {
        public void Work()
        {
            Console.WriteLine("Worker is working.");
        }

        public void Eat()
        {
            Console.WriteLine("Worker is eating.");
        }
    }
}
