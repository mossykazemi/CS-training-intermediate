using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class MyClass
    {
        public int a;
        public static int b;
        public void SetB(int n)
        {
            b = n;
            //Get value from user
        }
        public static void ShowB()
        {
            Console.WriteLine(b);
        }
        //Static methods can be use in both static methods and normal methods
        //But normal Methods are only can be used in normal Methods
    }
}
