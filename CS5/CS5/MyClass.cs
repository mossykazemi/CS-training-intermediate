using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS5
{
    class MyClass
    {
        public int a;
        public static int b;
        public void SetB(int n)
        {
            b = n;
        }
        public static void ShowB()
        {
            Console.WriteLine(b);
        }
    }
}
