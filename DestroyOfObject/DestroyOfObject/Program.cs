using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestroyOfObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex ex = new Ex();
            ex = null;
            GC.Collect();
            Console.ReadLine();
        }
    }
    class Ex
    {
        ~Ex()
        {
            Console.WriteLine("Ex的实例化对象已销毁");
        }
    }
}
