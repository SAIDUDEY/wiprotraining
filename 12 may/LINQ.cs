using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] names = { "anil", "sharma", "abdhullah", "imran", "siva", "naresh" , "suresh", "suman" };

        UsingLinq(names);
    }

    private static void UsingLinq(string[] names)
    {
        IEnumerable<string> query = from s in names
                                    where s.Length == 5
                                    orderby s
                                    select s.ToUpper();

        foreach (string item in query)
        {
            Console.WriteLine(item);

            Console.Read();
        }
    }
}


//OR

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] names = {"anil", "sharma", "abdhullah", "imran", "siva", "naresh" , "suresh", "suman" };

        UsingLinq(names);
    }

    private static void UsingLinq(string[] names)
    {
        // IEnumerable<string> query = from s in names
        //    where s.Length == 5
        //   orderby s
        //   select s.ToUpper();

        IEnumerable<string> query = names
                                    .Where(s => s.Length == 5)
                                    .OrderBy(s => s)
                                    .Select(s => s.ToLower());

        foreach (string item in query)
        
            Console.WriteLine(item);

            Console.Read();
        
    }
}
