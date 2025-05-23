class Program
{
    static void DoWork(object state)
    {
        Console.WriteLine($"threadpool Task Started - {state}");
        Thread.Sleep(1000);
        Console.WriteLine($"threadpool task finished - {state}");
    }
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            ThreadPool.QueueUserWorkItem(DoWork, $"task {i}");
        }

        Console.WriteLine("main thread continues..");
        Thread.Sleep(1000);
        Console.WriteLine("Main thread ends..");
    }
}