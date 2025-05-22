class Program
{
    static void Main()
    {
        List<int> num = new List<int> { 2, 4, 1, 5, 6, 9, 22, 54, 21, 45, 11 };

        var evennum =num.Where(num => num % 2 == 0)
            .ToList();

        var oddnum = num.Where(num => num % 2 != 0)
            .ToList();

        Console.WriteLine("odd num :");

        foreach(var even  in evennum)
        {
            Console.WriteLine(even);
        }

        Console.WriteLine();
        Console.WriteLine("even num :");

        foreach(var odd in oddnum)
        {
            Console.WriteLine(odd);
        }
    }
}