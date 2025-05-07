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

        list.RemoveAt(1);
        Console.WriteLine($"number of element remains {list.Count}");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.Read();
    }
}