using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace SleepThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(PrintNumbersWithDelay);
            thread.Start();
            PrintNumbers();
            ReadLine();
        }
        static void PrintNumbers()
        {
            WriteLine("Starting......");
            for (int i = 0; i < 10; i++)
            {
                WriteLine(i);
            }
        }
        static void PrintNumbersWithDelay()
        {
            WriteLine("Starting......");
            for (int i = 11; i < 20; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(2));
                WriteLine(i);
            }
        }
    }
}
