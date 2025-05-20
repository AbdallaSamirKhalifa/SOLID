public class WhatsapService : INotification
{
    public void Send(string to, string message)
    {
        Console.WriteLine($"\nSending Whatsapp to {to}: {message}");
    }
}
