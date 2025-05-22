namespace Fixing_LSP_Violations.PersonExample
{
    public class Manager : Emplyee
    {
        public override void SendEmail()
        {
            Console.WriteLine("Sending email to the manager..");
        }

        public override void PaySalary()
        {
            Console.WriteLine("Paying salary to manager..");
        }
    }
}
