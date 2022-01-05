using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using static System.Threading.Thread;
using static System.Diagnostics.Process;

namespace PriorityThread
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"Current thread priority:{Thread.CurrentThread.Priority}");
            WriteLine("Running on all cores avaliable");
            RunThread();
            Sleep(TimeSpan.FromSeconds(2));
            WriteLine("Running on a singgle core");
            GetCurrentProcess().ProcessorAffinity = new IntPtr(1);
            RunThread();
            ReadLine();
        }
        static void RunThread()
        {
            var sample = new ThreadSample();
            var thread1 = new Thread(sample.CountNumbers);
            thread1.Name = "Thread1";
            var thread2 = new Thread(sample.CountNumbers);
            thread2.Name = "Thread2";

            thread1.Priority = ThreadPriority.Highest;
            thread2.Priority = ThreadPriority.Lowest;
            thread1.Start();
            thread2.Start();
            Sleep(TimeSpan.FromSeconds(2));
            sample.Stop();
        }
    }
    class ThreadSample
    {
        private bool _isStoped=false;
        public void Stop()
        {
            _isStoped = true;
        }
        public void CountNumbers()
        {
            long counter = 0;
            while (!_isStoped)
            {
                counter++;
            }
            WriteLine($"{CurrentThread.Name} with {CurrentThread.Priority,11} priority,has a count = {counter}");
        }
    }
}
