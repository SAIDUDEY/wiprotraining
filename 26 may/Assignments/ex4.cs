using System;
using System.Collections.Generic;
using System.Threading;

public class DynamicWorker
{
    private static Queue<string> taskQueue = new Queue<string>();
    private static readonly object queueLock = new object(); 
    private static ManualResetEvent allTasksProcessed = new ManualResetEvent(false); 

    public static void Main(string[] args)
    {
        Console.WriteLine("Main thread: Starting worker thread...");

        
        Thread workerThread = new Thread(ProcessTasks);
        workerThread.Start();

        
        for (int i = 1; i <= 5; i++)
        {
            string task = $"Task {i}";
            Console.WriteLine($"Main thread: Enqueuing {task}");
            lock (queueLock)
            {
                taskQueue.Enqueue(task);
            }
            
            Thread.Sleep(100); 
        }

        Console.WriteLine("Main thread: All tasks enqueued. Waiting for worker to finish...");

        
        allTasksProcessed.WaitOne();

        Console.WriteLine("Main thread: Worker thread has finished processing all tasks. Exiting.");
    }

    private static void ProcessTasks()
    {
        Console.WriteLine("Worker thread: Started.");

        int tasksProcessedCount = 0;
        const int totalTasksToExpect = 5; 

        while (true)
        {
            string task = null;

            lock (queueLock)
            {
                if (taskQueue.Count > 0)
                {
                    task = taskQueue.Dequeue();
                }
            }

            if (task != null)
            {
                Console.WriteLine($"Worker thread: Processing {task}");
                Thread.Sleep(500);
                tasksProcessedCount++;
            }
            else
            {
                
                if (tasksProcessedCount >= totalTasksToExpect)
                {
                    Console.WriteLine("Worker thread: All expected tasks processed. Signalling main thread.");
                    allTasksProcessed.Set(); 
                    break; 
                }
                else
                {
                    
                    Thread.Sleep(50); 
                }
            }
        }
        Console.WriteLine("Worker thread: Exiting.");
    }
}