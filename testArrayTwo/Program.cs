using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testArrayTwo
{
    class Program
    {
        static void IncrementElements(int[] numbers)
        {
            for(int i=0; i<numbers.Length; i++)
            {
                numbers[i]++;
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 50, 80, 100 };
            IncrementElements(arr);
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
            // Array is Refrence Type ny it self and it's gonna be call by ref
            Console.ReadKey();
        }
    }
}
