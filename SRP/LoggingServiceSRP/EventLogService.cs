namespace LoggingServiceSRP
{
    public class EventLogService
    {
        public static void Log(string message)
        {
            Console.WriteLine($"\nLog to Event log: {message}");

        }
    }
}
