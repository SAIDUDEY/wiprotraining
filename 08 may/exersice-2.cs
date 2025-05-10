using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList nums = new ArrayList() { 31, 19, 5, 43, 6, 27, 12, 4, 50 };

        //
        nums.Sort();
        nums.RemoveAt(2);

        

        foreach (int num in nums)
        {
            Console.WriteLine(num);
        }

        int max = (int)nums[nums.Count - 1];
        int min = (int)nums[0];

        Console.WriteLine("minimum value : " + min);
        Console.WriteLine("maximum value : " + max);


        if (nums.Count > 0)
        {
            double average = nums.Cast<int>().Average();
            Console.WriteLine("the avg num: " + average);
        }
        else
        {
            Console.WriteLine("not found");
        }


    }
}