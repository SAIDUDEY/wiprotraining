using System;
using System.Linq;

class Uniquelements
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2 ,3, 4, 2, 4, 2, 1, 4, 6, 3 };
        HashSet<int> unique = new HashSet<int>(numbers); 
        Console.WriteLine("unique :");

        foreach (int i in unique)
        {
            Console.WriteLine(i + " ");
        }

        Console.WriteLine("num of unique elements: " + unique.Count);
    }
    
}