using System;
class Program
{
    public static void Main(string[] args)
    {
        int[] arr = new int[5];
        Console.WriteLine("enter the 5 array elements:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Method(arr);

    }
    public static void Method(int[] arr)
    {
        Array.Sort(arr);
        Console.WriteLine("THE 2ND LARGEST ELEMENT : " +arr[arr.Length - 2]);


    }
}
