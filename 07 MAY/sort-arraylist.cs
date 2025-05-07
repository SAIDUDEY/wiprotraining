using System;
using System.Collections;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        ArrayList number = new ArrayList() { 4, 5, 3, 7, 1 };
        number.Sort();
        Console.WriteLine("sorted :");

        foreach (var num in number)
        {
            Console.WriteLine(num);
        }
    }
}