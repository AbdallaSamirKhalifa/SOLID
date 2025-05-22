namespace Fixing_LSP_Violations.PersonExample
{
    public class User : Person
    {
   
        public override void SendEmail()
        {
            Console.WriteLine("Sending email to the user...");
        }
    }
}
