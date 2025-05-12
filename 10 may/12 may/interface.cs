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