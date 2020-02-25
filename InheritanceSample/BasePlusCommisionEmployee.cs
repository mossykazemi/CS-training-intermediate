using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    class BasePlusCommisionEmployee:CommisionEmployee
    {
        private double baseSalary;
        public double BaseSalary
        {
            set
            {
                baseSalary = value;
            }
            get
            {
                return baseSalary;
            }
        }
        public BasePlusCommisionEmployee(string fn, string ln, string ssn, double sales, double rate , double bsalary) : base(fn, ln, ssn, sales, rate)
        {
            BaseSalary = bsalary;
        }
        public override string ToString()
        {
            string s;
            s = "Base Plus Commision Employee: " +base.ToString() + "\nBase salary= " + BaseSalary;
            return s;
        }
        public new double Earning()
        {
            return BaseSalary + base.Earning();
        }
    }
}
