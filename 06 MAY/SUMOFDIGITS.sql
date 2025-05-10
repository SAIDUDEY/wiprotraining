using System;
class program { 
public static void Main(string[] args)
{
    int num = int.Parse(Console.ReadLine());
    int sum = 0;
    Method(num, sum);
}
public static void Method(int num, int sum)
{
    while (num > 0)
    {
        int last= num % 10;
        sum += last;
        num = num / 10;
    }
    Console.WriteLine(sum);
}
}
