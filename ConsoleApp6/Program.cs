using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    //Inheritance
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Mostafa",22,4321);
            //s1.SetId(1111);
            //Console.WriteLine(s1.id);

            Console.WriteLine(s1.Print());
            //s1.Age;
            s1.BirthDay();
            Employee e1 = new Employee();
            Faculty f1 = new Faculty();
            Person p1 = new Person();


            Console.ReadKey();
        }
    }
}
