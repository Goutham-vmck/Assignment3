using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class student
    {
        public string name;
        public int rlno;
        public void displaydetails()
        {
            Console.WriteLine("student name: {0}", name);
            Console.WriteLine("rollno: {0}", rlno);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            student s2 = new student();
            s1.name = "Goutham";
            s1.rlno = 1;
            s1.displaydetails();
            s2.name = "Gouri";
            s2.rlno = 2;
            s2.displaydetails();
            Console.ReadLine();
        }
    }
}
