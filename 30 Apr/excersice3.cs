using System;

public class Reverse
{
    public static int Rev(int n)
    {
        int r = 0;
        while (n > 0)
        {
            r = r * 10 + n % 10;
            n /= 10;
        }
        return r;
    }

    public static void Main(string[] args)
    {
        int num = 123;
        Console.WriteLine(Rev(num)); 
    }
}
