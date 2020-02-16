using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Person
    {
        private string name;
        protected int age;
        public string SocialSecurityNumber;
        public int id;
        public string Print()
        {
            string s;
            s = "Name= " + name + "\nAge= " + age;
            return s;
        }
        public void SetId(int n)
        {
            id = n;
        }

        public Person(string fn,int a)
        {
            name = fn;
            age = a;
        }
        public Person()
        {

        }
        // private members are inherited but not accessible
        // we can access private members by using Property
        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }
        public void BirthDay()
        {
            Age++;
        }
    }
}
