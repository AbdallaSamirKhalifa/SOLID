namespace NotificationService
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the NotificationService
            NotificationService notificationService = new NotificationService();

            // Send an email
            notificationService.SendNotification("john@example.com", "Welcome to our service!",
                NotificationService.enNotificationType.Email);

            // Send an SMS
            notificationService.SendNotification("+123456789", "Your OTP code is 1234.", 
                NotificationService.enNotificationType.SMS);

            // Send a fax
            notificationService.SendNotification("123-456-789", "Fax Message: Important document.",
                NotificationService.enNotificationType.Fax);

            Console.ReadKey();
        }
    }
}
