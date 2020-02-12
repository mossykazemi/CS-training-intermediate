using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    //Interface Sample
    class Program
    {
        static void Main(string[] args)
        {
            Invoice v1 = new Invoice("100","Seat",5,60000);
            Invoice v2 = new Invoice("101", "desk", 4, 100000);
            HourlyEmployee h1 = new HourlyEmployee("Mostafa","Kazemi","52545658",100,10000);
            SalariedEmployee s1 = new SalariedEmployee("sadegh", "Naderi", "58545652", 3000000);

            IPayable[]list = new IPayable [4];
            list[0] = v1;
            list[1] = v2;
            list[2] = h1;
            list[3] = s1;

            double TotalPayment = 0;

            foreach (IPayable x in list)
            {
                //Console.WriteLine("\nPayment: " + x.GetPaymentAmount().ToString());
                Console.WriteLine(x.ToString()+"\nPayment: "+x.GetPaymentAmount().ToString());
                TotalPayment += x.GetPaymentAmount();
            }

            Console.WriteLine("--------------------");
            Console.WriteLine(TotalPayment.ToString());
            Console.ReadKey();
        }
    }
}
