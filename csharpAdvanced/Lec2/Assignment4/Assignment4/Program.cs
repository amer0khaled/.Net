namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerNotification notification = new CustomerNotification();

            notification.NotificationMthod = new SMS();
            notification.Notify("welcome...");

            notification.NotificationMthod = new Email();
            notification.Notify("welcome...");

            notification.NotificationMthod = new PushNotification();
            notification.Notify("welcome...");
        }
    }
}
