using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Threading.Thread;
using static System.Console;

namespace BarrierEx
{
    class Program
    {
        static Barrier _barrier = new Barrier(2, b => WriteLine($"End of phase {b.CurrentPhaseNumber + 1}"));
        static void Main(string[] args)
        {
            new Thread(() => PlayMusic("the guitarist", "play an amazing solo", 2)).Start();
            new Thread(() => PlayMusic("the singer", "sing his song", 2)).Start();
            Read();
        }
        static void PlayMusic(string name, string message, int seconds)
        {
            for (int i = 1; i < 3; i++)
            {
                WriteLine("--------------------");
                Sleep(TimeSpan.FromSeconds(seconds));
                WriteLine($"{name} starts to {message}");
                Sleep(TimeSpan.FromSeconds(seconds));
                WriteLine($"{name} finishes to {message}");
                _barrier.SignalAndWait();
            }
        }

    }
}
