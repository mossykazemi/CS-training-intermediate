using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_GenericCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.GetValues();
            bool r = r1.IsSquare;
            //r1.Length = -12;
            //r1.Breadth = 15;
            Console.WriteLine(r1.GetArea()+"\n"+r);

            Console.ReadKey();
        }
    }
}
