using System;

public class Method
{
    static int add(int num1, int num2){
        return num1+num2;
    }
        static int sub(int num1, int num2){
        return num1-num2;
        }
        static int mul(int num1, int num2){
        return num1*num2;
        }
        
    static double add(double num1, double num2){
        return num1+num2;
    }
    static double sub(double num1, double num2){
        return num1-num2;
    }
    static double mul(double num1, double num2){
        return num1*num2;
    }
    static void Main()
    {
        Console.WriteLine(add(3,4));
        Console.WriteLine(add(3.4,4.3));
        
        Console.WriteLine();
        
         Console.WriteLine(sub(3,4));
        Console.WriteLine(sub(3.4,4.3));
        
        Console.WriteLine();
        
         Console.WriteLine(mul(3,4));
        Console.WriteLine(mul(3.4,4.3));
     
    }
    }
