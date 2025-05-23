class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("work started : ");

        await DoAsyncWork();

        Console.WriteLine("work completed.");
    }

    static async Task DoAsyncWork()
    {
        Console.WriteLine("working asychronously.");

        await Task.Delay(1000);

        Console.WriteLine("async work done.");
    }
}