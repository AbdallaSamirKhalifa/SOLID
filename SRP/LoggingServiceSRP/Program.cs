namespace LoggingServiceSRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoggingServiceSRP loggingServiceSRP = new LoggingServiceSRP();

            loggingServiceSRP.Log("Error Occured line xxx.", LoggingServiceSRP.enLoggingType.ToFile);

            loggingServiceSRP.Log("Error Occured line xxx.", LoggingServiceSRP.enLoggingType.ToEventLog);

            loggingServiceSRP.Log("Error Occured line xxx.", LoggingServiceSRP.enLoggingType.ToDatabase);
            Console.ReadKey();
        }
    }
}
