namespace ViolatingLSP.VehicleExample
{
    public class Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Starting engine...");
        }

        public virtual void Drive()
        {
            Console.WriteLine("Driving...");
        }


    }
}
