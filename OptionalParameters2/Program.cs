using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters2
{
    class Program
    {
        //Optional Prameters
        static void Method(int a,int b, int c=100,int d = 200)
        {
            Console.WriteLine($"a:{a}");
            Console.WriteLine($"b:{b}");
            Console.WriteLine($"c:{c}");
            Console.WriteLine($"d:{d}");
        }
        static void Main(string[] args)
        {
            Method(10, 20,d:500);
            // we give value to d by using ( : )   and we didn't give c any value
            Console.ReadKey();
        }
    }
}
