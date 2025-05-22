namespace ViolatingLSP.PersonExample
{
    public class Student : Person
    {
        public override void PaySalary()
        {

            throw new NotSupportedException("Students dont get paied.");
        }
        public override void SendEmail()
        {
            Console.WriteLine("Sending email to an student...");
        }
    }

}
