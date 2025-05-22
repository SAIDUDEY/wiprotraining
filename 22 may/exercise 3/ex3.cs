using System;
using System.Collections.Generic;


interface IAttendance
{
    void MarkAttendance();
}


abstract class Staff
{
    public int Id;
    public string Name;
    public string Department;

    public Staff(int id, string name, string dept)
    {
        Id = id;
        Name = name;
        Department = dept;
    }

    public abstract double CalculateSalary();
}


class PermanentStaff : Staff, IAttendance
{
    public double Salary;

    public PermanentStaff(int id, string name, string dept, double salary)
        : base(id, name, dept)
    {
        Salary = salary;
    }

    public override double CalculateSalary()
    {
        return Salary;
    }

    public void MarkAttendance()
    {
        Console.WriteLine($"{Name} marked attendance (Permanent).");
    }
}


class ContractStaff : Staff, IAttendance
{
    public int Hours;
    public double Rate;

    public ContractStaff(int id, string name, string dept, int hours, double rate)
        : base(id, name, dept)
    {
        Hours = hours;
        Rate = rate;
    }

    public override double CalculateSalary()
    {
        return Hours * Rate;
    }

    public void MarkAttendance()
    {
        Console.WriteLine($"{Name} marked attendance (Contract).");
    }
}


class Program
{
    static void Main()
    {
        List<Staff> staffList = new List<Staff>
        {
            new PermanentStaff(1, "Alice", "HR", 50000),
            new ContractStaff(2, "Bob", "IT", 120, 250),
            new PermanentStaff(3, "Charlie", "Finance", 60000),
            new ContractStaff(4, "David", "Support", 100, 200)
        };

        Console.WriteLine("Staff Details:\n");

        foreach (var s in staffList)
        {
            Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Dept: {s.Department}");
            Console.WriteLine($"Salary: ₹{s.CalculateSalary()}");

            if (s is IAttendance att)
            {
                att.MarkAttendance();
            }

            Console.WriteLine();
        }
    }
}
