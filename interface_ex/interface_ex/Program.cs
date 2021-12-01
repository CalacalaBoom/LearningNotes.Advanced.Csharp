using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_ex
{
    interface IAttributes
    {
        string ID { get; set; }
        string Name { get; set; }
    }
    interface Ifly : IAttributes
    {
        void fly();
    }
    interface IEat : IAttributes
    {
        void eat();
    }

    class Bird:IAttributes,Ifly,IEat
    {
        string id = "";
        string name = "";
        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void fly()
        {
            Console.WriteLine("{0} {1} can fly now.",id,name);
        }
        public void eat()
        {
            Console.WriteLine("{0} {1} must eat now.",id,name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bird sparrow = new Bird();
            Ifly ifly = sparrow;
            ifly.ID = "001";
            ifly.Name = "麻雀";
            ifly.fly();
            Bird Magpie = new Bird();
            IEat ieat = Magpie;
            ieat.ID = "002";
            ieat.Name = "喜鹊";
            ieat.eat();
            Console.ReadLine();
        }
    }
}
