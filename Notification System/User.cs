
namespace Notification_System
{
    public class User
    {
        public string Name { get; }

        public User(string name) => Name = name;

        public void ReceiveNotification(string Message) => Console.WriteLine($"{Name} has received this notification ***{Message}***");
    }
}
