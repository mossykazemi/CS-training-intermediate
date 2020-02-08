using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Recangle3
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
        {
            return 2 * (length + breadth);
        }
        public void GetLength()
        {
            Console.WriteLine("Enter length");
            int a = Convert.ToInt32(Console.ReadLine());
            SetLength(a);
        }
        public void GetBreadth()
        {
            Console.WriteLine("Enter Breadth");
            int b = Convert.ToInt32(Console.ReadLine());
            SetBreadth(b);
        }
        public void SetDiamentions(int length, int breadth)
        {// to set the diamentions in the main program 
            this.length = length;
            this.breadth = breadth;
        }
    }
}
