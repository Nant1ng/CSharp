namespace AgeGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person personOne = new Person() { Name = "Andrés", Age = 23 };
            Person personTwo = new Person() { Name = "Sami", Age = 28 };
            Person personThree = new Person() { Name = "Alessio", Age = 5 };
            Person personFour = new Person() { Name = "Rickard", Age = 66 };

            var personList = new List<Person>() { personOne, personTwo, personThree, personFour };

            Display.DisplayPeople("Child", personList, Display.IsChild);
            Display.DisplayPeople("Adult", personList, Display.IsAdult);
            Display.DisplayPeople("Pensioner", personList, Display.IsPensioner);
        }
    }
}