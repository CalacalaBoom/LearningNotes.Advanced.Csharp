using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceMember
{
    interface Imyinterface1
    {
        int Add();
    }
    interface Imyinterface2
    {
        int Add();
    }
    class myClass : Imyinterface1, Imyinterface2
    {
        int Imyinterface1.Add()
        {
            int x = 3;
            int y = 2;
            return x + y;
        }
        int Imyinterface2.Add()
        {
            int x = 3;
            int y = 2;
            int z = 5;
            return x + y + z;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass myclass=new myClass();
            Imyinterface1 imyinterface1 = myclass;
            Imyinterface2 imyinterface2 = myclass;
            Console.WriteLine(imyinterface1.Add());
            Console.WriteLine(imyinterface2.Add());
            Console.Read();
        }
    }
}
