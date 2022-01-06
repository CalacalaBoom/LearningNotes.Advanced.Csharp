using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Threading.Thread;
using static System.Console;

namespace PassParametersToTheThread
{
    class Program
    {
        static void Main(string[] args)
        {
            var sample = new ThreadSample(10);

            var thread1 = new Thread(sample.CountNumbers);
            thread1.Name = "Thread1";
            thread1.Start();
            thread1.Join();

            WriteLine("--------------------");

            var thread2 = new Thread(Count);
            thread2.Name = "Thread2";
            thread2.Start(8);
            thread2.Join();

            WriteLine("--------------------");

            var thread3 = new Thread(() => CountNumbers(12));
            thread3.Name = "Thread3";
            thread3.Start();
            thread3.Join();

            WriteLine("--------------------");

            int i = 10;
            var thread4 = new Thread(() => PrintNumbers(i));
            i = 20;
            var thread5 = new Thread(() => PrintNumbers(i));
            thread4.Start();
            thread5.Start();

            Read();
        }
        static void Count(object iterations)
        {
            CountNumbers((int)iterations);
        }
        static void CountNumbers(int iterations)
        {
            for (int i = 0; i < iterations; i++)
            {
                Sleep(TimeSpan.FromSeconds(0.5));
                WriteLine($"{CurrentThread.Name} prints {i}");
            }
        }
        static void PrintNumbers(int numbers)
        {
            WriteLine(numbers);
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
                    WriteLine($"{CurrentThread.Name} print {i}");
                }
            }
        }

    }
}
