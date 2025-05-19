namespace LoggingService
{
    public class LoggingService
    {
        public enum enLoggingType
        {
            ToFile,
            ToEventLog,
            ToDatabase
        }

        public void Log(string message, enLoggingType loggingType)
        {
            switch (loggingType)
            {
                case enLoggingType.ToFile:
                    LogToFile(message);
                    break;
                case enLoggingType.ToEventLog:
                    LogToEventLog(message);
                    break;
                case enLoggingType.ToDatabase: 
                    LogToDatabase(message);
                    break;
                default:
                    break;
            }
        }

        private void LogToFile(string message)
        {
            Console.WriteLine($"\nLog to file: {message}");
        }

        private void LogToEventLog(string message)
        {
            Console.WriteLine($"\nLog to Event log: {message}");

        }

        private void LogToDatabase(string message)
        {
            Console.WriteLine($"\nLog to database: {message}");

        }
    }
}
