using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingStatement
{
    class Program
    {
        static int division(string s1, string s2)
        {
            try
            {
                if (int.Parse(s2) == 0)
                {
                    throw new DivideByZeroException();
                }
                int num = int.Parse(s1) / int.Parse(s2);
                return num;
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine("尝试用0作为分母");
                Console.WriteLine(de.Message);
                return 0;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("请输入分子：");
                string s1 = Console.ReadLine();
                Console.Write("\n请输入分母：");
                string s2 = Console.ReadLine();
                Console.Write("\n"+s1+"/"+s2+"="+division(s1,s2));
            }
            catch (Exception ex)
            {
                Console.WriteLine("捕获异常：" + ex);
            }
            Console.ReadLine();
        }
    }
}
