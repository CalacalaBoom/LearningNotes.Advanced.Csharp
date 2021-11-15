using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Traverse_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("朝辞白帝彩云间");
            list.Add("一花一叶一世界");
            list.Add("借问酒家何处有");
            list.Add("Anybody say hello");
            foreach (string n in list)
                Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
