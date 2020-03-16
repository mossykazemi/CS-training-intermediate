using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnType
{
    class Program
    {
        //Test return Keyword
        static void testReturn()
        {
            Console.WriteLine("first line of method");
            Console.WriteLine("second line of method");
            //return;
            // code will stop here because of return
            Console.WriteLine("third line of method");
            Console.WriteLine("fourth line of method");


        }
        static void Main(string[] args)
        {
            testReturn();

            Console.ReadKey();

        }
    }
}
