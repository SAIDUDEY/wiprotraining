using System;

public class SWitchCase
{
    public static void Main(string[] args)
    {
       int num = 12345;
       int sum=0;
       while(num>0){
           sum = sum+num%10;
           num = num/10;
       }
     Console.WriteLine(sum);
}
}  