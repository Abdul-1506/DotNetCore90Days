namespace Day02_OCP
{
     class Program
    {
        static void Main(string[] args) { 
            NotificationService service = new NotificationService();
            service.notificationSend(new SMSNotificationSender());
        }
        

    }

    public class NotificationService
    {
        public void notificationSend(INotification notification)
        {
            notification.send();
        }
    }

    public interface INotification
    {
        public void send();
    }

    public class EmailNotificationSender : INotification
    {
        public void send()
        {
            Console.WriteLine("Notification sending through Email");
        }
    }

    public class SMSNotificationSender : INotification
    {
        public void send()
        {
            Console.WriteLine("Notification sending through SMS");
        }
    }
}