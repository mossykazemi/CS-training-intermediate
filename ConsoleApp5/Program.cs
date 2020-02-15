using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // static is Shared memory
            // MyClass.b = 30;
            MyClass obj1 = new MyClass();
            obj1.a = 10;
            MyClass obj2 = new MyClass();
            obj2.a = 20;
            MyClass obj3 = new MyClass();
            obj3.a = 30;

            // MyClass.b = 100;
            // 100 is Override here

            obj1.SetB(200);
            MyClass.ShowB();

            Console.WriteLine($"Value of a :{obj1.a} and Value of b :{MyClass.b}");
            Console.WriteLine($"Value of a :{obj2.a} and Value of b :{MyClass.b}");
            Console.WriteLine($"Value of a :{obj3.a} and Value of b :{MyClass.b}");

            Console.ReadKey();
        }
    }
}
