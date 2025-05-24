using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string[] cities = { "New York", "London", "Tokyo" };

        foreach (var city in cities)
        {
            int temp = await GetTemperatureAsync(city);
            Console.WriteLine($"Temperature in {city} is {temp}°C");
        }
    }

    static async Task<int> GetTemperatureAsync(string city)
    {
        await Task.Delay(1000); // Simulate delay
        return new Random().Next(-10, 35); // Return random temperature
    }
}
