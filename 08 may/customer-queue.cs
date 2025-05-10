using System;

class Program
{
    static void Main()
    {
        Queue<String> customer = new Queue<string>();

        customer.Enqueue("sai");
        customer.Enqueue("seshu");
        customer.Enqueue("bala");

        Console.WriteLine("serving customer : ");

        while(customer.Count > 0)
        {
            Console.WriteLine(customer.Dequeue());
        }

      
      
    }
}