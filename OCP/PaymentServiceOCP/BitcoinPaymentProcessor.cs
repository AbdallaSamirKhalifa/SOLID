public class BitcoinPaymentProcessor : IPaymentProcessor
    {
        public void Process(decimal amount)
        {
            Console.WriteLine($"\nProcessing Bitcoin payment of: {amount:C}");
        }
    }
