using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace SemaphoreSlimeEx
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                string threadname = "Thread" + i;
                int secondsToWait = 2 + 2 * i;
                new Thread(() => AccessDatabase(threadname, secondsToWait)).Start();
            }
            
        }
        static SemaphoreSlim _semaphore = new SemaphoreSlim(4);
        static void AccessDatabase(string name, int second)
        {
            WriteLine($"{name} waits to access a database");
            _semaphore.Wait();
            WriteLine($"{name} was granted an acess to a database");
            Thread.Sleep(TimeSpan.FromSeconds(second));
            WriteLine($"{name} is completed");
            _semaphore.Release();
        }
    }
}
