namespace Fixing_ISP_Violation.DeviceExample
{
    public class SmartPhone : ISmartPhone
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

        public void PlayMusic()
        {
            Console.WriteLine("Playing music...");
        }
    }
}
