namespace Interface
{
   
        public interface ILegs
        {
            int NumberOfLegs { get; set; }
        }

        public interface ICanine
        {
            string Bark();
        }

        public interface IFeline
        {
            string Meow();
        }
    
}
