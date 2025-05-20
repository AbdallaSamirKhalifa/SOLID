public class CreditCardPaymentProcessor : IPaymentProcessor
    {
        public void Process(decimal amount)
        {
            Console.WriteLine($"\nProcessing Credit Card payment of: {amount:C}");
        }
    }
