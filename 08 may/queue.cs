using System;

class Program
{
    static void Main()
    {
        Queue<String> queue = new Queue<string>();

        queue.Enqueue("sai");
        queue.Enqueue("seshu");
        queue.Enqueue("bala");
        

        foreach(var name in queue)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("dequeue :" + queue.Dequeue());
        
       Console.WriteLine("next line : " + queue.Peek());
    }
}