using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using static System.Threading.Thread;

namespace JoinThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(PrintNumbersWithDelay);
            thread.Start();
            thread.Join();
            WriteLine("Thread completed");
            ReadLine();
        }
        static void PrintNumbersWithDelay()
        {
            WriteLine("Starting......");
            for (int i = 0; i < 10; i++)
            {
                Sleep(TimeSpan.FromSeconds(2));
                WriteLine(i);
            }
        }
    }
}
