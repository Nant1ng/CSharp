namespace Interface
{
    public class Wolf : Animal, ILegs, ICanine
    {
        public int NumberOfLegs { get; set; }

        public Wolf()
        {
            NumberOfLegs = 4;
        }
        public string Bark()
        {
            return "Woof";
        }
    }
}
