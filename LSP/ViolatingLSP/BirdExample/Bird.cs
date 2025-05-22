namespace ViolatingLSP.BirdExample
{
    public class Bird
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public virtual void Fly()
        {
            Console.WriteLine("Flying...");
        }
    }
}
