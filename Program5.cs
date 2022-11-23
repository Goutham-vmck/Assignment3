using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program5
{
    class BOOK
    {
        private int BOOKNO;
        private string BOOKTITLE;
        private float PRICE;
        
        private float TOTAL_COST(int N)
        {
            return PRICE * N;
        }
        public void INPUT()
        {
            Console.Write("Enter Book No: ");
            BOOKNO = int.Parse(Console.ReadLine());
            Console.Write("Enter Book Title: ");
            BOOKTITLE = Console.ReadLine();
            Console.Write("Enter Price: ");
            PRICE = int.Parse(Console.ReadLine());
        }
        public void PURCHASE()
        {
            Console.Write("Enter the number of copies to be purchased: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Total cost to be paid: {0}", TOTAL_COST(N));
        }
        public void DISPLAY()
        {
            Console.WriteLine("Book No: {0}", BOOKNO);
            Console.WriteLine("Book Title: {0}", BOOKTITLE);
            Console.WriteLine("Price: {0}", PRICE);
        }
        static void Main(string[] args)
        {
            BOOK b = new BOOK();
            b.INPUT();
            b.PURCHASE();
            b.DISPLAY();
            Console.ReadLine();
        }
    }
}
