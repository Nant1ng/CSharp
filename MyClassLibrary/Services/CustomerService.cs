namespace MyClassLibrary.Services
{
    public class CustomerService
    {
        public List<Customer> Customers { get; private set; }

        public CustomerService()
        {
            Customers = Data.Customers ?? new List<Customer>();
        }

        public Customer Create()
        {
            Console.WriteLine("Vad heter din nya kund?");
            var name = Console.ReadLine();

            Console.WriteLine("Emailadress?");
            var email = Console.ReadLine();

            ++Data.IdSeed;
            var customer = new Customer(Data.IdSeed, name, email);
            Data.Customers.Add(customer);

            return customer;
        }

        public Customer ReadOne(int customerId)
        {
            return Data.Customers.Find(c => c.CustomerId == customerId);
        }

        public List<Customer> ReadAll()
        {
            return Data.Customers.ToList();
        }

        public void Update(int customerId)
        {
            var customerToUpdate = Data.Customers.Find(c => c.CustomerId == customerId);

            if (customerToUpdate == null)
            {
                Console.WriteLine("Kunden gick ej att hitta.");
                return;
            }

            Console.WriteLine("Uppdatera namnet på din kund");
            var name = Console.ReadLine();
            Console.WriteLine("Uppdatera Emailadressen på din kund");
            var email = Console.ReadLine();

            customerToUpdate.Name = name;
            customerToUpdate.Email = email;

            Console.WriteLine("Customer updated successfully");
        }

        public void Delete(int customerId)
        {
            var customerToDelete = Data.Customers.Find(c => c.CustomerId == customerId);
            if (customerToDelete == null)
            {
                Console.WriteLine("Kunden gick ej att hitta.");
                return;
            }
            Data.Customers.Remove(customerToDelete);
            Console.WriteLine("Kunden Raderades");
        }
    }
}
