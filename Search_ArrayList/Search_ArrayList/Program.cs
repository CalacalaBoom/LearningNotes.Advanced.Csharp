using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Search_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayList类提供了一个Contain()方法来确定一个元素是否在ArrayList对象中：");
            ArrayList list = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            Console.Write("原数组：");
            foreach (int n in list)
            {
                Console.Write(n+" ");
            }
            Console.WriteLine("\n");
            if (list.Contains(2))
            {
                Console.WriteLine("2在该ArrayList对象中");
            }
            else
            {
                Console.WriteLine("2不在该ArrayList对象中");
            }
            Console.ReadLine();
        }
    }
}
