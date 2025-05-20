public class TelegramService : INotification
{
    public void Send(string to, string message)
    {
        Console.WriteLine($"\nSending Telegram to {to}: {message}");
    }
}