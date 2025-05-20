public class PayPalPaymentProcessor : IPaymentProcessor
    {
        public void Process(decimal amount)
        {
            Console.WriteLine($"\nProcessing PayPal payment of: {amount:C}");
        }
    }
