public class EventLogService:ILogging
{
    public void Log(string message)
    {
        Console.WriteLine($"\nLog to Event log: {message}");

    }
}
