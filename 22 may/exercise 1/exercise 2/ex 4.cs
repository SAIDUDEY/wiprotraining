class Duplicatenum
{
    static void Main()
    {
        List<int> list = new List<int> { 1, 3, 3, 4, 2, 4, 2, 4, 6, 7, 9 };

        var dup = list.GroupBy(l => l)
            .Where(l => l.Count() >1)
            .Select(l => l.Key)
            .ToList();

        Console.WriteLine("duplicate num :");

        foreach (var item in dup) Console.WriteLine(item);
            



    }
}