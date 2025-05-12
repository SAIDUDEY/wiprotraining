interface Payment
{
    void processpayment(decimal amount);
}

class CreditCardPayment : Payment
{
    public void processpayment(decimal amount)
    {
        Console.WriteLine("creditcardpayment : " + amount);
    }

}
class Paypal : Payment
{
    public void processpayment(decimal amount)
    {
        Console.WriteLine("paypal payment : " + amount);
    }
}

class Program
{
    static void Main()
    {
        Payment payment;

        payment = new CreditCardPayment();
        payment.processpayment(13555);

        payment = new Paypal();
        payment.processpayment(13555);
    }
}