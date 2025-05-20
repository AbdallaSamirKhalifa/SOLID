namespace LoggingServiceOCP
{
    internal class Program
    {
         
        static void Main(string[] args)
        {
            LoggingService DatabaseLogger = new LoggingService(new DatabaseLoggingService());
            DatabaseLogger.Log("Error Ocurred line xxx.");

            LoggingService EventLogger = new LoggingService(new EventLogService());
            EventLogger.Log("Error Occured line xxx.");

            LoggingService fileLogger = new LoggingService(new FileLoggingService());
            fileLogger.Log("Error occurred line xxx.");


            Console.ReadKey();
        }
    }
}
