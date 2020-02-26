using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyNumberVal
{
    class Program
    {
        // Pass by ref And Pass by value
        static void modifyNumberVal(int number)
        {
            number += 10;
            Console.WriteLine($"Value of number in method is: {number}");
        }
        static void modifyNumberRef(ref int number)
        {
            number += 10;
            Console.WriteLine($"Value of number in method is: {number}");
        }

        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine($"Number before pass the method: {num}");
            Console.WriteLine("Passing by value to method: ");
            modifyNumberVal(num);
            Console.WriteLine($"Number after passing by value: {num}");
            // by value yani ma yek copy az number ro darim pass midim be barname

            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Passing by value to method: ");
            Console.WriteLine($"Before pass by ref to method: {num}");
            modifyNumberRef(ref num);
            Console.WriteLine($"After passing by ref to method: {num}");


            Console.ReadKey();
        }
    }
}
