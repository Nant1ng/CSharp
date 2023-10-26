using ObserverDesignPattern.Interface;

namespace ObserverDesignPattern
{
    public class User : ISubscriber
    {
        private int _userId;

        public User(int userId)
        {
            _userId = userId;
        }
        public void Notify(string msg)
        {
            Console.WriteLine($"User: {_userId}, Msg: {msg}");
        }
    }
}
