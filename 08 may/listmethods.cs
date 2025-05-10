using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> cars = new List<string>() { "polo", "hycross", "beleno" };
        cars.Add("cresta");
        cars.Insert(3, "innova");

        cars.Remove("hycross");
        cars.RemoveAt(3);
        cars.Sort();

        foreach (string speed in cars)
        {
            Console.WriteLine(speed);
        }
    }
}