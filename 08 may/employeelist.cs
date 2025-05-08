using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> employee = new List<string>() { "seshu", "vinay", "vinod" };
        employee.Add("vamshi");
        employee.Insert(3, "nithin");

        employee.Remove("vinay");
        employee.RemoveAt(3);

        if (employee.Contains("vamshi"))
            Console.WriteLine("name exists");
        else
            Console.WriteLine("name not exists");

            employee.Sort();


        foreach (string employees in employee)
        {
            Console.WriteLine(employees);
        }
        Console.WriteLine("count :" + employee.Count);
    }
}
