using System;
using System.Collections;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        ArrayList names = new ArrayList() {"sai", "bala", "dude", "vinay" };
        names.Sort();
        names.Remove("sai");

        Console.WriteLine("enter a student name :");
        string NametoCheck = Console.ReadLine();

        if (names.Contains(NametoCheck))
        {
            Console.WriteLine("name found: " + NametoCheck);
        
        }
        else
        {
            Console.WriteLine("not exists: " + NametoCheck);
        }

        Console.WriteLine("final list : ");
            foreach (var num in names)
            
        {
                Console.WriteLine(num);
            }
        

    }
}