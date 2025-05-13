using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class PaymentGateway
{
    public abstract void ProcessPayment(double amount);

    public void ShowGatewayName()
    {
        Console.WriteLine("processing payment through gateway");
    }
    
}

class StripeGateway : PaymentGateway
{
    public override void ProcessPayment(double amount)
    {
    Console.WriteLine("processing payment through stripe: " + amount);
    }  
    
}

class PaypalGateway : PaymentGateway
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine("processing payment through paypal: " + amount);
    }
}

class Program
{
    static void Main()
    {

        PaymentGateway payment;

        payment = new StripeGateway();
        payment.ShowGatewayName();
        payment.ProcessPayment(23333);


        payment = new PaypalGateway();
        payment.ShowGatewayName();
        payment.ProcessPayment(3444);

    }
}