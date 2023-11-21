using MyClassLibrary;
using MyClassLibrary.Services;

namespace LibraryAndServices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data.SeedData();
            var run = true;
            var customerService = new CustomerService();

            while (run)
            {
                Console.Clear();
                Console.WriteLine("1: Create a customer");
                Console.WriteLine("2: Read a customer (with Id)");
                Console.WriteLine("3: Read all customers");
                Console.WriteLine("4: Update a customer");
                Console.WriteLine("5: Delete a customer");
                Console.WriteLine("0: Exit");
                Console.Write("\nInput: ");

                if (int.TryParse(Console.ReadLine(), out var userChoice))
                {
                    switch (userChoice)
                    {
                        case 1:
                            customerService.Create();
                            break;

                        case 2:
                            Console.WriteLine("Id of customer: ");
                            var customerIdReadOne = Convert.ToInt32(Console.ReadLine());
                            var readOne = customerService.ReadOne(customerIdReadOne);

                            if (readOne != null)
                            {
                                Console.WriteLine(
                                $"{readOne.CustomerId}: {readOne.Name}, {readOne.Email}");
                                Console.WriteLine("Press any key to continue");
                                Console.ReadLine();
                            }

                            break;

                        case 3:
                            var customers = customerService.ReadAll();

                            foreach (var c in customers)
                            {
                                Console.WriteLine(
                                    $"{c.CustomerId}: {c.Name}, {c.Email}");
                            }

                            Console.WriteLine("Press any key to continue");
                            Console.ReadLine();

                            break;

                        case 4:
                            Console.WriteLine("Id of customer you want to update: ");
                            var customerIdUpdate = Convert.ToInt32(Console.ReadLine());

                            customerService.Update(customerIdUpdate);
                            break;

                        case 5:
                            Console.WriteLine("Id of customer you want to delete: ");
                            var customerIdDelete = Convert.ToInt32(Console.ReadLine());
                            customerService.Delete(customerIdDelete);
                            break;

                        case 0:
                            Environment.Exit(0);
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.ReadLine();
                }
            }
        }
    }
}