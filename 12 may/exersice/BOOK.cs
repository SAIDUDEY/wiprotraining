abstract class Book
{
    public abstract void Read();

    public void GetInfo()
    {
        Console.WriteLine("this is book");
    }

}

class FictionBook : Book
{
    public override void Read()
    {
        Console.WriteLine("reading fictional book");
        
    }
}

class ScienceBook : Book
{
    public override void Read()
    {
        Console.WriteLine("reading science book");
    }
}

class Program
{
    static void Main()
    {
        Book b;
        b = new FictionBook();
        b.Read();
        b.GetInfo();
        

        b = new ScienceBook();
        b.Read();
        b.GetInfo();
    }
}