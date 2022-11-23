using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    public class details
    {
        public string name = "goutham";
        public int age = 23;
        public string loc = "kalady";
        public virtual void getdata()
        {
            Console.WriteLine("name: {0}", name);
            Console.WriteLine("age: {0}", age);
        }
    }
    public class stud_details : details
    {
        public override void getdata()
        {
            base.getdata();
            Console.WriteLine("location: {0}",base.loc);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            stud_details d = new stud_details();
            d.getdata();
            Console.ReadKey();

        }
    }
}
