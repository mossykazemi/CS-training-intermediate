using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Rectangle2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Rectangle r2;
            r2 = r1;// set r1 equal to r2
            r1.SetLength(10);
            r2.SetBreadth(20);
            Console.WriteLine(r1.GetArea());
            Console.ReadKey();
        }
    }
}
