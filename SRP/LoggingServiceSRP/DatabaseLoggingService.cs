namespace LoggingServiceSRP
{
    public class DatabaseLoggingService
    {


        public static void Log(string message)
        {
            Console.WriteLine($"\nLog to database: {message}");

        }
    }
}
