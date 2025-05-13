public class Employee
{
    public int EmployeeId { get; set; }
    public required string EmployeeName { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Employee[] EmployeeArray =
        {
            new Employee() { EmployeeId = 1, EmployeeName = "john", Age = 21},
            new Employee() {EmployeeId = 2, EmployeeName = "sesh", Age=24},
            new Employee() { EmployeeId = 3, EmployeeName = "vinay", Age = 20},
            new Employee() {EmployeeId = 4, EmployeeName = "vamshi", Age=12},

        };

        Employee[] Employees = new Employee[10];

        int i = 0;

        foreach(Employee employee in EmployeeArray)
        {
            if(employee.Age>12 && employee.Age <20)
            {
                Employees[i] = employee;
                System.Console.WriteLine(employee.EmployeeName);
                i++;
            }
        }
    }
}

OR

public class Employee
{
    public int EmployeeId { get; set; }
    public required string EmployeeName { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Employee[] employeeArray =
        {
            new Employee() { EmployeeId = 1, EmployeeName = "john", Age = 21},
            new Employee() {EmployeeId = 2, EmployeeName = "sesh", Age=24},
            new Employee() { EmployeeId = 3, EmployeeName = "vinay", Age = 20},
            new Employee() {EmployeeId = 4, EmployeeName = "vamshi", Age=12},

        };

        Employee[] teenAgerEmployees = employeeArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();
        Employee sesh = employeeArray.Where(s => s.EmployeeName == "seshu").FirstOrDefault();
        Employee Employee4 = employeeArray.Where(s => s.EmployeeId == 4).FirstOrDefault();


       
    }
}