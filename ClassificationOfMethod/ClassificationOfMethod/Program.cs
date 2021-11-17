using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassificationOfMethod
{
    class Program
    {
        public static int SAdd(int x, int y)
        {
            return x + y;
        }
        public int DAdd(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            Console.WriteLine("静态方法不对特定实例进行操作，调用时直接使用类名进行调用");
            Console.WriteLine("静态方法调用：" + Program.SAdd(a, b)+"\n");
            Console.WriteLine("非静态方法是对特定实例进行操作，调用时，需要使用类的实例（对象）进行调用");
            Program program = new Program();
            Console.WriteLine("非静态方法调用：" + program.DAdd(c, d));
            Console.ReadLine();
        }
    }
}
