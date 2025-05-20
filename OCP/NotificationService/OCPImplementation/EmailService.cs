
public class EmailService : INotification
{
    public void Send(string to, string message)
    {
        Console.WriteLine($"\nSending Email to {to}: {message}");
    }
}
