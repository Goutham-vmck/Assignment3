using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack my_stack = new Stack();
            my_stack.Push("Goutham");
            my_stack.Push("Gouri");
            my_stack.Push("dsdsds");
            my_stack.Push("sdascsdv");
            Console.WriteLine("Total elements present in" + " my_stack: {0}", my_stack.Count);

            Console.WriteLine("Topmost element of my_stack" + " is: {0}", my_stack.Pop());

            Console.WriteLine("Total elements present in" + " my_stack: {0}", my_stack.Count);

            Console.WriteLine("Topmost element of my_stack " + "is: {0}", my_stack.Peek());

            Console.WriteLine("Total elements present " + "in my_stack: {0}", my_stack.Count);

            my_stack.Clear();

            Console.WriteLine("Total elements present in " + "my_stack: {0}", my_stack.Count);
            Console.ReadKey();

        }
    }
}
