using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_ClassAndMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveClass driveClass = new DriveClass();
            myClass myClass = driveClass;
            myClass.id = "AQ12138";
            myClass.Name = "CalacalaBoom";
            myClass.showInfo();
            Console.ReadLine();
        }
    }
    public abstract class myClass
    {
        private string ID;
        private string name;
        public string id
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
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
        public abstract void showInfo();
    }
    public class DriveClass : myClass
    {
        public override void showInfo()
        {
            Console.Write(id + " " + Name);
        }
    }
}
