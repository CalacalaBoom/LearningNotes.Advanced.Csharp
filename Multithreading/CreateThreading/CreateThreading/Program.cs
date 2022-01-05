using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CreateThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread mythread = new Thread(new ThreadStart(CreateThread));
            mythread.Start();
            Console.ReadLine();
        }
        public static void CreateThread()
        {
            Console.Write("创建一个线程");
        }
    }
}
