using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Add_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hashtable用于存储键值对，键与值一一对应。使用Add()方法添加元素");
            Hashtable hashtable = new Hashtable();
            hashtable.Add("id","stu0001");
            hashtable.Add("username","CalacalaBoom");
            hashtable.Add("password","admin");
            Console.WriteLine(hashtable.Count);
            Console.ReadLine();
        }
    }
}
