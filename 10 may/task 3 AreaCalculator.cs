using System;
class AreaCalculator
{
    
    public double Area(double length, double breadth)
    {
        return length * breadth;
    }

       public double Area(double radius)
    {
        return Math.PI * radius * radius;
    }

       public double Area(int baseLength, int height)
    {
        return 0.5 * baseLength * height;
    }
}

class Program
{
    static void Main()
    {
        AreaCalculator calc = new AreaCalculator();

               Console.WriteLine("Area of Rectangle (length=5, breadth=3): " + calc.Area(5.0, 3.0));

        Console.WriteLine("Area of Circle (radius=4): " + calc.Area(4.0));

           Console.WriteLine("Area of Triangle (base=6, height=2): " + calc.Area(6, 2));
    }
}