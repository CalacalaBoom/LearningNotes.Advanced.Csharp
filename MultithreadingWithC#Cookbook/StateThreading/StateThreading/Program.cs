using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace StateThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Starting programe......");
            Thread t = new Thread(PrintNumbersWithState);
            Thread t2 = new Thread(DoNothing);
            WriteLine(t.ThreadState.ToString());
            t2.Start();
            t.Start();
            for (int i = 0; i < 40; i++)
            {
                WriteLine(t.ThreadState.ToString());
            }
            Thread.Sleep(TimeSpan.FromSeconds(6));
            t.Abort();
            WriteLine("A thread has been aborted");
            WriteLine(t.ThreadState.ToString());
            WriteLine(t2.ThreadState.ToString());
            WriteLine("program is over");
            ReadLine();
        }
        static void DoNothing()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }
        static void PrintNumbersWithState()
        {
            WriteLine("Starting...");
            WriteLine(Thread.CurrentThread.ThreadState.ToString());
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(2));
                WriteLine(i);
            }
        }
    }
}
