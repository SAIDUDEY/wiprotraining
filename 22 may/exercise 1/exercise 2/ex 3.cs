class Student
{
    public string Name {  get; set; }

    public double Marks {  get; set; }  
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        students.Add(new Student { Name = "seshu", Marks = 20 });
        students.Add(new Student { Name = "rahul", Marks = 45 });
        students.Add(new Student { Name = "vinay", Marks = 55 });
        students.Add(new Student { Name = "ravi", Marks = 99 });
        students.Add(new Student { Name = "vamshi", Marks = 44 });

        var average = students.Average(s => s.Marks);

        var Count = students.Count(s => s.Marks > average);

        Console.WriteLine("avg marks :" + average);

        Console.WriteLine(" above avg :" + Count);


    }
}