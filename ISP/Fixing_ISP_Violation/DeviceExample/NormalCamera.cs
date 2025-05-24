namespace Fixing_ISP_Violation.DeviceExample
{
    public class NormalCamera : ICameraDevice
    {
        public void TakePhoto()
        {
            Console.WriteLine("Taking photo....");
        }
    }
}
