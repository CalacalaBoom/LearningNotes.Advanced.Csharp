using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Delete_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("有Clear()和Remove()两种方法来达到删除哈希表元素的目的\n");
            Hashtable hashtable = new Hashtable();
            hashtable.Add("id","1506");
            hashtable.Add("name", "CalacalaBoom");
            hashtable.Add("sex", "男");
            //哈希表的遍历用到了DictionaryEntry结构，这个结构表示一个键/值对的集合
            Console.WriteLine("原哈希表：");
            Console.Write("\t键 \t值\n");
            foreach (DictionaryEntry dictionary in hashtable)
            {
                Console.WriteLine("\t" + dictionary.Key + " \t" + dictionary.Value);
            }
            Console.WriteLine("1.Clear()  2.Remove()  0.Exit");
            bool isExit = true;
            do
            {
                string i = Console.ReadLine();
                switch (i)
                {
                    case "1":
                        ClearHashtable(hashtable);
                        break;
                    case "2":
                        RemoveHashtable(hashtable);
                        break;
                    case "0":
                        isExit = false;
                        break;
                }
            } while (isExit);
        }
        static void ClearHashtable(Hashtable hashtable)
        {
            Console.WriteLine("使用Clear()方法清除哈希表中的所有元素\n");
            hashtable.Clear();
            Console.WriteLine("删除之后：");
            Console.Write("\t键 \t值\n");
            foreach (DictionaryEntry dictionary in hashtable)
            {
                Console.WriteLine("\t" + dictionary.Key + " \t" + dictionary.Value);
            }
        }
        static void RemoveHashtable(Hashtable hashtable)
        {
            Console.WriteLine("使用Remove()方法删除指定键所对应的键/值对\n");
            hashtable.Remove("sex");
            Console.WriteLine("删除之后：");
            Console.Write("\t键 \t值\n");
            foreach (DictionaryEntry dictionary in hashtable)
            {
                Console.WriteLine("\t" + dictionary.Key + " \t" + dictionary.Value);
            }
        }
    }
}
