using System;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main()
    {
        Stack<String> customer = new Stack<string>();

        customer.Push("sai");
        customer.Push("seshu");
        customer.Push("bala");

        Console.WriteLine("customer : " );

        foreach( var names in customer )
        {
            Console.WriteLine(names);
        }
        Console.WriteLine("names of list POPED:" + customer.Pop());
        Console.WriteLine("NAMES OF THE LIST PEEK:" + customer.Peek());



    }
}