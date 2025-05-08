using System;

class Program
{
    static void Main()
    {
        Dictionary<string, string> cities = new Dictionary<string, string>();

        cities.Add("chennai", "tamil nadu");
        cities.Add("hyderabad", "telengana");
        cities.Add("amaravathi", "AP");
        cities.Add("mumbai", "maharastra");

        Console.WriteLine("indian cities and there states: ");




        foreach(var city in cities)
        {
            Console.WriteLine("city :" + city.Key + " and " + "state : " + city.Value);

        }

        if (cities.ContainsKey("hyderabad"))
            Console.WriteLine("hyderabad exists");
        else Console.WriteLine("hyderabad not exists");

        if (cities.ContainsValue("karnataka"))
            Console.WriteLine(" karnataka exists");
        else Console.WriteLine("karnataka not exists");
    }

}
