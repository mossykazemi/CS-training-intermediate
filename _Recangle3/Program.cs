using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Recangle3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.SetDiamentions(10, 20);
            Console.WriteLine(r1.GetArea());
        }
    }
}
