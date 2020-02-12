using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class ClassA
    {
        public virtual void SayHello()
        {
            Console.WriteLine("Say Hello in Class A");
        }
    }
    class ClassB : ClassA
    {
        public override void SayHello()
        {
            Console.WriteLine("Say Hello in Class B");
        }
        //public override void SayHello()
        //{
        //    base.SayHello();
        //}

    }
    class ClassC : ClassB
    {

    }
}
