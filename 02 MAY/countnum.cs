using System;

class Program
{
    
    static int CountZeroes(int number)
    {
        if (number == 0) 
        {
            return 0;
        }
        else
        {
            
            if (number % 10 == 0)
            {
                return 1 + CountZeroes(number / 10); 
            }
            else
            {
                return CountZeroes(number / 10); 
            }
        }
    }

    static void Main()
    {
       
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

       
        int result = CountZeroes(number);

        
        Console.WriteLine($"Number of zeroes in {number} is: {result}");
    }
}