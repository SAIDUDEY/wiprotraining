using static SimpleDelegate;

class SimpleDelegate
{
    public delegate int SomeOperation(int a, int b);

}
class Program
{
    static int Sum(int e, int y)
    {
        return e + y;
    }

    static void Main()
    {
        SomeOperation add = Sum;

       int result = add(10, 19);

       Console.WriteLine(result);
    }
}