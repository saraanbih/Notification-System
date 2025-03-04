
namespace Notification_System
{
    public delegate void NotificationHandler(string Message);
    public class NotificationSystem 
    {
        public event NotificationHandler OnNotification;
       
        List<User> Subscribers = new List<User>();

        public bool IsSubscribed(User user) => Subscribers.Contains(user);

        public bool HasSubscribers() => Subscribers.Count > 0;

        public void Subscribe(User user)
        {
            if (!IsSubscribed(user))
            {
                OnNotification += user.ReceiveNotification;
                Subscribers.Add(user);
                Console.WriteLine($"{user.Name} has Subscribed to Notifications :-)");
            }
            else
                Console.WriteLine($"{user.Name} has Subscribed to Notifications Before!");
                
        }

        public void Unsubscribe(User user) 
        {
            if(!IsSubscribed(user))
            {
                Console.WriteLine($"{user.Name} has UnSubscribed to Notifications Before!");
                return;
            }
            OnNotification -= user.ReceiveNotification;
            Subscribers.Remove(user);
            Console.WriteLine($"{user.Name} has unSucrided from Notifications :-(");
        }

        public void SendNotification(string Message)
        {
            if (!HasSubscribers())
            {
                Console.WriteLine("No Subscribers to Send Notification to!");
                return;
            }
            Console.WriteLine("\nSending Notification...");
            OnNotification?.Invoke(Message);
        }


    }
}