class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("starting all task..");

        Task task1 = DoAsyncWork("task 1", 2000);
        Task task2 = DoAsyncWork("task 2", 3000);
        Task task3 = DoAsyncWork("task 3", 1000);

        await Task.WhenAll(task1, task2, task3);

        Console.WriteLine("all task completed");
    }

    static async Task DoAsyncWork(string name, int delay)
    {
        Console.WriteLine($"{name} started.");

        await Task.Delay(delay);

        Console.WriteLine($"{name} completed after {delay}ms.");
    }
}