public class PaymentService
{
    private IPaymentProcessor _pay;
    public PaymentService(IPaymentProcessor pay)
    {
        _pay = pay;
    }


    public void ProcessPayment(decimal amount)
    {
        _pay.Process(amount);
    }
}
