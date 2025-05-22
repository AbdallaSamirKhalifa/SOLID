namespace Fixing_LSP_Violations.PersonExample
{
    public class Emplyee:Person
    {
        public override void SendEmail()
        {
            Console.WriteLine("Sending email to an employee..");
        }

        public virtual void PaySalary()
        {
            Console.WriteLine("Paying salary to an employee..");
        }
    }
}
