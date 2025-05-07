using System;
using System.Collections;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        ArrayList number = new ArrayList() { 1, 2, 4, 6 };
        number.Reverse();
        Console.WriteLine("reverse:");

        foreach (var num in number)
        {
            Console.WriteLine(num);
        }
    }
}