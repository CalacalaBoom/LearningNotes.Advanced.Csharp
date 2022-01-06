using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using static System.Threading.Thread;

namespace SpinWaitEx
{
    class Program
    {
        static volatile bool _isCompleted = false;
        static void Main(string[] args)
        {
            var t1 = new Thread(UserModeWait);
            var t2 = new Thread(HybridSpinWait);

            WriteLine("Running user mode waiting");
            t1.Start();
            Sleep(20);
            _isCompleted = true;
            Sleep(TimeSpan.FromSeconds(1));
            _isCompleted = false;
            WriteLine("Runnig hybrid SpinWait construct waiting");
            t2.Start();
            Sleep(5);
            _isCompleted = true;

            Read();
        }
        static void UserModeWait()
        {
            while (!_isCompleted)
            {
                Write(".");
            }
            WriteLine("\nWaiting is completed");
        }
        static void HybridSpinWait()
        {
            var w = new SpinWait();
            while (!_isCompleted)
            {
                w.SpinOnce();

                WriteLine(w.NextSpinWillYield);
            }
            WriteLine("Waiting is completed");
        }
    }
}
