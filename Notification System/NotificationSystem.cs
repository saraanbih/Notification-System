
namespace Notification_System
{
    public delegate void NotificationHandler(string Message);
    public class NotificationSystem 
    {
        public event NotificationHandler OnNotification;
       
        List<User> Subscribers = new List<User>();

        public void Subscribe(User user)
        {
            OnNotification += user.ReceiveNotification;
            Subscribers.Add(user);
            Console.WriteLine($"{user.Name} has Subscribed to Notifications :-)");
        }

        public void Unsubscribe(User user) 
        {
            OnNotification -= user.ReceiveNotification;
            Subscribers.Remove(user);
            Console.WriteLine($"{user.Name} has unSucrided from Notifications :-(");
        }

        public void SendNotification(string Message)
        {
            Console.WriteLine("\nSending Notification...");
            OnNotification?.Invoke(Message);
        }


    }
}