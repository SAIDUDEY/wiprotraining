class Program
{
    static int Sum(int e, int y)
    {
        return e + y;
    }

    static void Main()
    {
        Func<int, int, int> add = Sum;

       int result = add(10, 19);

       Console.WriteLine(result);
    }
}