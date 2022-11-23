using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program6
{
     class student
    {
        int rlno;
        string name;
        int[] mark = new int[3];
        int total;
        public void read()
        {
            Console.WriteLine("Enter roll no:");
            rlno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter marks of 3 subjects:");
            for (int i = 0; i < 3; i++)
            {
                mark[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void calculate()
        {
            total = mark[0] + mark[1] + mark[2];
        }
        public void display()
        {
            Console.WriteLine("Id={0}\nName={1}\nTotal={2}", rlno, name, total);
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number of students");
            n = Convert.ToInt32(Console.ReadLine());
            student[] obj = new student[n];
            for (int i = 0; i < n; i++)
            {
                obj[i] = new student();
                obj[i].read();
                obj[i].calculate();
                obj[i].display();
            }
            Console.ReadLine();
        }
    }
}

