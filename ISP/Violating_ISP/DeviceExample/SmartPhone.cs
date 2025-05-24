namespace Violating_ISP.DeviceExample
{
    public class SmartPhone : IDevice
    {
        public void MakeCall()
        {
            Console.WriteLine("Making a call...");
        }
        
        public void TakePhoto()
        {
            Console.WriteLine("Taking photo...");
        }

        public void SendEmail()
        {
            Console.WriteLine("Sending email...");
        }
        public void UseGPS()
        {
            Console.WriteLine("Using GPS...");
        }
    }
}
