using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace MutexEx
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MutexName = "CSharpThreadingCookbook";
            using (var m = new Mutex(false, MutexName))
            {
                if (!m.WaitOne(TimeSpan.FromSeconds(5), false))
                {
                    WriteLine("Second instance is running!");
                }
                else
                {
                    WriteLine("Running!");
                    Read();
                    m.ReleaseMutex();
                }
            }
        }
    }
}
