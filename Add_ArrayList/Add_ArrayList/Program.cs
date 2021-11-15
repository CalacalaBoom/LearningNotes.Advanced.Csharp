using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;//ArrayList类位于System.Collections,需要using才能使用

namespace Add_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("向ArrayList集合中添加元素有Add()和Insert()两种方法：");
            Console.WriteLine("\n原数组：1 2 3 4 5 6 7 8 9 0");
            Console.WriteLine("1.Add()  2.Insert()  0.Exit");
            int[] arr = new int[] {1,2,3,4,5,6,7,8,9,0};
            ArrayList List = new ArrayList(arr);
            bool isExit = true;
            do
            {
                string i = Console.ReadLine();
                switch (i)
                {
                    case "1":
                        AddtoArrayList(List);
                        break;
                    case "2":
                        InserttoArrayList(List);
                        break;
                    case "0":
                        isExit = false;
                        break;
                }
            } while (isExit);
        }
        static void AddtoArrayList(ArrayList List)
        {
            Console.WriteLine("Add()方法向ArrayList对象的末尾添加元素");
            for(int i = 0;i < 5;i++)
            {
                List.Add(i);
            }
            Console.Write("插入后的数组为：");
            foreach (int n in List)
            {
                Console.Write(n+" ");
            }
            Console.WriteLine();
        }
        static void InserttoArrayList(ArrayList List)
        {
            Console.WriteLine("Insert()方法向ArrayList对象的指定位置插入元素");
            List.Insert(6,6);
            Console.Write("插入后的数组为：");
            foreach (int n in List)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }

    }
}
