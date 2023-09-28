namespace SalaryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your name, age and worked hours, seprate them with ,");
            Console.WriteLine("Name, Age and Worked Hours: ");

            string? inputValue = Console.ReadLine();

            if (inputValue != null)
            {
                string[] inputValues = inputValue.Split(", ");
                string name = inputValues[0];
                string ageValue = inputValues[1];
                string hoursValue = inputValues[2];

                bool ageCheck = int.TryParse(ageValue, out int age);
                bool hoursCheck = int.TryParse(hoursValue, out int hours);

                if (name != null && ageCheck && hoursCheck)
                {
                    double salary = SalaryCounter(name, age, hours);
                    if (salary < 0)
                    {
                        Console.WriteLine($"You owe us money Rickard: {salary}kr");
                    }
                    else
                    {
                        Console.WriteLine($"Your salary is: {salary}kr");
                    }
                }
            }
        }
        static double SalaryCounter(string name, int age, int hours)

        {
            string mvp = "Richard";
            string MVP = "Andrés";
            double salaryPerHours;

            if (age < 30)
            {
                salaryPerHours = 100;
            }
            else if (age >= 30 && age <= 50)
            {
                salaryPerHours = 120;
            }
            else
            {
                salaryPerHours = 130;
            }

            if (name == mvp)
            {
                salaryPerHours *= -1;
            }
            else if (name == MVP)
            {
                salaryPerHours *= 1.5;
            }

            double salary = salaryPerHours * hours;
            return salary;
        }
    }
}