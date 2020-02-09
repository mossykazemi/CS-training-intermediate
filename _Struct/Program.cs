using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Struct
{
    class Program
    {
        public struct Employee
        {//Struct
            public string name;
            public int age;
            public double salary;
            public void SayThanks()
            {
                Console.WriteLine($"Thank You {name}");
            }
        }
        static void Main(string[] args)
        {
            Employee e1;
            Employee e2;
            e1.name = "Mostafa Kazemi";
            e1.age = 22;
            e1.salary = 2000000;
            e2.name = "hasan hasani";
            e2.age = 30;
            e2.salary = 1500000;

            Console.WriteLine($"Employee1 details :\n Name:{e1.name}\n Age:{e1.age} \n Salary:{e1.salary}");
            e1.SayThanks();
            Console.WriteLine($"Employee2 details :\n Name:{e2.name}\n Age:{e2.age} \n Salary:{e2.salary}");
            e2.SayThanks();

            Console.ReadKey();
        }
    }
}
