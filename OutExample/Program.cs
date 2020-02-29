using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutExample
{
    class Program
    {
        static void GetValue(out int number)
        {
            number = 10;
        }
        static void Main(string[] args)
        {
            int num;
            GetValue(out num);
            Console.WriteLine($"Number is : {num}");

            Console.ReadKey();
        }
    }
}
