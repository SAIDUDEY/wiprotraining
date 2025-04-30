using System;

public class LinearSearch
{
    static void Main()
    {
        int[] numbers = { 3, 5, 7, 8, 2, 9, 10 };
        Console.Write("Enter a number to search: ");
        int target = int.Parse(Console.ReadLine());

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                Console.WriteLine($"Output: {i}");
                return;  
            }
        }

        Console.WriteLine("Not found");
    }
}