public class FaxService : INotification
{
    public void Send(string to, string message)
    {
        Console.WriteLine($"\nSending Fax to {to}: {message}");
    }
}
