using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Employee:Person
    {
        public double Salary;
        //Constructor without using this keyword
        public Employee(string fn,int a,double sa) : base(fn, a)
        {
            Salary = sa;
        }

        public Employee()
        {

        }
    }
}
