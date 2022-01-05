using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace CreateThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(PrintNumbers));
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
    }
}
