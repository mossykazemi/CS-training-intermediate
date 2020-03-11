using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Mostafa";
            p1.Family = "Kazemi";

            Console.ReadKey();
        }
    }
}
