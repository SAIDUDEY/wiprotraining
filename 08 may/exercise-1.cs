using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList names = new ArrayList();

        names.Add("sai");
        names.Add("seshu");
        names.Add("bala");
        names.Add("vinay");
        names.Add("vamshi");

        names.RemoveAt(2);



        foreach (string name in names)
        {
            Console.WriteLine("remaining students :" + name);
        }

        if (names.Contains("bala"))
        {
            Console.WriteLine("exists");

        }
        else
        {
            Console.WriteLine("not exists");
        }
    }
}
