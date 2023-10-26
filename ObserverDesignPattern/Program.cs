namespace ObserverDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var group = new Group();

            var users = new List<User>()
            {
                new User(1),
                new User(2),
                new User(3)
            };

            group.Subscribe(users[0]);
            group.Subscribe(users[1]);
            group.Subscribe(users[2]);

            group.Notify("new msg");

            group.Unsubscribe(users[0]);
            group.Notify("newest msg");
        }
    }
}