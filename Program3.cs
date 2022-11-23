using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    class Program
    {
        public static int SpaceCount(string str)
        {
            int spc = 0;
            string str1;
            for (int i = 0; i < str.Length; i++)
            {
                str1 = str.Substring(i, 1);
                if (str1 == " ")
                    spc++;
            }
            return spc;
        }
        static void Main(string[] args)
        {
            string str2;
            Console.Write("Please input a string : ");
            str2 = Console.ReadLine();
            Console.WriteLine("\"" + str2 + "\"" + " contains {0} spaces", SpaceCount(str2));
            Console.ReadKey();
        }
    }
}
