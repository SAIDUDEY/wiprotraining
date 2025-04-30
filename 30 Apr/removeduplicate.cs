using System;

public class RemoveDuplicates
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 2, 4, 1 };
        int n = numbers.Length;
        int[] unique = new int[n];
        int index = 0;

        for (int i = 0; i < n; i++)
        {
            int alreadyExists = 0;

            for (int j = 0; j < index; j++)
            {
                if (numbers[i] == unique[j])
                {
                    alreadyExists = 1;
                    break;
                }
            }

            if (alreadyExists == 0)
            {
                unique[index] = numbers[i];
                index++;
            }
        }

        Console.Write("Array without duplicates: ");
        for (int i = 0; i < index; i++)
        {
            Console.Write(unique[i] + " ");
        }
    }
}