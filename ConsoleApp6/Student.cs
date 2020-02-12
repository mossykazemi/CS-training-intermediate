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

        // kalameye base mire fn va a ro az kelase asli maire va set mikone baraye sazande
        public Student(string fn,int a,int id) : base(fn, a)
        {
            this.id = id;
            // this ro be kar bordim chon id va id ham naam hastan
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
