using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSample
{
    class SalariedEmployee:Employee
    {
        private double weeklysalary;
        public double WeeklySalary
        {
            set
            {
                weeklysalary = value;
            }
            get
            {
                return weeklysalary;
            }
        }
        private double weeklySalary;
        public SalariedEmployee(string fn,string ln,string ssn,double salary) : base(fn, ln, ssn)
        {
            WeeklySalary = salary;
        }
        public override double Earning()
        {
            return WeeklySalary;
        }
        public override string ToString()
        {
            return "\nSalaried Employee: " + base.ToString() + "\nWeekly Salary: " + WeeklySalary; 
        }
    }
}
