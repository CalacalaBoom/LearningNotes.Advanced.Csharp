using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadingAbout
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread mythread = new Thread(new ThreadStart(Create));
            mythread.Start();
            mythread.Abort();
            Console.Read();
        }
        public static void Create()
        {
            Console.WriteLine("创建了一个线程");
        }
    }
}
