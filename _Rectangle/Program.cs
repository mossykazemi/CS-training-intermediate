using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Length:");
            //int l = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Length:");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Rectangle r1 = new Rectangle();
            //r1.SetLength(l);
            //r1.SetBreadth(b);
            //Console.WriteLine(r1.GetArea());


            Rectangle r1 = new Rectangle();
            r1.GetBreadth();
            r1.GetLength();
            Console.WriteLine(r1.GetArea());
            Console.ReadKey();
        }
    }
}
