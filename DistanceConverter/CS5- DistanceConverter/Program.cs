using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS5__DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // colors
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();

            Start:
            // getting number 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("    -Enter your Number:");
            Console.ForegroundColor = ConsoleColor.Black;
            double num = Convert.ToDouble(Console.ReadLine());

            //selecting converter
            Console.WriteLine("\n    -Select one converter:");
            start2:
            Console.Write("\n [1] Meter To Centimeter. \n\n [2] Meter To Milimeter. \n\n [3] Centimeter To Meter. \n\n [4] Milimeter To Centimeter.\n\n");
            int choise = Convert.ToInt32(Console.ReadLine());
            if (choise > 4)
            {
                Console.WriteLine("    Please select a Converter:");
                goto start2;
            }
            else
            {
                switch (choise)
                {
                    case 1:
                        Console.WriteLine(" "+(num)+ " Meter is =>  " +DistanceConverter.MeterToCentimeter(num) + " Centi Meters\n");
                        break;
                    case 2:
                        Console.WriteLine(" " + (num) + " Meter is =>  " + DistanceConverter.MeterToMilimeter(num) + " Mili Meters\n");
                        break;
                    case 3:
                        Console.WriteLine(" " + (num) + " Centimeter is =>  " + DistanceConverter.CentimeterToMeter(num) + " Meters\n");
                        break;
                    case 4:
                        Console.WriteLine(" " + (num) + " Milimeter is =>  " + DistanceConverter.MilimeterToCentimeter(num) + " Centimeters\n");
                        break;
                    //default:
                    //    Console.WriteLine("Please Enter 1 to 4");
                    //    break;
                }
            }
            Console.WriteLine(" = = = = = = = = = = = = = = = = = = = = = = = = = = = = \n");
            // Console.WriteLine("\n Press any key to start again");
            //Console.ReadKey();
            goto Start;
        }
    }
}
