using System;
using System.Collections.Immutable;
using System.Net.NetworkInformation;

class Student
{
    static void Main()
    {
        List<string> students = new List<string>();
         students.Add("bala");
        students.Add("vinay");
        students.Add("vamshi");
        students.Add("dude");
        students.Add("vinod");

        students.Sort();

        Console.WriteLine("students :");

        foreach (var student in students)
        { 
            
            Console.WriteLine(student);
        }

        
    }
}