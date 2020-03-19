using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArray
{
    class Program
    {
        static void TestArray(int[] numbers)
        {
            // print Array
            foreach (int a in numbers)
            {
                Console.WriteLine(a);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 50, 80, 100 };
            TestArray(arr);

            Console.ReadKey();
        }
    }
}
