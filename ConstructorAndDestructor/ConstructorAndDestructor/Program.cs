using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndDestructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex ex = new Ex();//实例化对象时，构造函数已经自动调用
            Console.WriteLine("z="+ex.z);
            ex = null;//释放掉对象ex占用资源，此时垃圾还没有被清理所以没有调用析构函数
            GC.Collect(); //使用GC垃圾回收结束Ex对象，自动调用析构函数
            Console.ReadLine();
        }
    }
    class Ex
    {
        public int x = 1;
        public int y = 2;
        public int z = 0;
        public Ex()//定义构造函数
        {
            z = x + y;
        }
        ~Ex()//定义析构函数
        {
            Console.WriteLine("析构函数自动调用");
        }
    }
}
