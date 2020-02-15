using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Rectangle
    {
         int length;
         int breadth;
        public void SetLength(int newValue)
        {
            if (newValue < 0)
            {
                Console.WriteLine("The number is less than zero!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            length = newValue;
        }
        public void SetBreadth(int newValue)
        {
            if (newValue < 0)
            {
                Console.WriteLine("The number is less than zero!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            breadth = newValue;
        }
        public int GetArea()
        {//Calculate Are 
            return 2 * (length + breadth);
        }
    }
}
