using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _paramsExample
{
    class Parameters
    {
        //public double Average(double x, double y)
        //{
        //    return (x + y) / 2;
        //}
        //public double Average(double x, double y, double c)
        //{
        //    return (x + y + c) / 3;
        //}
        //public double Average(double x, double y, double c, double z)
        //{
        //    return (x + y + c + z) / 4;
        //}


            //Using Params keyword instead of Overloading
        public double Average(params double [] numbers)
        {
            double sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum / numbers.Length; 
        }
    }
}
