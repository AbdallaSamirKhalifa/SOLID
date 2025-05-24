namespace Violating_ISP.PaymentExample
{
    public class PayPalPayment : IPayment
    {
        public void PayWithCreditCard()
        {
            throw new NotSupportedException("PayPal doesn't support this functionality.");

        }
        public void PayWithPayPal()
        {
            Console.WriteLine("Payment with PayPal...");

        }

        public void PayWithBitcoin()
        {
            throw new NotSupportedException("PayPal doesn't support this functionality.");

        }
    }

}
