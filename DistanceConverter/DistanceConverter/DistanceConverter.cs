using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS5__DistanceConverter
{
    public static class DistanceConverter
    {
        public static double MeterToCentimeter(double m)
        {
            return 100 * m;
        }
        public static double MeterToMilimeter(double m)
        {
            return 1000 * m;
        }
        public static double CentimeterToMeter(double m)
        {
            return m / 100;
        }
        public static double MilimeterToCentimeter(double m)
        {
            return m / 10;
        }
    }
}
