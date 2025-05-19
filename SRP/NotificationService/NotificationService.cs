namespace NotificationService
{
    public class NotificationService
    {
        public enum enNotificationType
        {
            Email, SMS, Fax
        }
        public void SendNotification(string to, string message, enNotificationType notificationType)
        
        {
            switch (notificationType)
            {
                case enNotificationType.Email:
                    SendEmail(to, message);
                    break;
                case enNotificationType.SMS:
                
                    SendSMS(to, message);
                    break;
                case enNotificationType.Fax:
                    SendFax(to, message);
                break;
                default:
                    break;
            }
        }

        private void SendSMS(string to, string message)
        {
            Console.WriteLine($"\nSending SMS to {to}: {message}");
        }

        private void SendEmail(string to, string message)
        {
            Console.WriteLine($"\nSending Email to {to}: {message}");
        }        
        
        private void SendFax(string to, string message)
        {
            Console.WriteLine($"\nSending Fax to {to}: {message}");
        }

    }
}
