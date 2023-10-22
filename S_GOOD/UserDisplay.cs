namespace S_GOOD
{
    public class UserDisplay : User
    {
        public void Display(User user)
        {
            Console.WriteLine($"Namn: {user.Name}, E - post: {user.Email}");
        }
    }
}
