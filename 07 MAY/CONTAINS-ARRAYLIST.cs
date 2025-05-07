using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add("apple");
        list.Add(42);
        list.Add(3.14);

        list.Remove(3.14);

        if (list.Contains("apple"))
        
            Console.WriteLine($"element found :");

        else
        
            Console.WriteLine($"element not found");

       

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.Read();
    }
}