using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var task1 = Task.Delay(3000).ContinueWith(_ => "Task 1");
        var task2 = Task.Delay(1000).ContinueWith(_ => "Task 2");
        var task3 = Task.Delay(2000).ContinueWith(_ => "Task 3");

        Task<string> firstFinished = await Task.WhenAny(task1, task2, task3);
        Console.WriteLine($"{firstFinished.Result} finished first.");
    }
}