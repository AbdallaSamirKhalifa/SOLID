namespace ViolatingLSP.BirdExample
{
    public class  Ostrich:Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Ostrich is eating....");
        }

        public override void Fly()
        {
            //ostriches cant fly, but bescouse it is forced to override fly, it violates LSP
            throw new NotSupportedException("Ostriches can't fly.");
            //Console.WriteLine("Eagle is flying...");
        }
    }
}
