using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public int EmployeeID { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create a List<Employee> to store multiple employees.
        List<Employee> employees = new List<Employee>();

        // Add at least 5 employees to the list.
        employees.Add(new Employee { EmployeeID = 101, Name = "seshu", Salary = 55000 });
        employees.Add(new Employee { EmployeeID = 102, Name = "vinay", Salary = 62000 });
        employees.Add(new Employee { EmployeeID = 103, Name = "subhash", Salary = 48000 });
        employees.Add(new Employee { EmployeeID = 104, Name = "David", Salary = 70000});
        employees.Add(new Employee { EmployeeID = 105, Name = "vanmshi", Salary = 58000});

        // Print the name and salary of the employee with the highest salary.
        Employee highestSalaryEmployee = employees.OrderByDescending(e => e.Salary).FirstOrDefault();

        if (highestSalaryEmployee != null)
        {
            Console.WriteLine("Employee with the highest salary:");
            Console.WriteLine($"Name: {highestSalaryEmployee.Name}, Salary: {highestSalaryEmployee.Salary:C}");
        }
        else
        {
            Console.WriteLine("No employees in the list.");
        }

        Console.WriteLine();

        // Store employee ID and Name in a Dictionary.
        Dictionary<int, string> employeeNameById = employees.ToDictionary(e => e.EmployeeID, e => e.Name);

        // Display the dictionary contents.
        Console.WriteLine("Employee ID to Name Dictionary:");
        foreach (var entry in employeeNameById)
        {
            Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
        }

        Console.WriteLine();

        // Search for an employee by ID and print the name if found.
        Console.Write("Enter an Employee ID to search: ");
        if (int.TryParse(Console.ReadLine(), out int searchId))
        {
            if (employeeNameById.ContainsKey(searchId))
            {
                Console.WriteLine($"Employee with ID {searchId} found. Name: {employeeNameById[searchId]}");
            }
            else
            {
                Console.WriteLine($"Employee with ID {searchId} not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for Employee ID.");
        }
    }
}
