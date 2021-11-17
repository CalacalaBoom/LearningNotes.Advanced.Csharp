using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classPolymorphism
{
    class Program
    {
        private Program[] qtest = new Program[6];
        private int nextindex = 0;
        public void draw(Program p)
        {
            //定义draw()方法，参数为四边形对象
            if(nextindex<qtest.Length)
            {
                qtest[nextindex] = p;
                Console.WriteLine(nextindex);
                nextindex++;
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.draw(new Square());//以正方形对象为参数调用Programe类的draw()方法
            p.draw(new Parallelogramegle());//以平行四边形对象为参数调用Programe类的draw()方法
            Console.ReadLine();
        }
    }
    class Square : Program
    {
        //定义一个正方形类，继承自Programe类
        public Square()
        {
            Console.WriteLine("正方形");
        }
    }
    class Parallelogramegle : Program
    {
        public Parallelogramegle()
        {
            Console.WriteLine("平行四边形");
        }
    }
}
