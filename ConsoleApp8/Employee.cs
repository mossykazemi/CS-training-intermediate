using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
     abstract class Employee:IPayable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public override string ToString()
        {
            return "\nName: " + FirstName + " " + LastName + "\nSSN: " + SocialSecurityNumber;
        }
        public Employee(string fn,string ln,string ssn)
        {
            FirstName = fn;
            LastName = ln;
            SocialSecurityNumber = ssn;
        }
        public abstract double Earning();
        public abstract double GetPaymentAmount();
    }
}
