class Program
{
    static void Main()
    {
        List<int> list = new List<int>();
        list.Add(6);
        list.Add(7);
        list.Add(18);

        foreach (int num in list)
        {
            Console.WriteLine(num);
        }
    }
}