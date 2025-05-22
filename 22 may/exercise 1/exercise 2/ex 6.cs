
using Microsoft.Win32.SafeHandles;

class Vowels
{
    static void Main()
    {
        List<string> list = new List<string>() { "Abhi", "Vinay", "Alice", "Bob", "Dude", "Sai", "Seshu", "Emanuel" };

        var vowelnames = list.Where(name => "AEIOU".Contains(char.ToUpper(name[0])))
            .ToList();

        Console.WriteLine("names start with vowel words");

        foreach( var vowel in vowelnames ) Console.WriteLine(vowel);
            

    }
}