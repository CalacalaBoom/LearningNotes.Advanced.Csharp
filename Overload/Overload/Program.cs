using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Program
    {
        static int Add(int x,int y)
        {
            return x + y;
        }
        double Add(int x, double y)//重写Add()方法，返回值和参数的类型与第一个方法不同
        {
            return x + y;
        }
        int Add(int x, int y, int z)//重写Add()方法，参数数量比第一个方法多一个
        {
            return x + y + z;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            int x = 3;
            int y = 4;
            int z = 5;
            double y2 = 4.4;
            //根据传入的参数类型以及参数个数调用不同的Add()重载方法
            Console.WriteLine("3+4="+Program.Add(x,y));
            Console.WriteLine("3+4+5="+program.Add(x,y,z));
            Console.WriteLine("3+4.4=" + program.Add(x, y2));
            Console.ReadLine();
        }
    }
}
