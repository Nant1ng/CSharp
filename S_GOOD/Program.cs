namespace S_GOOD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            UserDisplay display = new UserDisplay();
            string name = "Sami";
            string email = "sami.sami@sami.com";

            user.Create(name, email);
            display.Display(user);
        }
    }
}