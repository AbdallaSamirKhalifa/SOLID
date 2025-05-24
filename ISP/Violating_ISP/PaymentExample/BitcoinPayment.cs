namespace Violating_ISP.PaymentExample
{
    public class BitcoinPayment : IPayment
    {
        public void PayWithCreditCard()
        {
            throw new NotSupportedException("Bitcoin doesn't support this functionality.");

        }
        public void PayWithPayPal()
        {
            throw new NotSupportedException("Bitcoin doesn't support this functionality.");

        }

        public void PayWithBitcoin()
        {
            Console.WriteLine("Payment with Bitcoin...");

        }
    }

}
