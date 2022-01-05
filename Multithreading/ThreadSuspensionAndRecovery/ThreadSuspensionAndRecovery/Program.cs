using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadSuspensionAndRecovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread mythread = new Thread(new ThreadStart(CreateThread));
            mythread.Start();//开始线程
            mythread.Suspend();//挂起线程
            mythread.Resume();//继续线程
            Console.ReadLine();
        }
        public static void CreateThread()
        {
            Console.WriteLine("创建线程");
        }
    }
}
