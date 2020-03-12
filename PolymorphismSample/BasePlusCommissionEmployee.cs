using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSample
{
    class BasePlusCommissionEmployee:CommissionEmployee
    {
        private double basesalary;
        public double BaseSalary
        {
            set
            {
                basesalary = value;
            }
            get
            {
                return basesalary;
            }
        }
        public BasePlusCommissionEmployee(string fn, string ln, string ssn, double rate, double sales,double bsalary):base(fn, ln, ssn, rate, sales)
        {
            BaseSalary = bsalary;
        }
        public override double Earning()
        {
            return BaseSalary + base.Earning();
        }
        public override string ToString()
        {
            return "\n\nBase Plus Commission Employee: " + base.ToString() + "\nBase Salary: " + BaseSalary;
        }
    }
}
