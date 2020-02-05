using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Parameters
{
    class Program
    {
        static private void func1(Parameters x)
        {
            x.a = 1000;
        }
        static void Main(string[] args)
        {
            Parameters p1 = new Parameters();
            int x = 10;
            p1.passByVal(x);
            p1.passByRef(ref x);
            Console.WriteLine(x);

            int a;
            p1.passByOut(out a);
            Console.WriteLine(a);

            Parameters c1 = new Parameters();
            c1.a = 50;
            Console.WriteLine(c1.a);
            func1(c1);
            Console.WriteLine(c1.a);


            Console.ReadKey();
        }
    }
}
