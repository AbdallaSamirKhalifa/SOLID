public class LoggingService
{
    private ILogging _Logging;

    public LoggingService(ILogging logging)
    {
        _Logging = logging;
    }

    public void Log(string message)
    {
        _Logging.Log(message);
    }
}