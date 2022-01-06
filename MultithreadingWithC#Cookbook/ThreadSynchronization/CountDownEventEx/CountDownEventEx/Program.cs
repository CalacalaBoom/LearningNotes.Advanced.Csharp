using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using static System.Threading.Thread;

namespace CountDownEventEx
{
    class Program
    {
        static CountdownEvent _countdown = new CountdownEvent(2);
        static void Main(string[] args)
        {
            WriteLine("Starting two opreations");
            new Thread(() => PerformOperation("Operation 1 is completed", 4)).Start();
            new Thread(() => PerformOperation("Operation 2 is completed", 8)).Start();
            _countdown.Wait();
            WriteLine("Both operatins have been completed.");
            _countdown.Dispose();
            ReadLine();
        }
        static void PerformOperation(string message, int seconds)
        {
            Sleep(TimeSpan.FromSeconds(seconds));
            WriteLine(message);
            _countdown.Signal();
        }
        
    }
}
