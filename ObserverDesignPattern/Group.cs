using ObserverDesignPattern.Interface;

namespace ObserverDesignPattern
{
    public class Group
    {
        private List<ISubscriber> _users = new List<ISubscriber>();

        public void Subscribe(ISubscriber user)
        {
            _users.Add(user);
        }
        public void Unsubscribe(ISubscriber user)
        {
            _users.Remove(user);
        }
        public void Notify(string msg)
        {
            foreach (ISubscriber user in _users)
            {
                user.Notify(msg);
            }
        }
    }
}
