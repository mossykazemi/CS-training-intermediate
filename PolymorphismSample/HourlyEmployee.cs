using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSample
{
    class HourlyEmployee:Employee
    {
        private double wage;
        private double hours;
        public double Wage
        {
            set
            {
                wage = value;
            }
            get
            {
                return wage;
            }
        }
        public double Hours
        {
            set
            {
                hours = value;
            }
            get
            {
                return hours;
            }
        }
        public HourlyEmployee(string fn, string ln, string ssn,double w,double hourwork) : base(fn, ln, ssn)
        {
            Wage = w;
            Hours = hourwork;
        }
        public override double Earning()
        {
            if (Hours > 40)
                return (40 * Wage + (Hours - 40) * Wage * 1.5);
            else
                return Hours * Wage;
        }
        public override string ToString()
        {
            return "\n\nHourly Employee: " + base.ToString() + "\nHour Worked: " + Hours + "\nWage: " + Wage;
        }
    }
}
