namespace NotificationServiceSRP
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the NotificationService
            NotificationServiceSRP notificationServiceSRP = new NotificationServiceSRP();

            // Send an email
            notificationServiceSRP.SendNotification("john@example.com", "Welcome to our service!",
                NotificationServiceSRP.enNotificationType.Email);

            // Send an SMS
            notificationServiceSRP.SendNotification("+123456789", "Your OTP code is 1234.",
                NotificationServiceSRP.enNotificationType.SMS);

            // Send a fax
            notificationServiceSRP.SendNotification("123-456-789", "Fax Message: Important document.",
                NotificationServiceSRP.enNotificationType.Fax);

            Console.ReadKey();
        }
    }
}
