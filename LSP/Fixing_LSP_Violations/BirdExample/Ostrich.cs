namespace Fixing_LSP_Violations.BirdExample
{
    public class Ostrich : Bird
    {
        public override void Eat()
        {

            Console.WriteLine("Ostrich is eating...");
        }
        public override void Drink()
        {
            Console.WriteLine("Ostrich is drinking...");
        }

        //no need for the fly method , it's not in the base class, the ostrich is classified as non-flying bird
    }
}
