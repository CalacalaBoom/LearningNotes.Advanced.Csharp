using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using static System.Threading.Thread;

namespace ForegroundThreadAndBackgroundThread
{
    class Program
    {
        static void Main(string[] args)
        {
            var sampleForeground = new ThreadSample(10);
            var sampleBackground = new ThreadSample(90);

            var thread1 = new Thread(sampleForeground.CountNumbers);
            thread1.Name = "ForegroundThread";
            var thread2 = new Thread(sampleBackground.CountNumbers);
            thread2.Name = "BackgroundThread";
            thread2.IsBackground = true;
            thread1.Start();
            thread2.Start();
        }
    }
    class ThreadSample
    {
        private readonly int _iterations;
        public ThreadSample(int iterations)
        {
            _iterations = iterations;
        }
        public void CountNumbers()
        {
            for (int i = 0; i < _iterations; i++)
            {
                Sleep(TimeSpan.FromSeconds(0.5));
                WriteLine($"{CurrentThread.Name} prints {i}");
            }
        }

    }
}
