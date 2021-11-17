using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        struct Rect
        {
            public double wid;
            public double hei;
            public Rect(double x, double y)//构造函数
            {
                wid = x;
                hei = y;
            }
            public double Area()
            {
                return wid * hei;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("结构用来封装一组相关的变量，声明一个结构定义矩形的宽和高，自定义一个Area()方法用来计算矩形的面积");
            Rect rect1;
            rect1.wid = 5;
            rect1.hei = 3;
            Console.WriteLine("5*3矩形的面积是：" + rect1.Area());
            Rect rect2 = new Rect(6,4);//使用构造函数实例化矩形结构
            Console.WriteLine("6*4矩形的面积是：" + rect2.Area());
            Console.ReadLine();
        }
    }
}
