interfaace IShape
{
    void Draw();
}

class circle : IShape
{
    public void Draw()
    {
        Console.WrieLine("Drawing a circle");
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