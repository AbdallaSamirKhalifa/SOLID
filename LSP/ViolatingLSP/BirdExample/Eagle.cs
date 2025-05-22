namespace ViolatingLSP.BirdExample
{
    public class Eagle : Bird
    {

        //this class doesnt violate the lsp 
        public override void Eat()
        {
            Console.WriteLine("Eagle is eating....");
        }

        public override void Fly()
        {
            Console.WriteLine("Eagle is flying...");
        }
    }
}
