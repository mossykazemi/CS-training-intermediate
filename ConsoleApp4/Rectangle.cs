using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Rectangle
    {
        int length;
        int breadth;
        public int Length
        {//Property
            set
            {
                length = value;
            }
            get
            {
                return length;
            }
        }
        public int Breadth
        {//Property
            set
            {
                breadth = value;
            }
            get
            {
                return breadth;
            }
        }
        public Colors ForeColor
        {
            set;get;
        }
    }
}
