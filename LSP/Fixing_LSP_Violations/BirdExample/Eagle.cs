namespace Fixing_LSP_Violations.BirdExample
{
    public class Eagle : FlyingBirds
    {
        public override void Fly()
        {
            Console.WriteLine("Eagle is flying...");
        }

        public override void Eat()
        {
            Console.WriteLine("Eagle is eating..");
        }
        public override void Drink()
        {
            Console.WriteLine("Eagle is drinking..");
        }
    }
}
