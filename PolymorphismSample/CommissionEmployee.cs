using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSample
{
    class CommissionEmployee:Employee
    {
        private double grosssales;
        private double commissionrate;
        public double GrossSales
        {
            set
            {
                grosssales = value;
            }
            get
            {
                return grosssales;
            }
        }
        public double CommissionRate
        {
            set
            {
                commissionrate = value;
            }
            get
            {
                return commissionrate;
            }
        }
        public CommissionEmployee(string fn,string ln,string ssn,double rate, double sales):base(fn, ln, ssn)
        {
            GrossSales = sales;
            CommissionRate = rate;
        }
        public override double Earning()
        {
            return GrossSales * CommissionRate;
        }
        public override string ToString()
        {
            return "\n\nCommission Employee: " + base.ToString() + "\nGross Sale: " + GrossSales + "\nCommision rate:" + CommissionRate;
        }
    }
}
