using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace AutoResetEventEx
{
    class Program
    {
        private static AutoResetEvent _workerEvent = new AutoResetEvent(false);
        private static AutoResetEvent _mainEvent = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            new Thread(() => Process(1)).Start();
            WriteLine("_main:Waiting for another thread to complete its work");
            _workerEvent.WaitOne();
            WriteLine("_main:Starting a long running work...");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            WriteLine("_main:Work is done!");
            _mainEvent.Set();
            WriteLine("_main:Waiting for another thread to complete its second work");
            _workerEvent.WaitOne();
            WriteLine("_main:Starting second operation...");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            WriteLine("_main:Work is done!");
            Read();
        }
        static void Process(int second)
        {
            WriteLine("_worker:Starting a long running work...");
            Thread.Sleep(TimeSpan.FromSeconds(second));
            WriteLine("_worker:Work is done!");
            _workerEvent.Set();
            WriteLine("_worker:Waiting for a main thread to complete its work");
            _mainEvent.WaitOne();
            WriteLine("_worker:Starting second operation...");
            Thread.Sleep(TimeSpan.FromSeconds(second));
            WriteLine("_worker:Work is done!");
            _workerEvent.Set();
        }
    }
}
