using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using static System.Threading.Thread;

namespace ManualResetEventSlimEx
{
    class Program
    {
        static ManualResetEventSlim _mainEvent = new ManualResetEventSlim(false);
        static void Main(string[] args)
        {
            new Thread(() => TravelThroughGates("Thread1", 5)).Start();
            new Thread(() => TravelThroughGates("Thread2", 6)).Start();
            new Thread(() => TravelThroughGates("Thread3", 12)).Start();
            Sleep(TimeSpan.FromSeconds(6));
            WriteLine("The gates are now open!");
            _mainEvent.Set();
            Sleep(TimeSpan.FromSeconds(2));
            _mainEvent.Reset();
            WriteLine("The gates have been closed!");
            Sleep(TimeSpan.FromSeconds(10));
            WriteLine("The gates are now open for the second time!");
            _mainEvent.Set();
            Sleep(TimeSpan.FromSeconds(2));
            _mainEvent.Reset();
            WriteLine("The gates have been closed!");
        }
        static void TravelThroughGates(string threadname, int seconds)
        {
            WriteLine($"{threadname} falls to sleep");
            Sleep(TimeSpan.FromSeconds(seconds));
            WriteLine($"{threadname} waits for the gates to open!");
            _mainEvent.Wait();
            WriteLine($"{threadname} enters the gates!");
        }
    }
}
