using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverterVid
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Enter Your Number:");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Select one Converter:");
            Console.WriteLine("\n [1]MeterToCentimeter. \n [2]MeterToMilimeter. \n [3]CentimeterToMeter. \n [4]MiliToCentimeter");
            int choise = Convert.ToInt32(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.WriteLine(DistanceConverter.MeterToCentimeter(num)); 
                    break;
                case 2:
                    Console.WriteLine(DistanceConverter.MeterToMilimeter(num)); 
                    break;
                case 3:
                    Console.WriteLine(DistanceConverter.CentimeterToMeter(num)); 
                    break;
                case 4:
                    Console.WriteLine(DistanceConverter.MiliToCentimeter(num));
                    break;
                default:
                    Console.WriteLine("please Enter 1 to 4");
                    goto start;
                    //break;
            }

            //double cm;
            //cm=DistanceConverter.MiliToCentimeter(100);
            //Console.WriteLine(cm);
            Console.ReadKey();
        }
    }
}
