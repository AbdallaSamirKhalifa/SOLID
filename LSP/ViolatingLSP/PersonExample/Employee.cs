namespace ViolatingLSP.PersonExample
{
    public class Employee : Person
    {
        public override void PaySalary()
        {
            Console.WriteLine("Paying salary to an employee...");
        }
        public override void SendEmail()
        {
            Console.WriteLine("Sending email to an employee...");
        }
    }

}
