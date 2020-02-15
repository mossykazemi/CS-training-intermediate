using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Colors myColor;
            //myColor = Colors.red;
            //Console.WriteLine(myColor);
            //Console.WriteLine((int)myColor);

            Rectangle r1 = new Rectangle();
            r1.ForeColor = Colors.red;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            Console.WriteLine(r1.ForeColor);
            Console.WriteLine((int)r1.ForeColor);//cast to int


            Console.ReadKey();

        }
    }
}
