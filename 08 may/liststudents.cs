using System;

class Student {
    public int ID { get; set; }
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student> 
        {
        new Student (ID = 1; Name = "alice" );
        new Student (ID = 2; name = "bob");

    };

    students.Add(new Student {ID = 3; Name = "loe" });
foreach (var Student in students) {
    Console.WriteLine($"ID:{student.ID}, Name: {student.Name}");
}


}
}
