using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService.OCPImplementation
{
    public class SnapChatService:INotification
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"\nSendign Snap Chat To {to}: {message}");
        }
    }
}
