using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAndHeight
{
    class Program
    {
        static void showPerson(int age,int height)
        {//two parameters
            Console.WriteLine($"Age is :{age}");
            Console.WriteLine($"Height is :{height}");
        }
        static void Main(string[] args)
        {
            //showPerson(22, 170);
            //showPerson(170, 22);

            showPerson(height: 170, age: 22);
            Console.ReadKey();
        }
    }
}
