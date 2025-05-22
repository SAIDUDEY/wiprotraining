using System.Data.Common;

class Program
{
    static void Main()
    {
        string str = "c# is great and c# is fun";

        string[] words = str.Split(' ');


        var wordfrequency = words.GroupBy(w => w)
            .Select(group => new { word = group.Key, Count = group.Count() });

        foreach (var word in wordfrequency)
        {
            Console.WriteLine(word.word + "=" + word.Count);
        }
    }
}