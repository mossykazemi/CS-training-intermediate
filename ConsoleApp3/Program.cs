using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            //rect1.breadth = 20;
            //rect1.length = 10;

            rect1.SetBreadth(-20);
            rect1.SetLength(40);
            Console.WriteLine(rect1.GetArea());
            Console.ReadKey();
        }
    }
}
