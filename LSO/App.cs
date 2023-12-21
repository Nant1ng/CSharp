using LSO.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LSO
{
    internal class App
    {
        public static void Run()
        {
            var builder = new ConfigurationBuilder().AddJsonFile($"appsettings.json", true, true);
            var config = builder.Build();

            var connectionString = config.GetConnectionString("DefaultConnection");

            var options = new DbContextOptionsBuilder<StudentContext>();
            options.UseSqlServer(connectionString);

            using (var dbContext = new StudentContext(options.Options))
            {
                bool IsRunning = true;

                while (IsRunning)
                {
                    Console.Clear();
                    Console.WriteLine("1. Create New Course");
                    Console.WriteLine("2. List All Courses");
                    Console.WriteLine("3. Create New Student");
                    Console.WriteLine("4. List All Students");
                    Console.WriteLine("5. Find Student by ID");
                    Console.WriteLine("0. Quit");

                    if (int.TryParse(Console.ReadLine(), out int choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                Console.Clear();

                                var course = new Kur();
                                Console.Write("Course Name: ");
                                string? inputValue = Console.ReadLine();

                                if (!string.IsNullOrWhiteSpace(inputValue))
                                {
                                    course.Namn = inputValue;
                                    dbContext.Add(course);
                                    dbContext.SaveChanges();
                                }

                                Console.ReadKey();
                                break;

                            case 2:
                                Console.Clear();

                                foreach (var c in dbContext.Kurs.OrderBy(u => u.Id))
                                {
                                    Console.WriteLine($"Id = {c.Id} : Name = {c.Namn} : Active = {c.IsActive}");
                                }

                                Console.ReadKey();

                                break;
                            case 3:
                                Console.Clear();
                                var student = new Student();
                                Console.Write("Students Firstname: ");
                                student.Fornamn = Console.ReadLine();

                                Console.Write("Students Surname: ");
                                student.Efternamn = Console.ReadLine();

                                Console.Write("Students Birthdate (yyyy-MM-dd): ");
                                student.Birthdate = Convert.ToDateTime(Console.ReadLine());

                                Console.WriteLine();
                                Console.Write("Available Course Ids:");

                                foreach (var c in dbContext.Kurs.OrderBy(u => u.Id))
                                {
                                    Console.WriteLine($"Id = {c.Id} : Name = {c.Namn} : Active = {c.IsActive}. ");
                                }

                                Console.Write("Choose One Course ID: ");
                                student.KursId = Convert.ToInt32(Console.ReadLine());

                                student.Kurs = dbContext.Kurs
                                    .Where(k => k.Id == student.KursId)
                                    .FirstOrDefault();

                                dbContext.Add(student);
                                dbContext.SaveChanges();

                                break;
                            case 4:
                                Console.Clear();

                                foreach (var s in dbContext.Students.OrderBy(u => u.Fornamn))
                                {
                                    Console.WriteLine($"Id = {s.Id} : First Name = {s.Fornamn} : Surname = {s.Efternamn} : Birthdate = {s.Birthdate} : Active = {s.IsActive} : Course = {s.Kurs}");
                                }

                                Console.ReadKey();
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("What is the Id of the student you are looking for?");
                                int.TryParse(Console.ReadLine(), out int courseID);

                                var foundStudent = dbContext.Students
                                    .Where(s => s.Id == courseID)
                                    .FirstOrDefault();

                                if (foundStudent == null)
                                {
                                    Console.WriteLine("No student exists with that Id");
                                    Console.WriteLine("Press any key to continue.");
                                    Console.ReadLine();
                                    continue;
                                }

                                Console.WriteLine($"Student Id: {foundStudent.Fornamn} {foundStudent.Efternamn}");

                                Console.WriteLine("Press any key to continue.");
                                Console.ReadLine();
                                break;
                            case 0:
                                Environment.Exit(0);
                                break;
                        }
                    }


                }
            }
        }
    }
}
