namespace ViolatingLSP.PersonExample
{
    public class Manager : Employee
    {
        public override void PaySalary()
        {
            Console.WriteLine("Paying salary to the manager...");
        }
        public override void SendEmail()
        {
            Console.WriteLine("Sending email to the manager...");
        }
    }

}
