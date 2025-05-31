using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment
{
    class Student
    {
        public string Name { get; set; }
        public Dictionary<string, int> Marks { get; set; } = new();
        public double Average => Marks.Count > 0 ? Marks.Values.Average() : 0;
        public int Highest => Marks.Count > 0 ? Marks.Values.Max() : 0;
        public int Lowest => Marks.Count > 0 ? Marks.Values.Min() : 0;
        public int Total => Marks.Values.Sum();
    }

    class StudentGradebook
    {
        static void Main(string[] args)
        {
            // Initialize a list to hold students
            List<Student> students = new();

            Console.WriteLine("Welcome to the Student Gradebook System!");
            Console.WriteLine("You can enter student names and their marks for various subjects.");
            Console.WriteLine("The system will calculate the average, highest, lowest marks and total for each student.");
            Console.WriteLine("It will also display the top 3 scorers based on total marks.\n");
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter number of subjects: ");
            int m = int.Parse(Console.ReadLine());

            List<string> subjects = new();
            for (int i = 0; i < m; i++)
            {
                Console.Write($"Enter subject {i + 1} name: ");
                subjects.Add(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"\nEnter name of student {i + 1}: ");
                string name = Console.ReadLine();
                var student = new Student { Name = name };

                foreach (var subject in subjects)
                {
                    Console.Write($"Enter marks for {subject}: ");
                    int mark = int.Parse(Console.ReadLine());
                    student.Marks[subject] = mark;
                }
                students.Add(student);
            }

            // Displaying student results and calculations
            Console.WriteLine("\nStudent Results:");
            Console.WriteLine("--------------------");

            foreach (var student in students)
            {
                Console.WriteLine($"\nName: {student.Name}");
                Console.WriteLine("Marks: " + string.Join(", ", student.Marks.Select(kv => $"{kv.Key}: {kv.Value}")));
                Console.WriteLine($"Average: {student.Average:F2}, Highest: {student.Highest}, Lowest: {student.Lowest}");
            }

            // Top 3 scorers by total marks
            var top3 = students.OrderByDescending(s => s.Total).Take(3).ToList();
            Console.WriteLine("\nTop 3 Scorers:");
            for (int i = 0; i < top3.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {top3[i].Name} - Total: {top3[i].Total}, Average: {top3[i].Average:F2}");
            }
        }
    }
}