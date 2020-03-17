using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedExample
{
    class ClassA
    {
        public virtual void func()
        {
            Console.WriteLine("Hello");
        }
    }
    class ClassB:ClassA
    {
        sealed public override void func()
        {
            Console.WriteLine("Bye");
        }
    }
    class ClassC:ClassB
    {
        
    }
}
