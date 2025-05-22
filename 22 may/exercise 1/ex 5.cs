class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }

}
class Program
{
    static void Main()
    {
        List<Employee> employee = new List<Employee>();

        employee.Add(new Employee { Name = " seshu", Department = "IT" });
        employee.Add(new Employee { Name = " vinay", Department = "IT" });
        employee.Add(new Employee { Name = "vinod", Department = "HR" });
        employee.Add(new Employee { Name = "vamshi", Department = "CAD" });
        employee.Add(new Employee { Name = "bala", Department = "CAD" });
        employee.Add(new Employee { Name = "sai", Department = "QA" });

        var linqEmployee = employee.GroupBy(e => e.Department)
        .ToList();

        foreach(var group in linqEmployee)
        {
            Console.WriteLine();
            Console.WriteLine("Department"+ " " + group.Key);

            foreach (var emp in group)
            {
                Console.WriteLine(emp.Name);
            }
        }
    }
}