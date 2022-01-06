using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace AbortThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(PrintNumberWithDelay);
            thread.Start();
            Thread.Sleep(TimeSpan.FromSeconds(6));
            thread.Abort();
            WriteLine("A thread has been aborted");
            Thread thread0 = new Thread(PrintNumbers);
            thread0.Start();
            PrintNumbers();
            Read();
        }
        static void PrintNumbers()
        {
            WriteLine("Starting......");
            for (int i = 0; i < 10; i++)
            {
                WriteLine(i);
            }
        }
        static void PrintNumberWithDelay()
        {
            WriteLine("Starting......");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(2));
                WriteLine(i);
            }
        }
    }
}
