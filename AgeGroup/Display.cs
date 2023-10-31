namespace AgeGroup
{
    public static class Display
    {
        public static void DisplayPeople(string type, List<Person> people, FilterDelegate filter)
        {
            foreach (Person person in people)
            {
                if (filter(person))
                {
                    Console.WriteLine($"{type}: {person.Name} is {person.Age} years old.");
                }
            }

        }

        public static bool IsChild(Person person)
        {
            bool result = person.Age < 18;
            return result;

        }
        public static bool IsAdult(Person person)
        {
            bool result = person.Age >= 18 && person.Age < 65;
            return result;

        }
        public static bool IsPensioner(Person person)
        {
            bool result = person.Age >= 65;
            return result;

        }
    }
}
