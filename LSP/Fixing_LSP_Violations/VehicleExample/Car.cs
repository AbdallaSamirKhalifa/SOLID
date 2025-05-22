namespace Fixing_LSP_Violations.VehicleExample
{
    public class Car: MotorVehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Driving the car....");
        }

        public override void StartEngine()
        {
            Console.WriteLine("Starting car engine...");
        }
    }

}
