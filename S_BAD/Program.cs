namespace S_BAD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserHandler user = new UserHandler();

            string name = "Test";
            string email = "test.test@test.se";

            user.Create(name, email);
            user.Display();
        }
    }
}