using System;

public class FindLargest
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the value of a:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value of b:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value of c:");
        int c = int.Parse(Console.ReadLine());

        int largest;

        if (a >= b && a >= c)
        {
            largest = a;
        }
        else if (b >= a && b >= c)
        {
            largest = b;
        }
        else
        {
            largest = c;
        }

        Console.WriteLine($"The largest number is: {largest}");
    }
}
   