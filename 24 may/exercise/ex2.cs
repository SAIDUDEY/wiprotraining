using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread thread1 = new Thread(() => { for (int i = 1; i <= 5; i++) { Console.WriteLine($"Print Task: {i}"); Thread.Sleep(200); } });
        Thread thread2 = new Thread(() => { int sum = 0; for (int i = 1; i <= 5; i++) { sum += i; Console.WriteLine($"Compute Task: Sum is {sum}"); Thread.Sleep(300); } });
        Thread thread3 = new Thread(() => { Console.WriteLine("Wait Task: Waiting for 2 seconds..."); Thread.Sleep(2000); Console.WriteLine("Wait Task: Done waiting."); });

        thread1.Start();
        thread2.Start();
        thread3.Start();

        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.WriteLine("All tasks done.");
    }
}
