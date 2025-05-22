class Students
{
    public string Name { get; set; }

    public double Marks { get; set; }
}

class Program
{
    static void Main()
    {
        List<Students> student = new List<Students>();

        student.Add(new Students { Name = "seshu", Marks = 11 });
        student.Add(new Students { Name = "vinay", Marks = 21 });
        student.Add(new Students { Name = "vamshi", Marks = 94 });
        student.Add(new Students { Name = " sai", Marks = 100 });
        student.Add(new Students { Name = "vinod", Marks = 35 });
        student.Add(new Students { Name = "nitin", Marks = 49 });

        var linqStudents = student.OrderByDescending(s => s.Marks)
            .Take(3)
            .ToList();

        Console.WriteLine("top 3 Students");

        foreach (Students students in linqStudents)
        {
            Console.WriteLine(students.Name);
        }


    }
}