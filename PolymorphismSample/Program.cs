using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSample
{
    class Program
    {
        static void Main(string[] args)
        {
            SalariedEmployee s = new SalariedEmployee("Mossy", "Kazemi", "45858565", 2000000);
            CommissionEmployee c = new CommissionEmployee("asghar", "asghari", "85858585", 0.4, 3000000);
            BasePlusCommissionEmployee b = new BasePlusCommissionEmployee("hasan", "hasani", "58585858", 0.4, 3000000, 2000000);
            HourlyEmployee h = new HourlyEmployee("akbar", "akbari", "58545652", 6500, 50);
            //static Polymorphism
            //Console.WriteLine(s.ToString() + "\nPayment: " + s.Earning());
            //Console.WriteLine(c.ToString() + "\nPayment: " + c.Earning());
            //Console.WriteLine(b.ToString() + "\nPayment: " + b.Earning());
            //Console.WriteLine(h.ToString() + "\nPayment: " + h.Earning());


            // dynamic Polymorphism
            //Employee[] list = new Employee[4];
            //list[0] = s;
            //list[1] = c;
            //list[2] = b;
            //list[3] = h;
            //foreach(Employee x in list)
            //{
            //    Console.WriteLine(s.ToString()+"\nPayment: "+x.Earning());
            //}
            //Console.ReadKey();

            Employee[] list = new Employee[4];
            list[0] = s;
            list[1] = c;
            list[2] = b;
            list[3] = h;
            foreach (Employee x in list)
            {
                if(x is BasePlusCommissionEmployee)
                {
                    BasePlusCommissionEmployee b1 = (BasePlusCommissionEmployee)x;
                    b1.BaseSalary *= 1.10;
                }
                Console.WriteLine(s.ToString() + "\nPayment: " + x.Earning());
            }
            Console.ReadKey();
        }
    }
}
