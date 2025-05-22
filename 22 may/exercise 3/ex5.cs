using System;
using System.Collections.Generic;

class Course
{
    public int Id;
    public string Title;
    public double Fee;

    public Course(int id, string title, double fee)
    {
        Id = id;
        Title = title;
        Fee = fee;
    }
}

interface IEnrollable
{
    void Enroll(Course course);
    void Enroll(Course course, string couponCode);
}

class User : IEnrollable
{
    private List<Course> enrolledCourses = new List<Course>();
    private List<double> finalFees = new List<double>();

    public void Enroll(Course course)
    {
        enrolledCourses.Add(course);
        finalFees.Add(course.Fee);
    }

    public void Enroll(Course course, string couponCode)
    {
        double discount = 0;
        if (couponCode == "SAVE10")
            discount = 0.10;
        else if (couponCode == "SAVE20")
            discount = 0.20;

        double discountedFee = course.Fee * (1 - discount);
        enrolledCourses.Add(course);
        finalFees.Add(discountedFee);
    }

    public void PrintEnrolledCourses()
    {
        for (int i = 0; i < enrolledCourses.Count; i++)
        {
            Console.WriteLine($"Course: {enrolledCourses[i].Title}, Final Fee: ₹{finalFees[i]}");
        }
    }
}

class Program
{
    static void Main()
    {
        Course c1 = new Course(101, "C# Basics", 5000);
        Course c2 = new Course(102, "Advanced C#", 7000);

        User user = new User();
        user.Enroll(c1);
        user.Enroll(c2, "SAVE10");

        user.PrintEnrolledCourses();
    }
}