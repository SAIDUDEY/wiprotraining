public abstract class PaymentMethod
{
    public abstract void ProcessPayment(decimal amount);

    public void ShowPaymentMethod(string method)
    {
        Console.WriteLine("Payment Method :" + method);
    }
}

class CreditCardPayment : PaymentMethod
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine("processing CC payment of amount : " + amount);
    }
}
class UPIPayment : PaymentMethod
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine("processing upi payment of amount :" + amount);
    }
}

class Program
{
    static void Main()
    {
        PaymentMethod payment;

        payment = new CreditCardPayment();
        payment.ProcessPayment(444.00m);
        payment.ShowPaymentMethod("CC");

        Console.WriteLine();

        payment = new UPIPayment();
        payment.ProcessPayment(555.00m);
        payment.ShowPaymentMethod("upi");

    }
}