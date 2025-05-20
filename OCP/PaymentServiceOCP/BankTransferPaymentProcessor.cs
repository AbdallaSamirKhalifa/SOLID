public class BankTransferPaymentProcessor : IPaymentProcessor
    {
        public void Process(decimal amount)
        {
            Console.WriteLine($"\nProcessing Bank Transfer payment of: {amount:C}");
        }
    }
