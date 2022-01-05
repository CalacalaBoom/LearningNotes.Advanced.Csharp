using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadingJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread mythread = new Thread(new ThreadStart(createThread));
            mythread.Start();
            mythread.Join();
            Console.Read();
        }
        public static void createThread()
        {
            Console.Write("创建了一个新线程");
        }
    }
}
