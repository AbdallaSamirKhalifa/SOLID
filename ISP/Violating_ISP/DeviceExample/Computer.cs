namespace Violating_ISP.DeviceExample
{
    public class Computer : IDevice
    {
        public void MakeCall()
        {
            throw new NotSupportedException("This device does not support this feature.");
        }

        public void TakePhoto()
        {
            throw new NotSupportedException("This device does not support this feature.");
        }

        public void SendEmail()
        {
            Console.WriteLine("Sending email...");
        }
        public void UseGPS()
        {
            throw new NotSupportedException("This device does not support this feature.");

        }
    }
}
