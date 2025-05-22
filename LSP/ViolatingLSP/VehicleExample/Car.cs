namespace ViolatingLSP.VehicleExample
{
    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started...");
        }

        public override void Drive()
        {
            Console.WriteLine("Driving car...");
        }

    }
}
