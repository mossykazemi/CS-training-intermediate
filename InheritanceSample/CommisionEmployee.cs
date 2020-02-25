using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    class CommisionEmployee
    {
        private string firstName;
        private string lastName;
        private string socialSecurityNumber;
        private double grossSale;
        private double commisionRate;

        public string FirstName
        {
            set
            {
                firstName = value;
            }
            get
            {
                return firstName;
            }
        }
        public string LastName
        {
            set
            {
                lastName = value;
            }
            get
            {
                return lastName;
            }
        }
        public string SocialSecurityNumber
        {
            set
            {
                socialSecurityNumber = value;
            }
            get
            {
                return socialSecurityNumber;
            }
        }
        public double CommisionRate
        {
            set
            {
                if(value>0 && value<1)
                commisionRate = value;
                else
                    Console.WriteLine("Argument is out of range");
            }
            get
            {
                return commisionRate;
            }
        }
        public double GrossSale
        {
            set
            {
                grossSale = value;
            }
            get
            {
                return grossSale;
            }
        }
        public CommisionEmployee(string fn, string ln,string ssn,double sales, double rate = 0.1)
        {
            firstName = fn;
            LastName = ln;
            SocialSecurityNumber = ssn;
            GrossSale = sales;
            CommisionRate = rate;
        }
        public override string ToString()
        {
            string s;
            s = "Commision Employee:" + "\nName= " + FirstName + "\nLastname= " + LastName + "\nSSN= " + SocialSecurityNumber + "\nCommision rate= " + CommisionRate + "\nGross sale= " + GrossSale;
            return s;
        }
        public double Earning()
        {
            return CommisionRate * GrossSale;
        }
    }
}
