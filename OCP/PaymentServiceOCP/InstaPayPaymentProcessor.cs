namespace PaymentServiceOCP
{
    public class InstaPayPaymentProcessor : IPaymentProcessor
    {
        public void Process(decimal amount)
        {
            Console.WriteLine($"\nProcessing InstaPay payment of: {amount:C}");
        }
    }
}
