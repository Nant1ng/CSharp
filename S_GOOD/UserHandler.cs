namespace S_GOOD
{
    public class User
    {
        public string? Name { get; set; }
        public string? Email { get; set; }

        public void Create(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
