namespace Violating_ISP.PaymentExample
{
    public class CreditCardPayment : IPayment
    {
        public void PayWithCreditCard()
        {
            Console.WriteLine("Payment with Credit card...");

        }
        public void PayWithPayPal()
        {
            throw new NotSupportedException("Credit card doesn't support this functionality.");
        }

        public void PayWithBitcoin()
        {
            throw new NotSupportedException("Credit card doesn't support this functionality.");

        }
    }

}
