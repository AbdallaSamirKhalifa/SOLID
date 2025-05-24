namespace Fixing_ISP_Violation.DeviceExample
{
    public interface ISmartPhone : ICameraDevice, IMailDevice, ICallDevice, IGPSDevice
    {

        //just utilizing interface inheritance and extending the functionality of the interfaces
        void PlayMusic();
    }

}
