using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDate d1 = new MyDate(22,7,1398);
            MyDate d2 = new MyDate();
            MyDate d3 = new MyDate(1, 6, 1398);

            //d2 = d1.Add1(15);
            //d2 = d1.Add2(15);
            //d2 = d1.Remove(365);


            //d2 = d1 + 365;
            //d2 = 7 + d1;

            //Console.WriteLine(d1.ToString());
            //Console.WriteLine(d2.ToString());


            //if (d1 > d3)
            //    Console.WriteLine("d3 is greater than d1");
            //else
            //    Console.WriteLine("d1 is greater than d3");


            //d1++;
            //++d1;
            //d1--;
            //--d1;
            //Console.WriteLine(d1.ToString());


            //MyDate d = new MyDate(1,4,1398);
            //int a;
            //a =(int) d;
            //Console.WriteLine($"{a.ToString()}");
            //string s;
            //s = d;
            //Console.WriteLine(s);

            MyDate d = new MyDate(1, 1, 1398);
            if(d)
                Console.WriteLine("Happy new Year");

            Console.ReadKey();
        }
    }
}
