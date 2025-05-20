public class FileLoggingService:ILogging
{
    public void Log(string message)
    {
        Console.WriteLine($"\nLog to file: {message}");
    }


}
