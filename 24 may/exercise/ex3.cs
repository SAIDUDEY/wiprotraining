using System;
using System.Threading;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            int item = i; // Capture loop variable
            ThreadPool.QueueUserWorkItem(ProcessItem, item);
        }

        // Wait for the user to press a key to allow time for ThreadPool tasks to complete
        Console.WriteLine("Processing items in thread pool...");
        Console.ReadLine();
    }

    static void ProcessItem(object item)
    {
        Console.WriteLine($"Processing item {item} started.");
        Thread.Sleep(500); // Simulate some work with delay
        Console.WriteLine($"Processing item {item} completed.");
    }
}
