using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Task[] tasks = {
            SimulateWorkAsync("Task 1", 1000),
            SimulateWorkAsync("Task 2", 1500),
            SimulateWorkAsync("Task 3", 1200)
        };

        var sw = Stopwatch.StartNew();
        foreach (var t in tasks)
            await t; // Sequential awaits
        sw.Stop();
        Console.WriteLine($"Sequential time: {sw.ElapsedMilliseconds} ms");

        sw.Restart();
        await Task.WhenAll(
            SimulateWorkAsync("Task 1", 1000),
            SimulateWorkAsync("Task 2", 1500),
            SimulateWorkAsync("Task 3", 1200)
        );
        sw.Stop();
        Console.WriteLine($"Parallel time: {sw.ElapsedMilliseconds} ms");
    }

    static async Task SimulateWorkAsync(string name, int delay)
    {
        await Task.Delay(delay);
        Console.WriteLine($"{name} done");
    }
}
