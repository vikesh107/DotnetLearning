using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Queue some work to the thread pool
        ThreadPool.QueueUserWorkItem(DoWork, "Hello from the ThreadPool!");

        // You can also queue more work if needed

        // Keep the console application running
        Console.ReadLine();
    }

    static void DoWork(object state)
    {
        // This method will be executed on a thread from the ThreadPool
        string message = (string)state;
        Console.WriteLine($"Working on thread from ThreadPool: {message}");
    }
}