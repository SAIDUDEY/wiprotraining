using System;

class LongestWords
{
    public static string longest(string a)
    {
        string[] str = a.Split(' ');
        string Largeword = " ";
        int maxlength = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i].Length > maxlength)
            {
                maxlength = str[i].Length;
                Largeword = str[i];
            }

        }
        return Largeword;
    }
    public static void Main(string[] args)
    {
        string s = " learning c# is really intersting";
        string result = longest(s);

        Console.WriteLine(result);

        Console.WriteLine("THE LENGTH IS: +result.Length");
    }
}
