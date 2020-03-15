using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveMethodFactorial
{
    class Program
    {
        //Recursive
        static long Factorial(int number)
        {
            if (number == 1)
                return 1;
            return number * Factorial(number - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));

            // -----------//

            //Console.WriteLine("Enter a Number :");
            //int num = Convert.ToInt32(Console.ReadLine());
            //long factorial = 1;
            //for (int i = num; i >= 1 ; i--)
            //{
            //    factorial *= i;
            //}
            //Console.WriteLine(factorial);

            Console.ReadKey();
        }
    }
}
