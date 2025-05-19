namespace LoggingServiceSRP
{
    public class LoggingServiceSRP
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
                   FileLoggingService.Log(message);
                    break;
                case enLoggingType.ToEventLog:
                    EventLogService.Log(message);
                    break;
                case enLoggingType.ToDatabase:
                    DatabaseLoggingService.Log(message);
                    break;
                default:
                    break;
            }
        }

       
    }
}
