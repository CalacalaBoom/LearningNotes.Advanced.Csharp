using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadingLock
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myprograme = new Program();
            myprograme.LockThread();
            Console.Read();
        }
        void LockThread()
        {
            lock (this)
            {
                Console.WriteLine("锁定线程以实现线程同步");
            }
        }
    }
}
