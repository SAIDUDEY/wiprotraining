class Program
{
    static bool pause = false;
    static bool stop = false;

    static void DoWork()
    {
        while(!stop)
        {
            if(pause)
            {
                Console.WriteLine("thread pause");
                Thread.Sleep(500);
                continue;
            }
            Console.WriteLine("thread not working");
            Thread.Sleep(500);

        }
        Console.WriteLine("threading is stop");
    }
    static void Main()
    {
        Thread worker = new Thread(DoWork);

        Console.WriteLine("intialize thread state :" + worker.ThreadState);
        worker.Start();

        Thread.Sleep(3000);
        pause= true;
        Console.WriteLine("pause thread state: " + worker.ThreadState);

        Thread.Sleep(3000);
        pause = false;
        Console.WriteLine("Remaining work..");

        Thread.Sleep(3000);
        stop = true;
        Console.WriteLine("stopping thread");

        worker.Join();

        Console.WriteLine("final thread state: " + worker.ThreadState);
    }
}