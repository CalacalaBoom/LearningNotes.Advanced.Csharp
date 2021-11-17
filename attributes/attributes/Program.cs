using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attributes
{
    class Ex
    {
        private string id = "";//私有变量只能在其声明类中使用
        private string name = "";
        public string ID//定义私有变量使其可写可读
        {
            get { return id; }
            set { id = value; }
        }
        public string Name//定义私有变量使其可写可读
        {
            get { return name; }
            set { name = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ex ex = new Ex();
            ex.ID = "stu0001";
            ex.Name = "CalacalaBoom";
            Console.WriteLine(ex.ID+" "+ex.Name);
            ex.ID = "stu0002";
            ex.Name = "SalisaliPia";
            Console.WriteLine(ex.ID + " " + ex.Name);
            Console.ReadLine();
        }
    }
}
