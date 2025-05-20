public class DatabaseLoggingService:ILogging
{


    public void Log(string message)
    {
        Console.WriteLine($"\nLog to database: {message}");

    }
}