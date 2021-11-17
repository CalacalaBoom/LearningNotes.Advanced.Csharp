using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex ex = new Ex();
            ex.X = 1;
            ex.Y = 2;
            Console.WriteLine(ex.Add());
            Console.ReadLine();
        }
    }
    class Ex
    {
        private int x=0;
        private int y=0;
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
        public int Add()
        {
            return X + Y;
        }
    }
}
