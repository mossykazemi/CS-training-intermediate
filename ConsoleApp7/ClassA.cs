using System;

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
