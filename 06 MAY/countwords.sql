class program
{
    public static void Main(string[] args)
    {
        int count = 0;
        string sentence = Console.ReadLine();
        string[] word = sentence.Split(" ");
        for (int i = 0; i < word.Length; i++)
        {
            count++;
        }
        Console.WriteLine(count);
    }
}