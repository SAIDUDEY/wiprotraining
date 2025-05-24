using System;
using System.Threading;

class Program
{
    private static Thread _thread;
    private static bool _pause = false;
    private static bool _stop = false;

    static void Main()
    {
        _thread = new Thread(PrintNumbers);
        _thread.Start();

        Thread.Sleep(2000); // Pause for 2 seconds
        _pause = true; // Pause the thread
        Console.WriteLine("Thread paused.");

        Thread.Sleep(2000); // Wait for 2 seconds
        _pause = false; // Resume the thread
        Console.WriteLine("Thread resumed.");

        Thread.Sleep(2000); // Wait for 2 seconds
        _stop = true; // Stop the thread
        _thread.Join(); // Wait for the thread to finish
        Console.WriteLine("Thread has stopped.");
    }

    private static void PrintNumbers()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (_stop) break; // Stop if the flag is set
            while (_pause) Thread.Sleep(100); // Pause if the flag is set
            Console.WriteLine(i);
            Thread.Sleep(100); // Simulate work
        }
    }
}