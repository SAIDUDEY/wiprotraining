using System;

public class ifelse
{
    public static void Main(string[] args)
    {
        int marks = 30;
        
        if(marks >= 90){
            Console.WriteLine("Grade :A");
        }
        else if(marks >= 70){
            Console.WriteLine("Grade : B");
        }
        else if(marks >= 35){
            Console.WriteLine("Grade : C");
        }
         else
           Console.WriteLine("Grade : fail") ; 
        
    }
}