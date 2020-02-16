using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Student:Person
    {
        public int id;
        public string Print()
        {
            string s;
            s =base.Print()+ "\nid= " + id;
            return s;
        }
        public new void SetId(int n)
        {
            id = n;
        }

        // base key word takes fn from base class and gives it to derived class
        public Student(string fn,int a,int id) : base(fn, a)
        {
            this.id = id;
            // we use this because id and id have the same name here
        }
        public bool Eligible()
        {
            if (age > 18)
                return true;
            else
                return false;
        }
    }
}
