using System;

public class calcu
{
    static int add(int a, int b) => a+b;
    static int sub(int a, int b) => a-b;
    static int mul(int a, int b) => a*b;
    static double div(int a, int b) => (b == 0) ? 0 : (double)a / b;

   static void Main()
   {
       Console.WriteLine(add(3,4));
       Console.WriteLine(sub(3,4));
       Console.WriteLine(mul(3,4));
      Console.WriteLine(div(3,4));
   }

    }