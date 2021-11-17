using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex ex=new Ex();
            ExSon exSon = new ExSon();
            ex.X = 1;
            ex.Y = 2;
            exSon.X = 3;
            exSon.Y = 4;
            exSon.Z = 5;
            Console.WriteLine(ex.Add1());//1+2
            Console.WriteLine(exSon.Add1());//3+4
            Console.WriteLine(exSon.Add2());//3+4+5
            Console.ReadLine();
        }
    }
    class Ex
    {
        private int x = 0;
        private int y = 0;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Add1()
        {
            return X + Y;
        }
    }
    class ExSon : Ex
    {
        private int z = 0;
        public int Z
        {
            get { return z; }
            set { z = value; }
        }
        public int Add2()
        {
            return X + Y + Z;
        }
    }
}
