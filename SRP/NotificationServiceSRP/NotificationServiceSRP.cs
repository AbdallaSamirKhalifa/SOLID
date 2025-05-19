namespace NotificationServiceSRP
{
    public class NotificationServiceSRP
    {
        public enum enNotificationType
        {
            SMS,
            Fax,
            Email
        }

        public void SendNotification(string to, string message, enNotificationType notificationType)

        {
            switch (notificationType)
            {
                case enNotificationType.Email:
                   EmailService.SendEmail(to, message);
                    break;
                case enNotificationType.SMS:

                    SMSService.SendSMS(to, message);
                    break;
                case enNotificationType.Fax:
                    FaxService.SendFax(to, message);
                    break;
                default:
                    break;
            }
        }
    }
}
