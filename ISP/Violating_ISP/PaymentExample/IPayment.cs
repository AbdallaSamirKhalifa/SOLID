namespace Violating_ISP.PaymentExample
{
    public interface IPayment
    {
        void PayWithCreditCard();
        void PayWithPayPal();
        void PayWithBitcoin();
    }

}
