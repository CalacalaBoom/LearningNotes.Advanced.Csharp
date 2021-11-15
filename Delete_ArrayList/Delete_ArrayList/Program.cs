using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Delete_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayList类提供了以下四种方法来删除元素：");
            Console.WriteLine("1.Clear()  2.Remove()  3.RemoveAAt()  4.RemoveRange()  0.Exit");
            bool isExit = true;
            do
            {
                string i = Console.ReadLine();
                switch (i)
                {
                    case "1":
                        ClearArrayList();
                        break;
                    case "2":
                        RemoveArrayList();
                        break;
                    case "3":
                        RemoveAtArrayList();
                        break;
                    case "4":
                        RemoveRangeArrayList();
                        break;
                    case "0":
                        isExit = false;
                        break;
                }
            } while (isExit);
        }
        static void ClearArrayList()
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            Console.Write("原数组：");
            foreach (int n in list)
                Console.Write(n + " ");
            Console.WriteLine();
            list.Clear();//移除所有元素
            Console.Write("删除后的数组：");
            foreach (int n in list)
                Console.Write(n + " ");
            Console.WriteLine();
        }
        static void RemoveArrayList()
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            Console.Write("原数组：");
            foreach (int n in list)
                Console.Write(n + " ");
            Console.WriteLine();
            list.Remove(3);//移除与“3”匹配的元素
            Console.Write("删除后的数组：");
            foreach (int n in list)
                Console.Write(n + " ");
            Console.WriteLine();
        }
        static void RemoveAtArrayList()
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            Console.Write("原数组：");
            foreach (int n in list)
                Console.Write(n + " ");
            Console.WriteLine();
            list.RemoveAt(3);//移除索引为3的元素
            Console.Write("删除后的数组：");
            foreach (int n in list)
                Console.Write(n + " ");
            Console.WriteLine();
        }
        static void RemoveRangeArrayList()
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            Console.Write("原数组：");
            foreach (int n in list)
                Console.Write(n + " ");
            Console.WriteLine();
            list.RemoveRange(3,4);//移除索引为3处4个元素
            Console.Write("删除后的数组：");
            foreach (int n in list)
                Console.Write(n + " ");
            Console.WriteLine();
        }
    }
}
