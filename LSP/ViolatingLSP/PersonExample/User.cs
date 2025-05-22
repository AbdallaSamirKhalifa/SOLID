namespace ViolatingLSP.PersonExample
{
    public class User : Person
    {
        public override void PaySalary()
        {
            throw new NotSupportedException("Users dont get paid");
        }
        public override void SendEmail()
        {
            Console.WriteLine("Sending email to the user...");
        }
    }

}
