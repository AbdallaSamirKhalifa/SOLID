namespace ViolatingLSP.PersonExample
{
    public class Person
    {
        public virtual void PaySalary()
        {
            Console.WriteLine("Paying salary to a person...");
        }
        public virtual void SendEmail()
        {
            Console.WriteLine("Sending email to a person...");
        }
    }

}
