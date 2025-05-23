class Program
{
    static void DoWork(string name)
    {
        for (int i = 1; i <= 3; i++) {
            Console.WriteLine($"thread {name} - step{i}");
            Thread.Sleep(500);
        }
        Console.WriteLine($"thread {name} finised");
    }

    static void Main()
    {

        Thread t1 = new Thread(() => DoWork("A"));

        Thread t2 = new Thread(() => DoWork("B"));

        Thread t3 = new Thread(() => DoWork("c"));

        t1.Start();
        t1.Join();

        t2.Start();
        t2.Join();

        t3.Start();
        t3.Join();

        Console.WriteLine("all threads completed");

    }