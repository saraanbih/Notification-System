using Notification_System;

class Program
{
    static void Main(string[] args)
    {
       NotificationSystem notificationSystem = new NotificationSystem();

        User user1 = new User("Sara");
        User user2 = new User("Hager");
        User user3 = new User("Shrouk");

        notificationSystem.Subscribe(user1);
        notificationSystem.Subscribe(user2);
        notificationSystem.Subscribe(user3);

        notificationSystem.SendNotification("Wake Up! This is Pray Time");

        notificationSystem.Unsubscribe(user3);

        notificationSystem.SendNotification("The Lunch is Ready");

        Console.ReadKey();
    }
}