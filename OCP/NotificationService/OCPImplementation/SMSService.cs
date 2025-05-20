public class SMSService : INotification
{
    public void Send(string to, string message)
    {
        Console.WriteLine($"\nSending SMS to {to}: {message}");
    }
}
