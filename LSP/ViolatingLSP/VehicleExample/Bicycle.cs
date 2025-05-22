namespace ViolatingLSP.VehicleExample
{
    public class Bicycle : Vehicle
    {
        public override void StartEngine()
        {
            //they don't have engines
            throw new NotSupportedException("Bicycle don't have engine.");
        }

        public override void Drive()
        {
            Console.WriteLine("Riding bicycle...");
        }


    }

}

    

