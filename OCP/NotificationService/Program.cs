using NotificationService.OCPImplementation;

namespace NotificationService
{
    public class Program
    {

        static void Main(string[] args)
        {


            NotificationService_OCP EmailService =
                new NotificationService_OCP( new EmailService());
            EmailService.SendNotification("john@example.com", "Welcome to our service!");

            NotificationService_OCP FaxService =
            new NotificationService_OCP(new FaxService());
            FaxService.SendNotification("123-456-789", "Fax Message: Important document.");

            NotificationService_OCP SMSService =
                new NotificationService_OCP(new SMSService());
            SMSService.SendNotification("+123456789", "Your OTP code is 1234.");

            NotificationService_OCP WhatsappService=
                new NotificationService_OCP(new WhatsapService());
            WhatsappService.SendNotification("+123456789", "Whatsapp message: Important Message.");

            NotificationService_OCP TelegramService=
                new NotificationService_OCP(new TelegramService());
            TelegramService.SendNotification("+123456789", "Telegram message: Important Message.");
            
            NotificationService_OCP SnapChatService=
                new NotificationService_OCP(new SnapChatService());
            SnapChatService.SendNotification("+123456789", "SnapChat message: Important Message.");



            // Send a fax
            Console.ReadKey();
        }
    }
}
