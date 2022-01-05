using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadingPriority
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread mythread1 = new Thread(new ThreadStart(createThread1));
            mythread1.Priority = ThreadPriority.Lowest;
            Thread mythread2 = new Thread(new ThreadStart(createThread2));
            mythread2.Priority = ThreadPriority.Highest;
            mythread1.Start();
            mythread2.Start();
            Console.Read();
        }
        public static void createThread1()
        {
            Console.WriteLine("线程一执行");
        }
        public static void createThread2()
        {
            Console.WriteLine("线程二执行");
        }
    }
}
