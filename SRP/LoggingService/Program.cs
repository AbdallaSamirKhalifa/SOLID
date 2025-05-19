namespace LoggingService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoggingService loggingService = new LoggingService();

            loggingService.Log("Error Occured line xxx.", LoggingService.enLoggingType.ToFile);

            loggingService.Log("Error Occured line xxx.", LoggingService.enLoggingType.ToEventLog);

            loggingService.Log("Error Occured line xxx.", LoggingService.enLoggingType.ToDatabase);


            Console.ReadKey();
        }
    }
}
