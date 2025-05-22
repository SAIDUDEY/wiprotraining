class Employee

{
    static void Main()
    {
        Dictionary<int,decimal> employee = new Dictionary<int,decimal>();

        employee.Add( 1 , 3000);
        employee.Add( 2, 4000);
        employee.Add( 3,4000);
        employee.Add( 4, 5000);

        Console.WriteLine("enter employee id :");

        int id = Convert.ToInt32(Console.ReadLine());

        if(employee.ContainsKey(id))
        {
            Console.WriteLine(employee[id]);

        }
        else
        {
            Console.WriteLine("invalid");
        }

    }
}