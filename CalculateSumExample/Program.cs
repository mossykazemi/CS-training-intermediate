﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSumExample
{
    class Program
    {
        static int CalculateSum(int number1,int number2)
        {//Static method
            return number1 + number2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter number 1:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2:");
            int y = Convert.ToInt32(Console.ReadLine());
            // we give two argument to the program here 
            Console.WriteLine(CalculateSum(x,y)); 
            Console.ReadKey();
        }
    }
}
