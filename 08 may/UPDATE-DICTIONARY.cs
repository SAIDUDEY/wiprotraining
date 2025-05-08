using System;

class Program
{
    static void Main()
    {
        Dictionary<int, string> students = new Dictionary<int, string>();

        students.Add(101, "bob");
        students.Add(102, "alice");
        students.Add(103, "charlie");

        Console.WriteLine(students);

        students[102] = "Ananya"; //updated here 
        
        Console.WriteLine("updated list : " + students);


        foreach(var pair in students)
        {
            Console.WriteLine("key id : "+ pair.Key + " " + "Name :" + pair.Value);
        }
    }

}
