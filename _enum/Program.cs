﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _enum
{
    class Program
    {
        enum Directions
        {
            South=1,
            North,
            East,
            West
        }
        static void Main(string[] args)
        {
            //Directions myDirection;
            //myDirection = Directions.East;
            Directions myDirection = Directions.East;
            Console.WriteLine($"Direction:{myDirection}");

            //using var keyword
            var mydirection = Directions.West;
            Console.WriteLine(mydirection);

            //get the number of enum
            int code = (int)myDirection;
            Console.WriteLine(code);

            //get the value
            myDirection = (Directions)3;
            Console.WriteLine(myDirection);

            Console.ReadKey();
        }
    }
}
