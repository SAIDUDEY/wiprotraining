class Program
{ 
    static void Main()
{
    List<int> numbers = new List<int> { 20, 30, 60, 50, 10 };

    int index = numbers.IndexOf(60);
    Console.WriteLine("index of 60 :" + index);

    bool contains = numbers.Contains(40);
    Console.WriteLine("contains 40 :" + contains);
}
}