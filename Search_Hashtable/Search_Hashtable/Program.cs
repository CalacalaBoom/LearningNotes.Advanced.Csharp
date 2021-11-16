using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Search_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("ID","15263");
            hashtable.Add("name","CalacalaBoom");
            hashtable.Add("sex","男");
            Console.WriteLine("哈希表为：");
            Console.Write("\t键\t值\n");
            foreach (DictionaryEntry dictionaryEntry in hashtable)
            {
                Console.WriteLine("\t" + dictionaryEntry.Key + "\t" + dictionaryEntry.Value);
            }
            Console.WriteLine("在Hashtable中查找元素，可是用Hashtable类提供的Contains()、ContainsKey()和ContainsValue()方法");
            Console.WriteLine("1.Contains() 2.ContainsKey() 3.ContainsValue() 0.Exit");
            bool isExit = true;
            do
            {
                string i = Console.ReadLine();
                switch (i)
                {
                    case "1":
                        ContainsHashtable(hashtable);
                        break;
                    case "2":
                        ContainsKeyHashtable(hashtable);
                        break;
                    case "3":
                        ContainsValueHashtable(hashtable);
                        break;
                    case "0":
                        isExit = false;
                        break;
                }
            } while (isExit);
        }
        static void ContainsHashtable(Hashtable hashtable)
        {
            Console.WriteLine("Contains()方法用来确定Hashtable中是否包含特定键");
            Console.WriteLine("hashtable中是否包含ID键："+hashtable.Contains("ID"));
        }
        static void ContainsKeyHashtable(Hashtable hashtable)
        {
            Console.WriteLine("ContainsKey()方法等于Contains()方法");
            Console.WriteLine("hashtable中是否包含ID键：" + hashtable.ContainsKey("ID"));
        }
        static void ContainsValueHashtable(Hashtable hashtable)
        {
            Console.WriteLine("ContainsValue()方法用来确定Hashtable中是否包含指定的值");
            Console.WriteLine("hashtable中是否包含“女”："+hashtable.ContainsValue("女"));
        }
    }
}
