
/// <summary>
/// this class applies the Open closed principle
/// </summary>
public class NotificationService_OCP
{
    private INotification _Notification;
    public NotificationService_OCP(INotification notification)
    {
        _Notification = notification;
    }
    public void SendNotification( string to, string message)
    {
        _Notification.Send(to, message);
    }
}