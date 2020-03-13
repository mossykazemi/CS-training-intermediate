using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_GenericCode
{
    //Generic Class
    class Rectangle
    {
        private int length;
        private int breadth;

        public int Length
        {
            set
            {
                if (value < 0)
                {
                   Console.WriteLine("Error");
                   Console.ReadKey();
                   Environment.Exit(0);
                }
              
                length = value;
            }
            get
            {
                return length;
            }
        }
        public int Breadth
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                breadth = value;
            }
            get
            {
                return breadth;
            }
        }

        public void GetValues()
        {
            Console.WriteLine("Enter length of rectangle");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth of rectangle");
            int b = Convert.ToInt32(Console.ReadLine());
            Length = a;
            Breadth = b;
        }
        public bool IsSquare
        {
            get
            {
                if (Length == Breadth)
                    return true;
                else
                    return false;
            }
        }

        public int GetArea()
        {
            return 2 * (length + breadth);
        }
    }
}
