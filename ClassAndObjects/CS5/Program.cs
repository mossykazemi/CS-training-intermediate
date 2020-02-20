using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS5
{
    class Program
    {
        static void Main(string[] args)
        {

            MyClass obj1 = new MyClass();
            obj1.a = 10;
            MyClass obj2 = new MyClass();
            obj2.a = 120;
            MyClass obj3 = new MyClass();
            obj3.a = 40;

            obj1.SetB(200);
            MyClass.ShowB();

            Console.WriteLine($"value of a:{obj1.a} and value of b:{MyClass.b}");
            Console.WriteLine($"value of a:{obj2.a} and value of b:{MyClass.b}");
            Console.WriteLine($"value of a:{obj3.a} and value of b:{MyClass.b}");
            Console.ReadKey();
        }
    }
}
