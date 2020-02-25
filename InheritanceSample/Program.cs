using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //CommisionEmployee e1 = new CommisionEmployee("Mostafa", "kazemi", "1234567890", 6000000, 0.2);
            //Console.WriteLine($"E1 Details: {e1.ToString()}");
            //Console.WriteLine(e1.Earning());
            //BasePlusCommisionEmployee b1 = new BasePlusCommisionEmployee("mark", "antony", "0123456789", 6000000, 0.2, 1800000);
            //Console.WriteLine($"B1 Details: {b1.ToString()}");
            //Console.WriteLine(b1.Earning());



            BasePlusCommisionEmployee b1 = new BasePlusCommisionEmployee("Mike", "hemingway", "0123456789", 6000000, 0.2, 1800000);
            CommisionEmployee e1 = b1;
            Console.WriteLine($"Total salary for b1 is:{b1.Earning()}");
            Console.WriteLine($"Total salary for e1 is:{e1.Earning()}");

            Console.ReadKey();
        }
    }
}
