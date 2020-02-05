using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _paramsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Parameters c1 = new Parameters();

            double[] myArray = { 12.5, 13, 14, 18 };
            Console.WriteLine(c1.Average(myArray));

            Console.WriteLine(c1.Average(5,10,20,5,6));

            Console.ReadKey();
        }
    }
}
