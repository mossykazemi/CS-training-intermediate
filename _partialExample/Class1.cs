using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _partialExample
{
    //using partial keyword
    partial class MyClass
    {
        public void Method2()
        {
            Console.WriteLine("I am in method 2");
        }
    }
}
