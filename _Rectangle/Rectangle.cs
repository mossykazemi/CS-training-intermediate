using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Rectangle
{
    class Rectangle
    {
        // variables
        int length;
        int breadth;
        public void SetLength(int newValue)
        {
            if (newValue < 0)
            {//set value of length and check value is greater than zero
                Console.WriteLine("The number is less than zero!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            length = newValue;
        }
        public void SetBreadth(int newValue)
        {
            if (newValue < 0)
            {//set value of breadth and check value is greater than zero
                Console.WriteLine("The number is less than zero!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            breadth = newValue;
        }
        public int GetArea()
        {//calculate value of area
            return 2 * (length + breadth);
        }
        public void GetLength()
        {//get length and set it
            Console.WriteLine("Enter length");
            int a = Convert.ToInt32(Console.ReadLine());
            SetLength(a);
        }
        public void GetBreadth()
        {//get breadth and set it
            Console.WriteLine("Enter Breadth");
            int b = Convert.ToInt32(Console.ReadLine());
            SetBreadth(b);
        }
    }
}
