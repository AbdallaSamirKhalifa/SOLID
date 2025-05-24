namespace Fixing_ISP_Violation.DeviceExample
{
    public class Camera : ICameraDevice
    {
        public void TakePhoto()
        {
            Console.WriteLine("Taking photo...");
        }
    }
}
