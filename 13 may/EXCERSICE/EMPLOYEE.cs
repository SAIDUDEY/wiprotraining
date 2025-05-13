using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Employee
{
    public abstract void CalculateSalary();

    public void ShowBasicInfo()
    {
        Console.WriteLine("employee details");
    }
    
}

class FullTimeEmployee : Employee
{
    public override void CalculateSalary()
    {
    Console.WriteLine("basic salary : 13000.00" + " allowance : 10000.00");
    }  
    
}

class PartTimeEmployee : Employee
{
    public override void CalculateSalary()
    {
        Console.WriteLine("hourly rate * hourly worked" );
    }
}

class Program
{
    static void Main()
    {

        Employee employee;

        employee = new FullTimeEmployee();
        employee.CalculateSalary();
        employee.ShowBasicInfo();
        employee = new PartTimeEmployee();
        employee.CalculateSalary();
        employee.ShowBasicInfo();
    }
}
