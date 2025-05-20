namespace PaymentServiceOCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentService payment = new PaymentService(new PayPalPaymentProcessor());
            payment.ProcessPayment(100.00M);

            payment= new PaymentService(new CreditCardPaymentProcessor());
            payment.ProcessPayment(250.50M);

            payment = new PaymentService(new BankTransferPaymentProcessor());
            payment.ProcessPayment(500.75M);

            payment = new PaymentService(new BitcoinPaymentProcessor());
            payment.ProcessPayment(0.005M);
            
            payment = new PaymentService(new InstaPayPaymentProcessor());
            payment.ProcessPayment(300.00M);

            Console.ReadKey();
        }
    }
}
