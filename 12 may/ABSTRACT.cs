abstract class Shape
{
    public abstract void Draw();

    public void Display()
    {
        Console.WriteLine("this is shape");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("drawing a circle");
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle();
        circle.Draw();
    }
}

