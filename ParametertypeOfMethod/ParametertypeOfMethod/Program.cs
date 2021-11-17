using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametertypeOfMethod
{
    class Program
    {
        static void ExParams(params string[] list)
        {
            Console.WriteLine("params参数必须是一维数组\n");
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i]);
            }
            Console.WriteLine("\n");
        }
        static void ExRef(ref int i)
        {
            Console.WriteLine("\nref参数使方法按引用传递\n");
            i = 44;
        }
        static void ExOut(out int i)
        {
            Console.WriteLine("\nout关键字导致参数通过引用传递，与ref不同的是实参不用初始化\n");
            i = 88;
        }
        static void Main(string[] args)
        {
            String[] list = new string[] {"我","是","中","国","人"};
            ExParams(list);
            int Num0 = 0;
            ExRef(ref Num0);
            Console.WriteLine("Num0:"+Num0+"\n");
            int Num1;
            ExOut(out Num1);
            Console.WriteLine("Num1:"+Num1);
            Console.ReadLine();
        }
    }
}
